# 価格比較ツール

このプログラムは、ユーザーがパナマの複数の店舗でコンピューター製品を検索し、最も安い価格を見つけることができる価格比較ツールです。

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
    </p>
</div>

# 

## 著者

このプログラムはによって作成されました[qzxtu](https://github.com/qzxtu)。

## 免責事項

このツールは、教育目的でのみ作成されました。作者は、このプログラムのいかなる誤用についても責任を負いません。

## 使い方

ユーザーが検索クエリを入力すると、プログラムが複数の Web サイトにリクエストを送信して、製品情報をスクレイピングします。次に、プログラムは製品の価格を比較し、最も安い製品とその詳細を表示します。

## 特徴

-   パナマの複数のコンピュータ ストアを検索して製品情報を取得します
-   特定の製品の最安値を検索します
-   最安商品の詳細情報を表示
-   キャッシュを使用してパフォーマンスを向上させる
-   マルチスレッドを使用して処理を高速化

## よくある質問

**Q: プログラムはどの Web サイトを検索しますか?**

A: プログラムは現在、次の 3 つの Web サイトを検索します。`loltec.com`、`solostock.xyz`、 と`ptytec.com`.これらの Web サイトは、パナマにあるコンピューター ストアです。

**Q: プログラムにウェブサイトを追加できますか?**

A: はい。`websites`のリスト`Main`方法。 Web サイトの URL と、製品名、価格、画像の CSS セレクターを提供する必要があります。

**Q: データはどのくらいの頻度で更新されますか?**

A: The data is updated every time you run the program. The program sends requests to the websites and scrapes the latest product information.

**Q: このプログラムを他のタイプの製品に使用できますか?**

A: Yes, you can use this program for other types of products by modifying the search query and the CSS selectors for the product name, price, and image. However, keep in mind that the current version of the program is optimized for searching computer products across multiple stores in Panama.
