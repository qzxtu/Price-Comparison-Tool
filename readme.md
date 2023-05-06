# Price Comparison Tool

This program is a price comparison tool that allows users to search for computer products across multiple stores in Panamá and find the cheapest price.

## README Translation
- [English](README.md)
- [简体中文](README.zh-CN.md)
- [繁体中文](README.zh-TW.md)
- [हिंदी](README.hi.md)
- [Française](README.fr.md)
- [عربى](README.ar.md)

## Screenshot
![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)

## Author

This program was created by [qzxtu](https://github.com/qzxtu).

## Disclaimer

This tool was created for educational purposes only. The author is not responsible for any misuse of this program.

## How it works

The user enters a search query and the program sends requests to multiple websites to scrape product information. The program then compares the prices of the products and displays the cheapest product along with its details.

## Features

- Searches multiple computer stores in Panama for product information
- Finds the cheapest price for a given product
- Displays detailed information about the cheapest product
- Uses caching to improve performance
- Uses multithreading to speed up processing

## FAQ

**Q: What websites does the program search?**

A: The program currently searches three websites: `loltec.com`, `solostock.xyz`, and `ptytec.com`. These websites are computer stores located in Panamá.

**Q: Can I add more websites to the program?**

A: Yes, you can add more websites to the program by modifying the `websites` list in the `Main` method. You will need to provide the URL of the website and the CSS selectors for the product name, price, and image.

**Q: How often is the data updated?**

A: The data is updated every time you run the program. The program sends requests to the websites and scrapes the latest product information.

**Q: Can I use this program for other types of products?**

A: Yes, you can use this program for other types of products by modifying the search query and the CSS selectors for the product name, price, and image. However, keep in mind that the current version of the program is optimized for searching computer products across multiple stores in Panama.