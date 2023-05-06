# 価格比較ツール

このプログラムは、ユーザーがパナマの複数の店舗でコンピューター製品を検索し、最も安い価格を見つけることができる価格比較ツールです。

## スクリーンショット

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

## 著者

このプログラムはによって作成されました[qzxtu](https://github.com/qzxtu)。

## 免責事項

This tool was created for educational purposes only. The author is not responsible for any misuse of this program.

## 使い方

ユーザーが検索クエリを入力すると、プログラムは複数の Web サイトにリクエストを送信して製品情報をスクレイピングします。次に、プログラムは製品の価格を比較し、最も安い製品とその詳細を表示します。

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

A: プログラムを実行するたびにデータが更新されます。プログラムは Web サイトにリクエストを送信し、最新の製品情報をスクレイピングします。

**Q: このプログラムを他の種類の製品に使用できますか?**

A: はい。製品名、価格、画像の検索クエリと CSS セレクターを変更することで、このプログラムを他の種類の製品に使用できます。ただし、プログラムの現在のバージョンは、パナマの複数の店舗でコンピュータ製品を検索できるように最適化されていることに注意してください。
