type Currency =
  | "AED" // Dirham arabski
  | "AFN" // Afgani
  | "ALL" // Lek albański
  | "AMD" // Dram ormiański
  | "ANG" // Gulden Antyli Holenderskich
  | "AOA" // Kwanza angolańska
  | "ARS" // Peso argentyńskie
  | "AUD" // Dolar australijski
  | "AWG" // Florin arubański
  | "AZN" // Manat azerbejdżański
  | "BAM" // Marka zamienna
  | "BBD" // Dolar Barbadosu
  | "BDT" // Taka bangladeska
  | "BGN" // Lew bułgarski
  | "BHD" // Dinar bahrajski
  | "BIF" // Frank burundyjski
  | "BMD" // Dolar bermudzki
  | "BND" // Dolar Brunei
  | "BOB" // Boliviano
  | "BRL" // Real brazylijski
  | "BSD" // Dolar bahamski
  | "BTN" // Ngultrum
  | "BWP" // Pula botswańska
  | "BYN" // Rubel białoruski
  | "BZD" // Dolar belizeński
  | "CAD" // Dolar kanadyjski
  | "CDF" // Frank kongijski
  | "CHF" // Frank szwajcarski
  | "CLP" // Peso chilijskie
  | "CNY" // Juan chiński
  | "COP" // Peso kolumbijskie
  | "CRC" // Colon kostarykański
  | "CUP" // Peso kubańskie
  | "CVE" // Escudo Wysp Zielonego Przylądka
  | "CZK" // Korona czeska
  | "DJF" // Frank Dżibuti
  | "DKK" // Korona duńska
  | "DOP" // Peso dominikańskie
  | "DZD" // Dinar algierski
  | "EGP" // Funt egipski
  | "ERN" // Nakfa erytrejska
  | "ETB" // Birr etiopski
  | "EUR" // Euro
  | "FJD" // Dolar fidżyjski
  | "FKP" // Funt Falklandów
  | "FOK" // Korona farerska
  | "GBP" // Funt brytyjski
  | "GEL" // Lari gruziński
  | "GGP" // Funt Guernsey
  | "GHS" // Cedi ghański
  | "GIP" // Funt gibraltarski
  | "GMD" // Dalasi gambijski
  | "GNF" // Frank gwinejski
  | "GTQ" // Quetzal gwatemalski
  | "GYD" // Dolar gujański
  | "HKD" // Dolar hongkoński
  | "HNL" // Lempira honduraska
  | "HRK" // Kuna chorwacka
  | "HTG" // Gourde haitańskie
  | "HUF" // Forint węgierski
  | "IDR" // Rupia indonezyjska
  | "ILS" // Nowy szekel izraelski
  | "IMP" // Funt Man
  | "INR" // Rupia indyjska
  | "IQD" // Dinar iracki
  | "IRR" // Rial irański
  | "ISK" // Korona islandzka
  | "JEP" // Funt Jersey
  | "JMD" // Dolar jamajski
  | "JOD" // Dinar jordański
  | "JPY" // Jen japoński
  | "KES" // Szyling kenijski
  | "KGS" // Som kirgiski
  | "KHR" // Riel kambodżański
  | "KID" // Dolar Kiribati
  | "KMF" // Frank Komorów
  | "KRW" // Won południowokoreański
  | "KWD" // Dinar kuwejcki
  | "KYD" // Dolar Kajmanów
  | "KZT" // Tenge kazachstański
  | "LAK" // Kip laotański
  | "LBP" // Funt libański
  | "LKR" // Rupia lankijska
  | "LRD" // Dolar liberyjski
  | "LSL" // Loti
  | "LYD" // Dinar libijski
  | "MAD" // Dirham marokański
  | "MDL" // Lej mołdawski
  | "MGA" // Ariary malgaski
  | "MKD" // Denar macedoński
  | "MMK" // Kyat birmański
  | "MNT" // Tugrik mongolski
  | "MOP" // Pataca Makau
  | "MRU" // Ouguiya
  | "MUR" // Rupia maurytyjska
  | "MVR" // Rupia malediwska
  | "MWK" // Kwacha malawska
  | "MXN" // Peso meksykańskie
  | "MYR" // Ringgit malezyjski
  | "MZN" // Metical mozambicki
  | "NAD" // Dolar namibijski
  | "NGN" // Naira nigeryjska
  | "NIO" // Cordoba oro
  | "NOK" // Korona norweska
  | "NPR" // Rupia nepalska
  | "NZD" // Dolar nowozelandzki
  | "OMR" // Rial omański
  | "PAB" // Balboa panamska
  | "PEN" // Sol peruwiański
  | "PGK" // Kina papuaska
  | "PHP" // Peso filipińskie
  | "PKR" // Rupia pakistańska
  | "PLN" // Złoty polski
  | "PYG" // Guarani paragwajskie
  | "QAR" // Rial katarski
  | "RON" // Lej rumuński
  | "RSD" // Dinar serbski
  | "RUB" // Rubel rosyjski
  | "RWF" // Frank rwandyjski
  | "SAR" // Rial saudyjski
  | "SBD" // Dolar Wysp Salomona
  | "SCR" // Rupia seszelska
  | "SDG" // Funt sudański
  | "SEK" // Korona szwedzka
  | "SGD" // Dolar singapurski
  | "SHP" // Funt Wyspy Świętej Heleny
  | "SLL" // Leone
  | "SOS" // Szyling somalijski
  | "SRD" // Dolar surinamski
  | "SSP" // Funt południowosudański
  | "STN" // Dobra
  | "SYP" // Funt syryjski
  | "SZL" // Lilangeni
  | "THB" // Baht tajski
  | "TJS" // Somoni tadżycki
  | "TMT" // Manat turkmeński
  | "TND" // Dinar tunezyjski
  | "TOP" // Pa’anga
  | "TRY" // Lira turecka
  | "TTD" // Dolar Trynidadu i Tobago
  | "TVD" // Dolar Tuvalu
  | "TWD" // Nowy dolar tajwański
  | "TZS" // Szyling tanzański
  | "UAH" // Hrywna ukraińska
  | "UGX" // Szyling ugandyjski
  | "USD" // Dolar amerykański
  | "UYU" // Peso urugwajskie
  | "UZS" // Sum uzbecki
  | "VES" // Bolívar wenezuelski
  | "VND" // Dong wietnamski
  | "VUV" // Vatu vanuackie
  | "WST" // Tala
  | "XAF" // Frank CFA BEAC
  | "XCD" // Dolar wschodniokaraibski
  | "XOF" // Frank CFA BCEAO
  | "XPF" // Frank CFP
  | "YER" // Rial jemeński
  | "ZAR" // Rand południowoafrykański
  | "ZMW"; // Kwacha zambijska
