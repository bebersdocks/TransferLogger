﻿using TransferLogger.Dal.Utils;

namespace TransferLogger.Dal.Definitions
{
    public enum Country
    {
        [StringValue("Afghanistan")]                                  AF = 1,
        [StringValue("Åland Islands")]                                AX = 2,
        [StringValue("Albania")]                                      AL = 3,
        [StringValue("Algeria")]                                      DZ = 4,
        [StringValue("American Samoa")]                               AS = 5,
        [StringValue("Andorra")]                                      AD = 6,
        [StringValue("Angola")]                                       AO = 7,
        [StringValue("Anguilla")]                                     AI = 8,
        [StringValue("Antarctica")]                                   AQ = 9,
        [StringValue("Antigua and Barbuda")]                          AG = 10,
        [StringValue("Argentina")]                                    AR = 11,
        [StringValue("Armenia")]                                      AM = 12,
        [StringValue("Aruba")]                                        AW = 13,
        [StringValue("Australia")]                                    AU = 14,
        [StringValue("Austria")]                                      AT = 15,
        [StringValue("Azerbaijan")]                                   AZ = 16,
        [StringValue("Bahamas")]                                      BS = 17,
        [StringValue("Bahrain")]                                      BH = 18,
        [StringValue("Bangladesh")]                                   BD = 19,
        [StringValue("Barbados")]                                     BB = 20,
        [StringValue("Belarus")]                                      BY = 21,
        [StringValue("Belgium")]                                      BE = 22,
        [StringValue("Belize")]                                       BZ = 23,
        [StringValue("Benin")]                                        BJ = 24,
        [StringValue("Bermuda")]                                      BM = 25,
        [StringValue("Bhutan")]                                       BT = 26,
        [StringValue("Bolivia")]                                      BO = 27,
        [StringValue("Bonaire, Sint Eustatius and Saba")]             BQ = 28,
        [StringValue("Bosnia and Herzegovina")]                       BA = 29,
        [StringValue("Botswana")]                                     BW = 30,
        [StringValue("Bouvet Island")]                                BV = 31,
        [StringValue("Brazil")]                                       BR = 32,
        [StringValue("British Indian Ocean Territory")]               IO = 33,
        [StringValue("Brunei Darussalam")]                            BN = 34,
        [StringValue("Bulgaria")]                                     BG = 35,
        [StringValue("Burkina Faso")]                                 BF = 36,
        [StringValue("Burundi")]                                      BI = 37,
        [StringValue("Cabo Verde")]                                   CV = 38,
        [StringValue("Cambodia")]                                     KH = 39,
        [StringValue("Cameroon")]                                     CM = 40,
        [StringValue("Canada")]                                       CA = 41,
        [StringValue("Cayman Islands")]                               KY = 42,
        [StringValue("Central African Republic")]                     CF = 43,
        [StringValue("Chad")]                                         TD = 44,
        [StringValue("Chile")]                                        CL = 45,
        [StringValue("China")]                                        CN = 46,
        [StringValue("Christmas Island")]                             CX = 47,
        [StringValue("Cocos (Keeling) Islands")]                      CC = 48,
        [StringValue("Colombia")]                                     CO = 49,
        [StringValue("Comoros")]                                      KM = 50,
        [StringValue("Congo")]                                        CG = 51,
        [StringValue("Congo")]                                        CD = 52,
        [StringValue("Cook Islands")]                                 CK = 53,
        [StringValue("Costa Rica")]                                   CR = 54,
        [StringValue("Côte d'Ivoire")]                                CI = 55,
        [StringValue("Croatia")]                                      HR = 56,
        [StringValue("Cuba")]                                         CU = 57,
        [StringValue("Curaçao")]                                      CW = 58,
        [StringValue("Cyprus")]                                       CY = 59,
        [StringValue("Czechia")]                                      CZ = 60,
        [StringValue("Denmark")]                                      DK = 61,
        [StringValue("Djibouti")]                                     DJ = 62,
        [StringValue("Dominica")]                                     DM = 63,
        [StringValue("Dominican Republic")]                           DO = 64,
        [StringValue("Ecuador")]                                      EC = 65,
        [StringValue("Egypt")]                                        EG = 66,
        [StringValue("El Salvador")]                                  SV = 67,
        [StringValue("Equatorial Guinea")]                            GQ = 68,
        [StringValue("Eritrea")]                                      ER = 69,
        [StringValue("Estonia")]                                      EE = 70,
        [StringValue("Ethiopia")]                                     ET = 71,
        [StringValue("Falkland Islands (Malvinas)")]                  FK = 72,
        [StringValue("Faroe Islands")]                                FO = 73,
        [StringValue("Fiji")]                                         FJ = 74,
        [StringValue("Finland")]                                      FI = 75,
        [StringValue("France")]                                       FR = 76,
        [StringValue("French Guiana")]                                GF = 77,
        [StringValue("French Polynesia")]                             PF = 78,
        [StringValue("French Southern Territories")]                  TF = 79,
        [StringValue("Gabon")]                                        GA = 80,
        [StringValue("Gambia")]                                       GM = 81,
        [StringValue("Georgia")]                                      GE = 82,
        [StringValue("Germany")]                                      DE = 83,
        [StringValue("Ghana")]                                        GH = 84,
        [StringValue("Gibraltar")]                                    GI = 85,
        [StringValue("Greece")]                                       GR = 86,
        [StringValue("Greenland")]                                    GL = 87,
        [StringValue("Grenada")]                                      GD = 88,
        [StringValue("Guadeloupe")]                                   GP = 89,
        [StringValue("Guam")]                                         GU = 90,
        [StringValue("Guatemala")]                                    GT = 91,
        [StringValue("Guernsey")]                                     GG = 92,
        [StringValue("Guinea")]                                       GN = 93,
        [StringValue("Guinea-Bissau")]                                GW = 94,
        [StringValue("Guyana")]                                       GY = 95,
        [StringValue("Haiti")]                                        HT = 96,
        [StringValue("Heard Island and McDonald Islands")]            HM = 97,
        [StringValue("Holy See")]                                     VA = 98,
        [StringValue("Honduras")]                                     HN = 99,
        [StringValue("Hong Kong")]                                    HK = 100,
        [StringValue("Hungary")]                                      HU = 101,
        [StringValue("Iceland")]                                      IS = 102,
        [StringValue("India")]                                        IN = 103,
        [StringValue("Indonesia")]                                    ID = 104,
        [StringValue("Iran")]                                         IR = 105,
        [StringValue("Iraq")]                                         IQ = 106,
        [StringValue("Ireland")]                                      IE = 107,
        [StringValue("Isle of Man")]                                  IM = 108,
        [StringValue("Israel")]                                       IL = 109,
        [StringValue("Italy")]                                        IT = 110,
        [StringValue("Jamaica")]                                      JM = 111,
        [StringValue("Japan")]                                        JP = 112,
        [StringValue("Jersey")]                                       JE = 113,
        [StringValue("Jordan")]                                       JO = 114,
        [StringValue("Kazakhstan")]                                   KZ = 115,
        [StringValue("Kenya")]                                        KE = 116,
        [StringValue("Kiribati")]                                     KI = 117,
        [StringValue("North Korea")]                                  KP = 118,
        [StringValue("South Korea")]                                  KR = 119,
        [StringValue("Kuwait")]                                       KW = 120,
        [StringValue("Kyrgyzstan")]                                   KG = 121,
        [StringValue("Lao People's Democratic Republic")]             LA = 122,
        [StringValue("Latvia")]                                       LV = 123,
        [StringValue("Lebanon")]                                      LB = 124,
        [StringValue("Lesotho")]                                      LS = 125,
        [StringValue("Liberia")]                                      LR = 126,
        [StringValue("Libya")]                                        LY = 127,
        [StringValue("Liechtenstein")]                                LI = 128,
        [StringValue("Lithuania")]                                    LT = 129,
        [StringValue("Luxembourg")]                                   LU = 130,
        [StringValue("Macao")]                                        MO = 131,
        [StringValue("Macedonia")]                                    MK = 132,
        [StringValue("Madagascar")]                                   MG = 133,
        [StringValue("Malawi")]                                       MW = 134,
        [StringValue("Malaysia")]                                     MY = 135,
        [StringValue("Maldives")]                                     MV = 136,
        [StringValue("Mali")]                                         ML = 137,
        [StringValue("Malta")]                                        MT = 138,
        [StringValue("Marshall Islands")]                             MH = 139,
        [StringValue("Martinique")]                                   MQ = 140,
        [StringValue("Mauritania")]                                   MR = 141,
        [StringValue("Mauritius")]                                    MU = 142,
        [StringValue("Mayotte")]                                      YT = 143,
        [StringValue("Mexico")]                                       MX = 144,
        [StringValue("Micronesia (Federated States of)")]             FM = 145,
        [StringValue("Moldova (Republic of)")]                        MD = 146,
        [StringValue("Monaco")]                                       MC = 147,
        [StringValue("Mongolia")]                                     MN = 148,
        [StringValue("Montenegro")]                                   ME = 149,
        [StringValue("Montserrat")]                                   MS = 150,
        [StringValue("Morocco")]                                      MA = 151,
        [StringValue("Mozambique")]                                   MZ = 152,
        [StringValue("Myanmar")]                                      MM = 153,
        [StringValue("Namibia")]                                      NA = 154,
        [StringValue("Nauru")]                                        NR = 155,
        [StringValue("Nepal")]                                        NP = 156,
        [StringValue("Netherlands")]                                  NL = 157,
        [StringValue("New Caledonia")]                                NC = 158,
        [StringValue("New Zealand")]                                  NZ = 159,
        [StringValue("Nicaragua")]                                    NI = 160,
        [StringValue("Niger")]                                        NE = 161,
        [StringValue("Nigeria")]                                      NG = 162,
        [StringValue("Niue")]                                         NU = 163,
        [StringValue("Norfolk Island")]                               NF = 164,
        [StringValue("Northern Mariana Islands")]                     MP = 165,
        [StringValue("Norway")]                                       NO = 166,
        [StringValue("Oman")]                                         OM = 167,
        [StringValue("Pakistan")]                                     PK = 168,
        [StringValue("Palau")]                                        PW = 169,
        [StringValue("Palestine, State of")]                          PS = 170,
        [StringValue("Panama")]                                       PA = 171,
        [StringValue("Papua New Guinea")]                             PG = 172,
        [StringValue("Paraguay")]                                     PY = 173,
        [StringValue("Peru")]                                         PE = 174,
        [StringValue("Philippines")]                                  PH = 175,
        [StringValue("Pitcairn")]                                     PN = 176,
        [StringValue("Poland")]                                       PL = 177,
        [StringValue("Portugal")]                                     PT = 178,
        [StringValue("Puerto Rico")]                                  PR = 179,
        [StringValue("Qatar")]                                        QA = 180,
        [StringValue("Réunion")]                                      RE = 181,
        [StringValue("Romania")]                                      RO = 182,
        [StringValue("Russian Federation")]                           RU = 183,
        [StringValue("Rwanda")]                                       RW = 184,
        [StringValue("Saint Barthélemy")]                             BL = 185,
        [StringValue("Saint Helena, Ascension and Tristan da Cunha")] SH = 186,
        [StringValue("Saint Kitts and Nevis")]                        KN = 187,
        [StringValue("Saint Lucia")]                                  LC = 188,
        [StringValue("Saint Martin (French part)")]                   MF = 189,
        [StringValue("Saint Pierre and Miquelon")]                    PM = 190,
        [StringValue("Saint Vincent and the Grenadines")]             VC = 191,
        [StringValue("Samoa")]                                        WS = 192,
        [StringValue("San Marino")]                                   SM = 193,
        [StringValue("Sao Tome and Principe")]                        ST = 194,
        [StringValue("Saudi Arabia")]                                 SA = 195,
        [StringValue("Senegal")]                                      SN = 196,
        [StringValue("Serbia")]                                       RS = 197,
        [StringValue("Seychelles")]                                   SC = 198,
        [StringValue("Sierra Leone")]                                 SL = 199,
        [StringValue("Singapore")]                                    SG = 200,
        [StringValue("Sint Maarten (Dutch part)")]                    SX = 201,
        [StringValue("Slovakia")]                                     SK = 202,
        [StringValue("Slovenia")]                                     SI = 203,
        [StringValue("Solomon Islands")]                              SB = 204,
        [StringValue("Somalia")]                                      SO = 205,
        [StringValue("South Africa")]                                 ZA = 206,
        [StringValue("South Georgia and the South Sandwich Islands")] GS = 207,
        [StringValue("South Sudan")]                                  SS = 208,
        [StringValue("Spain")]                                        ES = 209,
        [StringValue("Sri Lanka")]                                    LK = 210,
        [StringValue("Sudan")]                                        SD = 211,
        [StringValue("Suriname")]                                     SR = 212,
        [StringValue("Svalbard and Jan Mayen")]                       SJ = 213,
        [StringValue("Swaziland")]                                    SZ = 214,
        [StringValue("Sweden")]                                       SE = 215,
        [StringValue("Switzerland")]                                  CH = 216,
        [StringValue("Syrian Arab Republic")]                         SY = 217,
        [StringValue("Taiwan, Province of China[a]")]                 TW = 218,
        [StringValue("Tajikistan")]                                   TJ = 219,
        [StringValue("Tanzania, United Republic of")]                 TZ = 220,
        [StringValue("Thailand")]                                     TH = 221,
        [StringValue("Timor-Leste")]                                  TL = 222,
        [StringValue("Togo")]                                         TG = 223,
        [StringValue("Tokelau")]                                      TK = 224,
        [StringValue("Tonga")]                                        TO = 225,
        [StringValue("Trinidad and Tobago")]                          TT = 226,
        [StringValue("Tunisia")]                                      TN = 227,
        [StringValue("Turkey")]                                       TR = 228,
        [StringValue("Turkmenistan")]                                 TM = 229,
        [StringValue("Turks and Caicos Islands")]                     TC = 230,
        [StringValue("Tuvalu")]                                       TV = 231,
        [StringValue("Uganda")]                                       UG = 232,
        [StringValue("Ukraine")]                                      UA = 233,
        [StringValue("United Arab Emirates")]                         AE = 234,
        [StringValue("United Kingdom")]                               GB = 235,
        [StringValue("United States of America")]                     US = 236,
        [StringValue("United States Minor Outlying Islands")]         UM = 237,
        [StringValue("Uruguay")]                                      UY = 238,
        [StringValue("Uzbekistan")]                                   UZ = 239,
        [StringValue("Vanuatu")]                                      VU = 240,
        [StringValue("Venezuela")]                                    VE = 241,
        [StringValue("Viet Nam")]                                     VN = 242,
        [StringValue("Virgin Islands (British)")]                     VG = 243,
        [StringValue("Virgin Islands (U.S.)")]                        VI = 244,
        [StringValue("Wallis and Futuna")]                            WF = 245,
        [StringValue("Western Sahara")]                               EH = 246,
        [StringValue("Yemen")]                                        YE = 247,
        [StringValue("Zambia")]                                       ZM = 248,
        [StringValue("Zimbabwe")]                                     ZW = 249,
    }
}
