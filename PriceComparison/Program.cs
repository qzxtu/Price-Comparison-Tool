using HtmlAgilityPack;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PriceComparison
{
    public static class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly ConcurrentDictionary<string, string> cache = new ConcurrentDictionary<string, string>();

        public static async Task Main(string[] args)
        {
            Console.Title = "Price Comparison Tool!";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Price Comparison Tool!");
            Console.ResetColor();
            Console.Write("Enter a search query: ");
            string query = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(query))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Please enter a valid search query.");
                Console.ResetColor();
                return;
            }

            var websites = new List<Website>
            {
                new Website
                {
                    Url = $"https://www.loltec.com/search?query={query}",
                    NameSelector = "//span[@class='product-name']",
                    PriceSelector = "//span[@class='product-price']",
                    ImageSelector = "//div[@class='image-holder']/img"
                },
                new Website
                {
                    Url = $"https://www.solostock.xyz/shop?search={query}",
                    NameSelector = "//a[@itemprop='name']",
                    PriceSelector = "//span[@class='oe_currency_value']",
                    ImageSelector = "//img[@class='img img-fluid']"
                },
                new Website
                {
                    Url = $"https://www.ptytec.com/catalog/search.php?val={query}",
                    NameSelector = "//div[@class='product-desc']/a",
                    PriceSelector = "//div[@class='py-2']/span[@class='fw-bold text-danger ps-2 fs-5']",
                    ImageSelector = "//div[@class='img-box position-relative']/a/img"
                }
            };

            var tasks = websites.Select(website => ScrapeWebsiteAsync(website));

            var products = (await Task.WhenAll(tasks)).SelectMany(p => p).ToList();

            Product cheapestProduct = products.OrderBy(product => product.Price).FirstOrDefault();

            if (cheapestProduct != null)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Cheapest Product: {cheapestProduct.Name}");
                Console.WriteLine($"Price: {cheapestProduct.Price.ToString("C", CultureInfo.InvariantCulture)}$");
                Console.WriteLine($"Image URL: {cheapestProduct.ImageUrl}");
                Console.WriteLine($"Website URL: {new Uri(cheapestProduct.WebsiteUrl).Host}");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No matching products found.");
                Console.ResetColor();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name}");
                Console.WriteLine($"Product Price: {product.Price}$");
                Console.WriteLine($"Product Image URL: {product.ImageUrl}");
                Console.WriteLine($"Website URL: {new Uri(product.WebsiteUrl).Host}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static async Task<IEnumerable<Product>> ScrapeWebsiteAsync(Website website)
        {
            try
            {
                string htmlContent = cache.GetOrAdd(website.Url, await client.GetStringAsync(website.Url).ConfigureAwait(false));

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                var nameElements = htmlDocument.DocumentNode.SelectNodes(website.NameSelector);
                var priceElements = htmlDocument.DocumentNode.SelectNodes(website.PriceSelector);
                var imageElements = htmlDocument.DocumentNode.SelectNodes(website.ImageSelector);

                if (nameElements != null && priceElements != null && imageElements != null)
                {
                    var productsBag = new ConcurrentBag<Product>();

                    Parallel.ForEach(Enumerable.Range(0, nameElements.Count), i =>
                    {
                        string nameText = nameElements[i].InnerText;
                        string priceText = priceElements[i].InnerText;
                        string imageUrl = imageElements[i].GetAttributeValue("src", "");

                        // Add the website domain to the image URL if it's a relative URL
                        imageUrl = imageUrl.StartsWith("http") || imageUrl.StartsWith("https")
                            ? imageUrl
                            : new Uri(new Uri(website.Url), imageUrl).ToString();

                        // Clean up the price text
                        priceText = priceText.Replace("$", "").Replace(",", "").Trim();

                        if (decimal.TryParse(priceText, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal price))
                        {
                            productsBag.Add(new Product
                            {
                                Name = nameText,
                                Price = price,
                                ImageUrl = imageUrl,
                                WebsiteUrl = website.Url
                            });
                        }
                    });

                    return productsBag;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"No matching products found on {new Uri(website.Url).Host}");
                    Console.ResetColor();
                    return Enumerable.Empty<Product>();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred while scraping data from {website.Url}: {ex.Message}");
                Console.ResetColor();
                return Enumerable.Empty<Product>();
            }
        }

        public class Website
        {
            public string Url { get; set; }
            public string NameSelector { get; set; }
            public string PriceSelector { get; set; }
            public string ImageSelector { get; set; }
        }

        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; }
            public string WebsiteUrl { get; set; }
        }
    }
}