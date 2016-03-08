﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Querrying_Countries_List
{
    static class Database
    {

        public static string[] Countries = new string[]

        {

            "Afghanistan",

            "Albania",

            "Algeria",

            "Andorra",

            "Angola",

            "Antigua and Barbuda",

            "Argentina",

            "Armenia",

            "Australia",

            "Austria",

            "Azerbaijan",

            "Bahamas",

            "Bahrain",

            "Bangladesh",

            "Barbados",

            "Belarus",

            "Belgium",

            "Belize",

            "Benin",

            "Bhutan",

            "Bolivia",

            "Bosnia and Herzegovina",

            "Botswana",

            "Brazil",

            "Brunei",

            "Bulgaria",

            "Burkina",

            "Burma (Myanmar)",

            "Burundi",

            "Cambodia",

            "Cameroon",

            "Canada",

            "Cape Verde",

            "Central African Republic",

            "Chad",

            "Chile",

            "China",

            "Colombia",

            "Comoros",

            "Congo",

            "Congo, Democratic Republic of",

            "Costa Rica",

            "Croatia",

            "Cuba",

            "Cyprus",

            "Czech Republic",

            "Denmark",

            "Djibouti",

            "Dominica",

            "Dominican Republic",

            "East Timor",

            "Ecuador",

            "Egypt",

            "El Salvador",

            "Equatorial Guinea",

            "Eritrea",

            "Estonia",

            "Ethiopia",

            "Fiji",

            "Finland",

            "France",

            "Gabon",

            "Gambia",

            "Georgia",

            "Germany",

            "Ghana",

            "Greece",

            "Grenada",

            "Guatemala",

            "Guinea",

            "Guinea-Bissau",

            "Guyana",

            "Haiti",

            "Honduras",

            "Hungary",

            "Iceland",

            "India",

            "Indonesia",

            "Iran",

            "Iraq",

            "Ireland",

            "Israel",

            "Italy",

            "Ivory Coast",

            "Jamaica",

            "Japan",

            "Jordan",

            "Kazakhstan",

            "Kenya",

            "Kiribati",

            "Korea, North",

            "Korea, South",

            "Kuwait",

            "Kyrgyzstan",

            "Laos",

            "Latvia",

            "Lebanon",

            "Lesotho",

            "Liberia",

            "Libya",

            "Liechtenstein",

            "Lithuania",

            "Luxembourg",

            "Macedonia",

            "Madagascar",

            "Malawi",

            "Malaysia",

            "Maldives",

            "Mali",

            "Malta",

            "Marshall Islands",

            "Mauritania",

            "Mauritius",

            "Mexico",

            "Micronesia",

            "Moldova",

            "Monaco",

            "Mongolia",

            "Montenegro",

            "Morocco",

            "Mozambique",

            "Namibia",

            "Nauru",

            "Nepal",

            "Netherlands",

            "New Zealand",

            "Nicaragua",

            "Niger",

            "Nigeria",

            "Norway",

            "Oman",

            "Pakistan",

            "Palau",

            "Panama",

            "Papua New Guinea",

            "Paraguay",

            "Peru",

            "Philippines",

            "Poland",

            "Portugal",

            "Qatar",

            "Romania",

            "Russian Federation",

            "Rwanda",

            "Saint Kitts and Nevis",

            "Saint Lucia",

            "Saint Vincent and the Grenadines",

            "Samoa",

            "San Marino",

            "Sao Tome and Principe",

            "Saudi Arabia",

            "Senegal",

            "Serbia",

            "Seychelles",

            "Sierra Leone",

            "Singapore",

            "Slovakia",

            "Slovenia",

            "Solomon Islands",

            "Somalia",

            "South Africa",

            "South Sudan",

            "Spain",

            "Sri Lanka",

            "Sudan",

            "Suriname",

            "Swaziland",

            "Sweden",

            "Switzerland",

            "Syria",

            "Tajikistan",

            "Tanzania",

            "Thailand",

            "Togo",

            "Tonga",

            "Trinidad and Tobago",

            "Tunisia",

            "Turkey",

            "Turkmenistan",

            "Tuvalu",

            "Uganda",

            "Ukraine",

            "United Arab Emirates",

            "United Kingdom",

            "United States",

            "Uruguay",

            "Uzbekistan",

            "Vanuatu",

            "Vatican City",

            "Venezuela",

            "Vietnam",

            "Yemen",

            "Zambia",

            "Zimbabwe"

        };

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var c = Database.Countries;

            var q =
                from names in c
                where names.ToLower().StartsWith("c") && names.ToLower().EndsWith("a")
                select names;

            foreach (var name in q)
                Console.WriteLine(name);

            Console.ReadLine();


        }
    }
}