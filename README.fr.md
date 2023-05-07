# Outil de comparaison de prix

Ce programme est un outil de comparaison de prix qui permet aux utilisateurs de rechercher des produits informatiques dans plusieurs magasins au Panama et de trouver le prix le moins cher.

## 

| 🇺🇸                 | 🇨🇳                                 | 🇹🇼                                    | 🇮🇳                  | 🇫🇷                      | 🇦🇪                  | 🇩🇪                     | 🇯🇵                     | 🇪🇸                     |
| -------------------- | ------------------------------------ | --------------------------------------- | --------------------- | ------------------------- | --------------------- | ------------------------ | ------------------------ | ------------------------ |
| [Anglais](README.md) | [Chinois simplifié](README.zh-CN.md) | [chinois traditionnel](README.zh-TW.md) | [hindi](README.hi.md) | [Française](README.fr.md) | [arabe](README.ar.md) | [Allemand](README.de.md) | [Japonais](README.ja.md) | [Espagnol](README.es.md) |

## Capture d'écran

![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)

## Auteur

Ce programme a été créé par[qzxtu](https://github.com/qzxtu).

## Clause de non-responsabilité

This tool was created for educational purposes only. The author is not responsible for any misuse of this program.

## Comment ça fonctionne

L'utilisateur entre une requête de recherche et le programme envoie des demandes à plusieurs sites Web pour récupérer des informations sur les produits. Le programme compare ensuite les prix des produits et affiche le produit le moins cher avec ses détails.

## Caractéristiques

-   Recherche plusieurs magasins d'informatique au Panama pour obtenir des informations sur les produits
-   Trouve le prix le moins cher pour un produit donné
-   Affiche des informations détaillées sur le produit le moins cher
-   Utilise la mise en cache pour améliorer les performances
-   Utilise le multithreading pour accélérer le traitement

## FAQ

**Q : Quels sites Web le programme recherche-t-il ?**

R : Le programme recherche actuellement trois sites Web :`loltec.com`,`solostock.xyz`, et`ptytec.com`. Ces sites Web sont des magasins d'informatique situés au Panama.

**Q : Puis-je ajouter d'autres sites Web au programme ?**

R : Oui, vous pouvez ajouter d'autres sites Web au programme en modifiant le`websites`liste dans le`Main`méthode. Vous devrez fournir l'URL du site Web et les sélecteurs CSS pour le nom, le prix et l'image du produit.

**Q : À quelle fréquence les données sont-elles mises à jour ?**

A: The data is updated every time you run the program. The program sends requests to the websites and scrapes the latest product information.

**Q : Puis-je utiliser ce programme pour d'autres types de produits ?**

R : Oui, vous pouvez utiliser ce programme pour d'autres types de produits en modifiant la requête de recherche et les sélecteurs CSS pour le nom, le prix et l'image du produit. Cependant, gardez à l'esprit que la version actuelle du programme est optimisée pour la recherche de produits informatiques dans plusieurs magasins au Panama.
