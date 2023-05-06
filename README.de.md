# Preisvergleichstool

Dieses Programm ist ein Preisvergleichstool, mit dem Benutzer in mehreren Geschäften in Panama nach Computerprodukten suchen und den günstigsten Preis finden können.

## Bildschirmfoto

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

## Autor

This program was created by [qzxtu](https://github.com/qzxtu).

## Haftungsausschluss

Dieses Tool wurde nur für Bildungszwecke erstellt. Der Autor ist nicht verantwortlich für den Missbrauch dieses Programms.

## Wie es funktioniert

Der Benutzer gibt eine Suchanfrage ein und das Programm sendet Anfragen an mehrere Websites, um Produktinformationen zu kratzen. Das Programm vergleicht dann die Preise der Produkte und zeigt das günstigste Produkt mit seinen Details an.

## Merkmale

-   Durchsucht mehrere Computergeschäfte in Panama nach Produktinformationen
-   Findet den günstigsten Preis für ein bestimmtes Produkt
-   Zeigt detaillierte Informationen zum günstigsten Produkt an
-   Verwendet Caching, um die Leistung zu verbessern
-   Verwendet Multithreading, um die Verarbeitung zu beschleunigen

## FAQ

**F: Welche Websites durchsucht das Programm?**

A: Das Programm durchsucht derzeit drei Websites:`loltec.com`,`solostock.xyz`, Und`ptytec.com`. Diese Websites sind Computergeschäfte in Panama.

**F: Kann ich dem Programm weitere Websites hinzufügen?**

A: Ja, Sie können dem Programm weitere Websites hinzufügen, indem Sie die ändern`websites`Liste in der`Main`Methode. Sie müssen die URL der Website und die CSS-Selektoren für den Produktnamen, den Preis und das Bild angeben.

**F: Wie oft werden die Daten aktualisiert?**

A: Die Daten werden jedes Mal aktualisiert, wenn Sie das Programm ausführen. Das Programm sendet Anfragen an die Websites und kratzt die neuesten Produktinformationen.

**F: Kann ich dieses Programm für andere Produkttypen verwenden?**

A: Ja, Sie können dieses Programm für andere Produkttypen verwenden, indem Sie die Suchabfrage und die CSS-Selektoren für Produktname, Preis und Bild ändern. Beachten Sie jedoch, dass die aktuelle Version des Programms für die Suche nach Computerprodukten in mehreren Geschäften in Panama optimiert ist.
