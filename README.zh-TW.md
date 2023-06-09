# 價格比較工具

該程序是一個價格比較工具，允許用戶在巴拿馬的多家商店中搜索計算機產品並找到最便宜的價格。

## 

| 🇺🇸            | 🇨🇳                    | 🇹🇼                    | 🇮🇳                | 🇫🇷               | 🇦🇪                | 🇩🇪               | 🇯🇵                | 🇪🇸                 |
| --------------- | ----------------------- | ----------------------- | ------------------- | ------------------ | ------------------- | ------------------ | ------------------- | -------------------- |
| [英語](README.md) | [簡體中文](README.zh-CN.md) | [繁体中文](README.zh-TW.md) | [印地語](README.hi.md) | [法語](README.fr.md) | [阿拉伯](README.ar.md) | [德語](README.de.md) | [日本人](README.ja.md) | [西班牙語](README.es.md) |

## 截屏

![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)

## 作者

這個程序是由創建的[qzxtu](https://github.com/qzxtu).

## 免責聲明

此工具僅用於教育目的。作者不對任何濫用此程序的行為負責。

## 怎麼運行的

用戶輸入搜索查詢，程序向多個網站發送請求以抓取產品信息。該程序然後比較產品的價格並顯示最便宜的產品及其詳細信息。

## Features

-   在巴拿馬的多家電腦商店搜索產品信息
-   查找給定產品的最低價格
-   顯示有​​關最便宜產品的詳細信息
-   使用緩存來提高性能
-   Uses multithreading to speed up processing

## FAQ

**問：程序搜索哪些網站？**

A：程序目前搜索三個網站：`loltec.com`,`solostock.xyz`, and `ptytec.com`.這些網站是位於巴拿馬的電腦商店。

**問：我可以向該計劃添加更多網站嗎？**

A: Yes, you can add more websites to the program by modifying the `websites`列表中`Main`方法。您需要提供網站的 URL 以及產品名稱、價格和圖片的 CSS 選擇器。

**問：數據多久更新一次？**

A: The data is updated every time you run the program. The program sends requests to the websites and scrapes the latest product information.

**問：我可以將此程序用於其他類型的產品嗎？**

答：是的，您可以通過修改產品名稱、價格和圖像的搜索查詢和 CSS 選擇器，將此程序用於其他類型的產品。但是，請記住，該程序的當前版本已針對在巴拿馬的多家商店中搜索計算機產品進行了優化。
