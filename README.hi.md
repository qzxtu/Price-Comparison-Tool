# मूल्य तुलना उपकरण

यह कार्यक्रम एक मूल्य तुलना उपकरण है जो उपयोगकर्ताओं को पनामा में कई स्टोरों में कंप्यूटर उत्पादों की खोज करने और सबसे सस्ती कीमत खोजने की अनुमति देता है।

## 

| 🇺🇸                   | 🇨🇳                            | 🇹🇼                             | 🇮🇳                  | 🇫🇷                   | 🇦🇪                | 🇩🇪                  | 🇯🇵                   | 🇪🇸                    |
| ---------------------- | ------------------------------- | -------------------------------- | --------------------- | ---------------------- | ------------------- | --------------------- | ---------------------- | ----------------------- |
| [अंग्रेज़ी](README.md) | [सरलीकृत चीनी](README.zh-CN.md) | [परंपरागत चीनी](README.zh-TW.md) | [हिंदी](README.hi.md) | [फ्रेंच](README.fr.md) | [अरब](README.ar.md) | [जर्मन](README.de.md) | [जापानी](README.ja.md) | [स्पैनिश](README.es.md) |

## स्क्रीनशॉट

![PTY](https://cdn.discordapp.com/attachments/1008195045960204348/1104240493560348793/PTY.png)

## लेखक

यह कार्यक्रम द्वारा बनाया गया था[qzxtu](https://github.com/qzxtu).

## अस्वीकरण

यह उपकरण केवल शैक्षिक उद्देश्यों के लिए बनाया गया था। लेखक इस कार्यक्रम के किसी भी दुरुपयोग के लिए ज़िम्मेदार नहीं है।

## यह काम किस प्रकार करता है

उपयोगकर्ता एक खोज क्वेरी में प्रवेश करता है और प्रोग्राम उत्पाद जानकारी को परिमार्जन करने के लिए कई वेबसाइटों को अनुरोध भेजता है। कार्यक्रम तब उत्पादों की कीमतों की तुलना करता है और इसके विवरण के साथ सबसे सस्ता उत्पाद प्रदर्शित करता है।

## विशेषताएँ

-   उत्पाद जानकारी के लिए पनामा में कई कंप्यूटर स्टोरों की खोज करता है
-   किसी दिए गए उत्पाद के लिए सबसे सस्ती कीमत ढूँढता है
-   सबसे सस्ते उत्पाद के बारे में विस्तृत जानकारी प्रदर्शित करता है
-   प्रदर्शन को बेहतर बनाने के लिए कैशिंग का उपयोग करता है
-   प्रसंस्करण को गति देने के लिए मल्टीथ्रेडिंग का उपयोग करता है

## सामान्य प्रश्न

**प्रश्न: प्रोग्राम किन वेबसाइटों पर खोज करता है?**

ए: कार्यक्रम वर्तमान में तीन वेबसाइटों की खोज करता है:`loltec.com`,`solostock.xyz`, और`ptytec.com`. ये वेबसाइटें पनामा में स्थित कंप्यूटर स्टोर हैं।

**प्रश्न: क्या मैं कार्यक्रम में और वेबसाइटें जोड़ सकता हूँ?**

उ: हां, आप संशोधित करके कार्यक्रम में और वेबसाइटें जोड़ सकते हैं`websites`सूची में`Main`तरीका। आपको उत्पाद का नाम, मूल्य और छवि के लिए वेबसाइट का URL और CSS चयनकर्ता प्रदान करने की आवश्यकता होगी।

**प्रश्न: डेटा कितनी बार अपडेट किया जाता है?**

ए: हर बार जब आप प्रोग्राम चलाते हैं तो डेटा अपडेट किया जाता है। कार्यक्रम वेबसाइटों को अनुरोध भेजता है और नवीनतम उत्पाद जानकारी को स्क्रैप करता है।

**प्रश्न: क्या मैं इस कार्यक्रम का उपयोग अन्य प्रकार के उत्पादों के लिए कर सकता हूँ?**

उ: हां, आप उत्पाद के नाम, मूल्य और छवि के लिए खोज क्वेरी और CSS चयनकर्ताओं को संशोधित करके अन्य प्रकार के उत्पादों के लिए इस कार्यक्रम का उपयोग कर सकते हैं। हालांकि, ध्यान रखें कि कार्यक्रम का वर्तमान संस्करण पनामा में कई स्टोरों में कंप्यूटर उत्पादों को खोजने के लिए अनुकूलित है।
