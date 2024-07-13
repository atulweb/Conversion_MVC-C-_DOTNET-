namespace ConversionMVC.Models
{
    public class Conversion
    {
    public double Value { get; set; }=0.00;
    public string? FromUnit { get; set; }
     public string? Type { get; set; }
    public string? ToUnit { get; set; }
     public double? new_amount { get; set; }=null;
   public double old_amount { get; set; }
   public string? old_currency { get; set; }
   public string? new_currency { get; set; }
    public static Dictionary<string,string> listOfCurrency = new Dictionary<string, string>()
         {
        {"UAE Dirham","AED"},
        {"Albanian Lek","ALL"},
        {"Netherlands Antillean Gulden","ANG"},
        {"Argentine Peso","ARS"},
        {"Aruban Florin","AWG"},
        {"Bosnia And Herzegovina Konvertibilna Marka","BAM"},
        {"Bangladeshi Taka","BDT"},
        {"Bahraini Dinar","BHD"},
        {"Bermudan Dollar","BMD"},
        {"Bolivian Boliviano","BOB"},
        {"Bahamian Dollar","BSD"},
        {"Bhutanese Ngultrum","BTN"},
        {"New Belarusian Ruble","BYN"},
        {"Belize Dollar","BZD"},
        {"Congolese Franc","CDF"},
        {"Chilean Unit Of Account","CLF"},
        {"Chinese Yuan","CNY"},
        {"Costa Rican Colon","CRC"},
        {"Cuban Peso","CUP"},
        {"Czech Koruna","CZK"},
        {"Danish Krone","DKK"},
        {"Algerian Dinar","DZD"},
        {"Eritrean Nakfa","ERN"},
        {"Euro","EUR"},
        {"Falkland Islands Pound","FKP"},
        {"Georgian Lari","GEL"},
        {"Ghanaian Cedi","GHS"},
        {"Gambian Dalasi","GMD"},
        {"Guatemalan Quetzal","GTQ"},
        {"Hong Kong Dollar","HKD"},
        {"Croatian Kuna","HRK"},
        {"Hungarian Forint","HUF"},
        {"Israeli New Sheqel","ILS"},
        {"Indian Rupee","INR"},
        {"Iranian Rial","IRR"},
        {"Jersey Pound","JEP"},
        {"Jordanian Dinar","JOD"},
        {"Kenyan Shilling","KES"},
        {"Cambodian Riel","KHR"},
        {"North Korean Won","KPW"},
        {"Kuwaiti Dinar","KWD"},
        {"Kazakhstani Tenge","KZT"},
        {"Lebanese Lira","LBP"},
        {"Liberian Dollar","LRD"},
        {"Latvian Lats","LVL"},
        {"Moroccan Dirham","MAD"},
        {"Malagasy Ariary","MGA"},
        {"Myanma Kyat","MMK"},
        {"Macanese Pataca","MOP"},
        {"Mauritian Rupee","MUR"},
        {"Malawian Kwacha","MWK"},
        {"Malaysian Ringgit","MYR"},
        {"Namibian Dollar","NAD"},
        {"Nicaraguan Cordoba","NIO"},
        {"Nepalese Rupee","NPR"},
        {"Omani Rial","OMR"},
        {"Peruvian Nuevo Sol","PEN"},
        {"Philippine Peso","PHP"},
        {"Polish Zloty","PLN"},
        {"Qatari Riyal","QAR"},
        {"Serbian Dinar","RSD"},
        {"Rwandan Franc","RWF"},
        {"Solomon Islands Dollar","SBD"},
        {"Sudanese Pound","SDG"},
        {"Singapore Dollar","SGD"},
        {"Sierra Leonean Leone","SLL"},
        {"Surinamese Dollar","SRD"},
        {"Salvadoran Col\xc3\xb3n","SVC"},
        {"Swazi Lilangeni","SZL"},
        {"Tajikistani Somoni","TJS"},
        {"Tunisian Dinar","TND"},
        {"Turkish New Lira","TRY"},
        {"New Taiwan Dollar","TWD"},
        {"Ukrainian Hryvnia","UAH"},
        {"United States Dollar","USD"},
        {"Uzbekistani Som","UZS"},
        {"Vietnamese Dong","VND"},
        {"Samoan Tala","WST"},
        {"Silver (troy ounce)","XAG"},
        {"Special Drawing Rights","XDR"},
        {"CFP Franc","XPF"},
        {"South African Rand","ZAR"},
        {"Zambian Kwacha","ZMW"},
        {"Afghan Afghani","AFN"},
        {"Armenian Dram","AMD"},
        {"Angolan Kwanza","AOA"},
        {"Australian Dollar","AUD"},
        {"Azerbaijani Manat","AZN"},
        {"Barbadian Dollar","BBD"},
        {"Bulgarian Lev","BGN"},
        {"Burundi Franc","BIF"},
        {"Brunei Dollar","BND"},
        {"Brazilian Real","BRL"},
        {"Bitcoin","BTC"},
        {"Botswana Pula","BWP"},
        {"Belarusian Ruble","BYR"},
        {"Canadian Dollar","CAD"},
        {"Swiss Franc","CHF"},
        {"Chilean Peso","CLP"},
        {"Colombian Peso","COP"},
        {"Cuban Convertible Peso","CUC"},
        {"Cape Verdean Escudo","CVE"},
        {"Djiboutian Franc","DJF"},
        {"Dominican Peso","DOP"},
        {"Egyptian Pound","EGP"},
        {"Ethiopian Birr","ETB"},
        {"Fijian Dollar","FJD"},
        {"British Pound","GBP"},
        {"Guernsey Pound","GGP"},
        {"Gibraltar Pound","GIP"},
        {"Guinean Franc","GNF"},
        {"Guyanese Dollar","GYD"},
        {"Honduran Lempira","HNL"},
        {"Haitian Gourde","HTG"},
        {"Indonesian Rupiah","IDR"},
        {"Manx pound","IMP"},
        {"Iraqi Dinar","IQD"},
        {"Icelandic Kr\xc3\xb3na","ISK"},
        {"Jamaican Dollar","JMD"},
        {"Japanese Yen","JPY"},
        {"Kyrgyzstani Som","KGS"},
        {"Comorian Franc","KMF"},
        {"South Korean Won","KRW"},
        {"Cayman Islands Dollar","KYD"},
        {"Lao Kip","LAK"},
        {"Sri Lankan Rupee","LKR"},
        {"Lesotho Loti","LSL"},
        {"Libyan Dinar","LYD"},
        {"Moldovan Leu","MDL"},
        {"Macedonian Denar","MKD"},
        {"Mongolian Tugrik","MNT"},
        {"Mauritanian Ouguiya","MRO"},
        {"Maldivian Rufiyaa","MVR"},
        {"Mexican Peso","MXN"},
        {"Mozambican Metical","MZN"},
        {"Nigerian Naira","NGN"},
        {"Norwegian Krone","NOK"},
        {"New Zealand Dollar","NZD"},
        {"Panamanian Balboa","PAB"},
        {"Papua New Guinean Kina","PGK"},
        {"Pakistani Rupee","PKR"},
        {"Paraguayan Guarani","PYG"},
        {"Romanian Leu","RON"},
        {"Russian Ruble","RUB"},
        {"Saudi Riyal","SAR"},
        {"Seychellois Rupee","SCR"},
        {"Swedish Krona","SEK"},
        {"Saint Helena Pound","SHP"},
        {"Somali Shilling","SOS"},
        {"Sao Tome And Principe Dobra","STD"},
        {"Syrian Pound","SYP"},
        {"Thai Baht","THB"},
        {"Turkmenistan Manat","TMT"},
        {"Paanga","TOP"},
        {"Trinidad and Tobago Dollar","TTD"},
        {"Tanzanian Shilling","TZS"},
        {"Ugandan Shilling","UGX"},
        {"Uruguayan Peso","UYU"},
        {"Venezuelan Bolivar","VEF"},
        {"Vanuatu Vatu","VUV"},
        {"Central African CFA Franc","XAF"},
        {"East Caribbean Dollar","XCD"},
        {"West African CFA Franc","XOF"},
        {"Yemeni Rial","YER"},
        {"Old Zambian Kwacha","ZMK"},
        {"Zimbabwean Dollar","ZWL"}
    };

   
}
}