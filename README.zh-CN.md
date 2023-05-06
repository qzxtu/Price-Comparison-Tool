# 价格比较工具

该程序是一个价格比较工具，允许用户在巴拿马的多家商店中搜索计算机产品并找到最便宜的价格。

## 翻译

<div align="left">
  <details open>
    <summary>:globe_with_meridians:</summary>
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
    </p>
  </details>
</div>

## Screenshot

![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)

## 作者

这个程序是由创建的[qzxtu](https://github.com/qzxtu).

## 免责声明

此工具仅用于教育目的。作者不对任何滥用此程序的行为负责。

## 怎么运行的

用户输入搜索查询，程序向多个网站发送请求以抓取产品信息。该程序然后比较产品的价格并显示最便宜的产品及其详细信息。

## 特征

-   Searches multiple computer stores in Panama for product information
-   查找给定产品的最低价格
-   显示有关最便宜产品的详细信息
-   使用缓存来提高性能
-   使用多线程来加速处理

## FAQ

**问：程序搜索哪些网站？**

A: The program currently searches three websites: `loltec.com`,`solostock.xyz`， 和`ptytec.com`.这些网站是位于巴拿马的电脑商店。

**问：我可以向该计划添加更多网站吗？**

答：是的，您可以通过修改`websites`列表中`Main`方法。您需要提供网站的 URL 以及产品名称、价格和图片的 CSS 选择器。

**问：数据多久更新一次？**

A：每次运行程序时，数据都会更新。该程序向网站发送请求并抓取最新的产品信息。

**问：我可以将此程序用于其他类型的产品吗？**

答：是的，您可以通过修改产品名称、价格和图像的搜索查询和 CSS 选择器，将此程序用于其他类型的产品。但是，请记住，该程序的当前版本针对在巴拿马的多家商店中搜索计算机产品进行了优化。
