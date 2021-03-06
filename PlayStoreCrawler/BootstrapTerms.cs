﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStoreCrawler
{
    public class BootstrapTerms
    {
        public static List<KeyValuePair<String, String>> categoriesAndNames;
        public static List<String>                       charactersSearchTerms;
        public static List<String>                       categoriesSearchTerms;
        public static List<String>                       miscSearchTerms;
        public static List<String>                       countryNames;

        // Static Constructor
        static BootstrapTerms ()
        {
            categoriesAndNames = new List<KeyValuePair<String, String>> ();

            // Initializing Categories and Names
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/collection/topselling_free"                  , "Top Selling Free"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/collection/topselling_paid"                  , "Top Selling Paid"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/collection/topgrossing"                      , "Top Grossing"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/collection/topselling_new_free"              , "Top New Free"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/collection/topselling_new_paid"              , "Top New Paid"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/category/GAME/collection/topselling_new_free", "Top New Free Games"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/category/GAME/collection/topselling_new_paid", "Top New Paid Games"));
            categoriesAndNames.Add (new KeyValuePair<String, String> ("https://play.google.com/store/apps/category/GAME/collection/topgrossing"        , "Top Grossing Games"));

            // Characters from 'A' to 'Z'
            charactersSearchTerms = new List<String> ();
            charactersSearchTerms.AddRange (Enumerable.Range ('A', 'Z' - 'A' + 1).Select (t => "" + (char) t));

            // App Categories
            categoriesSearchTerms = new List<String> ();
            categoriesSearchTerms.Add ("BOOKS");
            categoriesSearchTerms.Add ("BUSINESS");
            categoriesSearchTerms.Add ("COMICS");
            categoriesSearchTerms.Add ("COMMUNICATION");
            categoriesSearchTerms.Add ("EDUCATION");
            categoriesSearchTerms.Add ("ENTERTAINMENT");
            categoriesSearchTerms.Add ("FINANCE");
            categoriesSearchTerms.Add ("HEALTH");
            categoriesSearchTerms.Add ("LIFESTYLE");
            categoriesSearchTerms.Add ("LIVE WALLPAPER");
            categoriesSearchTerms.Add ("MEDIA");
            categoriesSearchTerms.Add ("MEDICAL");
            categoriesSearchTerms.Add ("MUSIC");
            categoriesSearchTerms.Add ("NEWS");
            categoriesSearchTerms.Add ("PERSONALIZATION");
            categoriesSearchTerms.Add ("PHOTOGRAPHY");
            categoriesSearchTerms.Add ("PRODUCTIVITY");
            categoriesSearchTerms.Add ("SHOPPING");
            categoriesSearchTerms.Add ("SOCIAL");
            categoriesSearchTerms.Add ("SPORTS");
            categoriesSearchTerms.Add ("TOOLS");
            categoriesSearchTerms.Add ("TRANSPORTATION");
            categoriesSearchTerms.Add ("TRAVEL");
            categoriesSearchTerms.Add ("WEATHER");
            categoriesSearchTerms.Add ("WIDGETS");
            categoriesSearchTerms.Add ("ARCADE");
            categoriesSearchTerms.Add ("BRAIN");
            categoriesSearchTerms.Add ("CASUAL");
            categoriesSearchTerms.Add ("CARDS");
            categoriesSearchTerms.Add ("RACING");

            // Miscelaneous search terms
            miscSearchTerms = new List<String> ();
            miscSearchTerms.Add ("INDIE");
            miscSearchTerms.Add ("ZOMBIE");
            miscSearchTerms.Add ("CATS");
            miscSearchTerms.Add ("ROOT");
            miscSearchTerms.Add ("GPS");
            miscSearchTerms.Add ("BLUETOOTH");
            miscSearchTerms.Add ("COMPASS");
            miscSearchTerms.Add ("TRIVIA");
            miscSearchTerms.Add ("WALLPAPER");
            miscSearchTerms.Add ("TORRENT");
            miscSearchTerms.Add ("PORN");
            miscSearchTerms.Add ("PLAYER");
            miscSearchTerms.Add ("WINE");
            miscSearchTerms.Add ("ANTIVIRUS");
            miscSearchTerms.Add ("ECOMMERCE");
            miscSearchTerms.Add ("ADULT");
            miscSearchTerms.Add ("DOGS");
            miscSearchTerms.Add ("FOOD");
            miscSearchTerms.Add ("RECIPE");
            miscSearchTerms.Add ("WALLET");
            miscSearchTerms.Add ("VIRTUAL");
            miscSearchTerms.Add ("ZYNGA");
            miscSearchTerms.Add ("SAMSUNG");
            miscSearchTerms.Add ("TOSHIBA");
            miscSearchTerms.Add ("DELL");
            miscSearchTerms.Add ("APPLE");
            miscSearchTerms.Add ("IPHONE");
            miscSearchTerms.Add ("THEME");
            miscSearchTerms.Add ("KEYBOARD");
            miscSearchTerms.Add ("BACKUP");
            miscSearchTerms.Add ("CLOUD");
            miscSearchTerms.Add ("BROWSER");
            miscSearchTerms.Add ("MAIL");
            miscSearchTerms.Add ("TAXI");
            miscSearchTerms.Add ("CAMERA");
            miscSearchTerms.Add ("RSS");
            miscSearchTerms.Add ("GALLERY");
            miscSearchTerms.Add ("BANK");
            miscSearchTerms.Add ("MATH");
            miscSearchTerms.Add ("LANGUAGES");
            miscSearchTerms.Add ("PLAYER");
            miscSearchTerms.Add ("NOTE");
            miscSearchTerms.Add ("AGENDA");
            miscSearchTerms.Add ("TEATHER");
            miscSearchTerms.Add ("SMS");
            miscSearchTerms.Add ("MATH");
            miscSearchTerms.Add ("COURSE");
            miscSearchTerms.Add ("PROGRAMMING");
            miscSearchTerms.Add ("AOL");
            miscSearchTerms.Add ("BLACKJACK");
            miscSearchTerms.Add ("PRANK");
            miscSearchTerms.Add ("BIBLE");
            miscSearchTerms.Add ("CUBE");
            miscSearchTerms.Add ("DIGITAL");
            miscSearchTerms.Add ("CHOCOLATES");
            miscSearchTerms.Add ("DRINKING");
            miscSearchTerms.Add ("CHART");
            miscSearchTerms.Add ("ICON");
            miscSearchTerms.Add ("HANGMAN");
            miscSearchTerms.Add ("VIRTUAL");
            miscSearchTerms.Add ("VAMPIRE");
            miscSearchTerms.Add ("ASSISTANT");
            miscSearchTerms.Add ("TIP");
            miscSearchTerms.Add ("HOROSCOPE");
            miscSearchTerms.Add ("QUOTES");
            miscSearchTerms.Add ("BACKGROUNDS");
            miscSearchTerms.Add ("RECIPE");
            miscSearchTerms.Add ("NAVIGATION");

            // Country Names as Search terms to increase even more the crawler's reach
            countryNames = new List<String> ();
            countryNames.Add ("Afghanistan");
            countryNames.Add ("Albania");
            countryNames.Add ("Algeria");
            countryNames.Add ("American");
            countryNames.Add ("Andorra");
            countryNames.Add ("Angola");
            countryNames.Add ("Anguilla");
            countryNames.Add ("Antigua");
            countryNames.Add ("Argentina");
            countryNames.Add ("Armenia");
            countryNames.Add ("Aruba");
            countryNames.Add ("Australia");
            countryNames.Add ("Austria");
            countryNames.Add ("Azerbaijan");
            countryNames.Add ("Bahamas");
            countryNames.Add ("Bahrain");
            countryNames.Add ("Bangladesh");
            countryNames.Add ("Barbados");
            countryNames.Add ("Belarus");
            countryNames.Add ("Belgium");
            countryNames.Add ("Belize");
            countryNames.Add ("Benin");
            countryNames.Add ("Bermuda");
            countryNames.Add ("Bhutan");
            countryNames.Add ("Bolivia");
            countryNames.Add ("Bosnia");
            countryNames.Add ("Botswana");
            countryNames.Add ("Bouvet");
            countryNames.Add ("Brazil");
            countryNames.Add ("Brunei");
            countryNames.Add ("Bulgaria");
            countryNames.Add ("Burkina");
            countryNames.Add ("Burundi");
            countryNames.Add ("Cambodia");
            countryNames.Add ("Cameroon");
            countryNames.Add ("Canada");
            countryNames.Add ("Cape");
            countryNames.Add ("Cayman");
            countryNames.Add ("Central");
            countryNames.Add ("Chad");
            countryNames.Add ("Chile");
            countryNames.Add ("China");
            countryNames.Add ("Christmas");
            countryNames.Add ("Cocos");
            countryNames.Add ("Colombia");
            countryNames.Add ("Comoros");
            countryNames.Add ("Congo");
            countryNames.Add ("Congo");
            countryNames.Add ("Cook");
            countryNames.Add ("Costa");
            countryNames.Add ("Croatia");
            countryNames.Add ("Cuba");
            countryNames.Add ("Cyprus");
            countryNames.Add ("Czech");
            countryNames.Add ("Denmark");
            countryNames.Add ("Djibouti");
            countryNames.Add ("Dominica");
            countryNames.Add ("Dominican");
            countryNames.Add ("Ecuador");
            countryNames.Add ("Egypt");
            countryNames.Add ("El");
            countryNames.Add ("Equatorial");
            countryNames.Add ("Eritrea");
            countryNames.Add ("Estonia");
            countryNames.Add ("Ethiopia");
            countryNames.Add ("Falkland");
            countryNames.Add ("Faroe");
            countryNames.Add ("Fiji");
            countryNames.Add ("Finland");
            countryNames.Add ("France");
            countryNames.Add ("French");
            countryNames.Add ("Gabon");
            countryNames.Add ("Gambia");
            countryNames.Add ("Georgia");
            countryNames.Add ("Germany");
            countryNames.Add ("Ghana");
            countryNames.Add ("Gibraltar");
            countryNames.Add ("Greece");
            countryNames.Add ("Greenland");
            countryNames.Add ("Grenada");
            countryNames.Add ("Guadeloupe");
            countryNames.Add ("Guam");
            countryNames.Add ("Guatemala");
            countryNames.Add ("Guinea");
            countryNames.Add ("Guinea");
            countryNames.Add ("Guyana");
            countryNames.Add ("Haiti");
            countryNames.Add ("Holy");
            countryNames.Add ("Honduras");
            countryNames.Add ("Hong");
            countryNames.Add ("Hungary");
            countryNames.Add ("Iceland");
            countryNames.Add ("India");
            countryNames.Add ("Indonesia");
            countryNames.Add ("Iran");
            countryNames.Add ("Iraq");
            countryNames.Add ("Ireland");
            countryNames.Add ("Israel");
            countryNames.Add ("Italy");
            countryNames.Add ("Ivory");
            countryNames.Add ("Jamaica");
            countryNames.Add ("Japan");
            countryNames.Add ("Jordan");
            countryNames.Add ("Kazakhstan");
            countryNames.Add ("Kenya");
            countryNames.Add ("Kiribati");
            countryNames.Add ("Kuwait");
            countryNames.Add ("Kyrgyzstan");
            countryNames.Add ("Laos");
            countryNames.Add ("Latvia");
            countryNames.Add ("Lebanon");
            countryNames.Add ("Lesotho");
            countryNames.Add ("Liberia");
            countryNames.Add ("Libya");
            countryNames.Add ("Liechtenstein");
            countryNames.Add ("Lithuania");
            countryNames.Add ("Luxembourg");
            countryNames.Add ("Macau");
            countryNames.Add ("Macedonia");
            countryNames.Add ("Madagascar");
            countryNames.Add ("Malawi");
            countryNames.Add ("Malaysia");
            countryNames.Add ("Maldives");
            countryNames.Add ("Mali");
            countryNames.Add ("Malta");
            countryNames.Add ("Marshall");
            countryNames.Add ("Martinique");
            countryNames.Add ("Mauritania");
            countryNames.Add ("Mauritius");
            countryNames.Add ("Mayotte");
            countryNames.Add ("Mexico");
            countryNames.Add ("Micronesia");
            countryNames.Add ("Moldova");
            countryNames.Add ("Monaco");
            countryNames.Add ("Mongolia");
            countryNames.Add ("Montenegro");
            countryNames.Add ("Montserrat");
            countryNames.Add ("Morocco");
            countryNames.Add ("Mozambique");
            countryNames.Add ("Myanmar");
            countryNames.Add ("Namibia");
            countryNames.Add ("Nauru");
            countryNames.Add ("Nepal");
            countryNames.Add ("Netherlands");
            countryNames.Add ("Netherlands");
            countryNames.Add ("New");
            countryNames.Add ("New");
            countryNames.Add ("Nicaragua");
            countryNames.Add ("Niger");
            countryNames.Add ("Nigeria");
            countryNames.Add ("Niue");
            countryNames.Add ("Norfolk");
            countryNames.Add ("North");
            countryNames.Add ("Northern");
            countryNames.Add ("Norway");
            countryNames.Add ("Oman");
            countryNames.Add ("Pakistan");
            countryNames.Add ("Palau");
            countryNames.Add ("Panama");
            countryNames.Add ("Papua");
            countryNames.Add ("Paraguay");
            countryNames.Add ("Peru");
            countryNames.Add ("Philippines");
            countryNames.Add ("Pitcairn");
            countryNames.Add ("Poland");
            countryNames.Add ("Polynesia");
            countryNames.Add ("Portugal");
            countryNames.Add ("Puerto");
            countryNames.Add ("Qatar");
            countryNames.Add ("Reunion");
            countryNames.Add ("Romania");
            countryNames.Add ("Russia");
            countryNames.Add ("Rwanda");
            countryNames.Add ("Saint");
            countryNames.Add ("Saint");
            countryNames.Add ("Saint");
            countryNames.Add ("Saint");
            countryNames.Add ("Saint");
            countryNames.Add ("Samoa");
            countryNames.Add ("San");
            countryNames.Add ("Sao");
            countryNames.Add ("Saudi");
            countryNames.Add ("Senegal");
            countryNames.Add ("Serbia");
            countryNames.Add ("Seychelles");
            countryNames.Add ("Sierra");
            countryNames.Add ("Singapore");
            countryNames.Add ("Slovakia");
            countryNames.Add ("Slovenia");
            countryNames.Add ("Solomon");
            countryNames.Add ("Somalia");
            countryNames.Add ("South");
            countryNames.Add ("South");
            countryNames.Add ("South");
            countryNames.Add ("South");
            countryNames.Add ("Spain");
            countryNames.Add ("Sri");
            countryNames.Add ("Sudan");
            countryNames.Add ("Suriname");
            countryNames.Add ("Svalbard");
            countryNames.Add ("Swaziland");
            countryNames.Add ("Sweden");
            countryNames.Add ("Switzerland");
            countryNames.Add ("Syria");
            countryNames.Add ("Taiwan");
            countryNames.Add ("Tajikistan");
            countryNames.Add ("Tanzania");
            countryNames.Add ("Thailand");
            countryNames.Add ("Timor");
            countryNames.Add ("Togo");
            countryNames.Add ("Tokelau");
            countryNames.Add ("Tonga");
            countryNames.Add ("Trinidad");
            countryNames.Add ("Tunisia");
            countryNames.Add ("Turkey");
            countryNames.Add ("Turkmenistan");
            countryNames.Add ("Turks");
            countryNames.Add ("Tuvalu");
            countryNames.Add ("Uganda");
            countryNames.Add ("Ukraine");
            countryNames.Add ("United");
            countryNames.Add ("United");
            countryNames.Add ("United");
            countryNames.Add ("Uruguay");
            countryNames.Add ("Uzbekistan");
            countryNames.Add ("Vanuatu");
            countryNames.Add ("Venezuela");
            countryNames.Add ("Vietnam");
            countryNames.Add ("Virgin");
            countryNames.Add ("Wallis");
            countryNames.Add ("Yemen");
            countryNames.Add ("Zambia");
            countryNames.Add ("Zimbabwe");
        }
    }
}
