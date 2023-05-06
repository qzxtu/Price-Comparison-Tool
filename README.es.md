# Herramienta de comparación de precios

Este programa es una herramienta de comparación de precios que permite a los usuarios buscar productos informáticos en múltiples tiendas en Panamá y encontrar el precio más barato.

## Captura de pantalla

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

## Autor

Este programa fue creado por[qzxtu](https://github.com/qzxtu).

## Descargo de responsabilidad

Esta herramienta fue creada solo con fines educativos. El autor no es responsable del mal uso de este programa.

## Cómo funciona

El usuario ingresa una consulta de búsqueda y el programa envía solicitudes a múltiples sitios web para extraer información del producto. Luego, el programa compara los precios de los productos y muestra el producto más barato junto con sus detalles.

## Características

-   Busca múltiples tiendas de computación en Panamá para información de productos
-   Encuentra el precio más barato para un producto dado
-   Muestra información detallada sobre el producto más barato
-   Utiliza el almacenamiento en caché para mejorar el rendimiento.
-   Utiliza subprocesos múltiples para acelerar el procesamiento

## Preguntas más frecuentes

**P: ¿En qué sitios web busca el programa?**

R: El programa actualmente busca en tres sitios web:`loltec.com`,`solostock.xyz`, y`ptytec.com`. Estos sitios web son tiendas de computación ubicadas en Panamá.

**P: ¿Puedo agregar más sitios web al programa?**

R: Sí, puede agregar más sitios web al programa modificando el`websites`lista en el`Main`método. Deberá proporcionar la URL del sitio web y los selectores de CSS para el nombre, el precio y la imagen del producto.

**P: ¿Con qué frecuencia se actualizan los datos?**

R: Los datos se actualizan cada vez que ejecuta el programa. El programa envía solicitudes a los sitios web y extrae la información más reciente del producto.

**P: ¿Puedo usar este programa para otros tipos de productos?**

R: Sí, puede usar este programa para otros tipos de productos modificando la consulta de búsqueda y los selectores de CSS para el nombre del producto, el precio y la imagen. Sin embargo, tenga en cuenta que la versión actual del programa está optimizada para buscar productos informáticos en múltiples tiendas en Panamá.
