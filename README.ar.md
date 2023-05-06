# أداة مقارنة الأسعار

هذا البرنامج هو أداة مقارنة أسعار تتيح للمستخدمين البحث عن منتجات الكمبيوتر عبر متاجر متعددة في بنما والعثور على أرخص الأسعار.

## ترجمة

<div align="left">
  <details open>
    <summary>:globe_with_meridians: Languages Available</summary>
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

## لقطة شاشة

![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)

## مؤلف

تم إنشاء هذا البرنامج من قبل[qzxtu](https://github.com/qzxtu).

## تنصل

تم إنشاء هذه الأداة للأغراض التعليمية فقط. المؤلف غير مسؤول عن أي سوء استخدام لهذا البرنامج.

## How it works

يقوم المستخدم بإدخال استعلام بحث ويرسل البرنامج طلبات إلى مواقع ويب متعددة لكشط معلومات المنتج. يقوم البرنامج بعد ذلك بمقارنة أسعار المنتجات وعرض أرخص منتج مع تفاصيله.

## سمات

-   يبحث في متاجر أجهزة كمبيوتر متعددة في بنما للحصول على معلومات حول المنتج
-   يجد أرخص سعر لمنتج معين
-   يعرض معلومات مفصلة عن أرخص منتج
-   يستخدم التخزين المؤقت لتحسين الأداء
-   يستخدم multithreading لتسريع المعالجة

## التعليمات

**س: ما المواقع التي يبحث عنها البرنامج؟**

ج: يقوم البرنامج حاليا بالبحث في ثلاثة مواقع:`loltec.com`,`solostock.xyz`، و`ptytec.com`. هذه المواقع هي متاجر كمبيوتر تقع في بنما.

**س: هل يمكنني إضافة المزيد من المواقع إلى البرنامج؟**

ج: نعم ، يمكنك إضافة المزيد من المواقع إلى البرنامج عن طريق تعديل`websites`قائمة في`Main` method. You will need to provide the URL of the website and the CSS selectors for the product name, price, and image.

**س: كم مرة يتم تحديث البيانات؟**

ج: يتم تحديث البيانات في كل مرة تقوم فيها بتشغيل البرنامج. يرسل البرنامج الطلبات إلى المواقع ويكشط أحدث معلومات المنتج.

**س: هل يمكنني استخدام هذا البرنامج لأنواع أخرى من المنتجات؟**

ج: نعم ، يمكنك استخدام هذا البرنامج لأنواع أخرى من المنتجات عن طريق تعديل استعلام البحث ومحددات CSS لاسم المنتج والسعر والصورة. ومع ذلك ، ضع في اعتبارك أن الإصدار الحالي من البرنامج تم تحسينه للبحث عن منتجات الكمبيوتر عبر متاجر متعددة في بنما.
