# Price Comparison Tool

This program is a price comparison tool that allows users to search for computer products across multiple stores in Panamá and find the cheapest price.

## Screenshot
![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)


<div align="left">
    <p align="center">
      <a href="README.md"><img src="https://flagsapi.com/US/flat/32.png" height="11"> English</a>
      |
      <a href="README.zh-CN.md"><img src="https://flagsapi.com/CN/flat/32.png" height="11"> 简体中文</a>
      |
      <a href="README.zh-TW.md"><img src="https://flagsapi.com/TW/flat/32.png" height="11"> 繁体中文</a>
      |
      <a href="README.hi.md"><img src="https://flagsapi.com/IN/flat/32.png" height="11"> हिंदी</a>
      |
      <a href="README.fr.md"><img src="https://flagsapi.com/FR/flat/32.png" height="11"> Française</a>
      |
      <a href="README.ar.md"><img src="https://flagsapi.com/AE/flat/32.png" height="11"> عربى</a>
      |
      <a href="README.de.md"><img src="https://flagsapi.com/DE/flat/32.png" height="11"> Deutsch</a>
      |
      <a href="README.ja.md"><img src="https://flagsapi.com/JP/flat/32.png" height="11"> 日本語</a>
      |
      <a href="README.es.md"><img src="https://flagsapi.com/ES/flat/32.png" height="11"> Español</a>
    </p>
</div>

#

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
