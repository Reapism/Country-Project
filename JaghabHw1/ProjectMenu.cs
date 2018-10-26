using CountryData;
using System;
using System.Collections.Generic;

namespace JaghabHw1 {

    /// <summary>
    /// A class containing menus for various homework assignments.
    /// 
    /// <para>Author: Anthony Jaghab (c), all rights reserved.</para>
    /// </summary>

    #region ProjectMenu class.

    public class ProjectMenu {

        /// <summary>
        /// Unit test for serailizing and deserializing in 
        /// JSON and XML a List of countries.
        /// </summary>

        #region Methods.

        public void UnitTestCountryList() {
            List<Country> countryList = new List<Country>();

            const int exit = 9;
            int menu = exit;

            // run unit testing on country before menu starts.
            CountryAppUnitTesting ut = new CountryAppUnitTesting();
            ut.UnitTestCountry();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nAutomated Unit test finished\n\nPress the enter key to continue...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            do {
                Console.Clear();
                // easier contrast
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nCountry List Testing Menu");
                Console.WriteLine("*****************************");
                Console.WriteLine("1 - Read country list from JSON file");
                Console.WriteLine("2 - Read country list from XML file");
                Console.WriteLine("3 - Write country list from JSON file");
                Console.WriteLine("4 - Write country list from XML file");
                Console.WriteLine("5 - Display all country list items on screen");
                Console.WriteLine("6 - Find and display country by name");
                Console.WriteLine("7 - Find and display countries that use a given currency code");
                Console.WriteLine("8 - Exit");
                Console.Write("Enter Choice: ");

                string input = Console.ReadLine(); // gets users input as string  

                // if false, set menu to exit. 
                if (!int.TryParse(input, out menu)) {
                    menu = exit;
                }

                switch (menu) {
                    case 1: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Country.DeserializeJSON(path, out countryList)
                            ? $"\nDeserialized {path} successfully."
                            : $"\nFailed to deserialize {path}");

                        break;
                    }
                    case 2: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Country.DeserializeXML(path, out countryList)
                            ? $"\nDeserialized {path} successfully."
                            : $"\nFailed to deserialize {path}");

                        break;
                    }
                    case 3: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Country.SerializeJSON(path, countryList)
                            ? $"\nSerialized {path} successfully."
                            : $"\nFailed to serialize {path}");

                        break;
                    }
                    case 4: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Country.SerializeXML(path, countryList)
                            ? $"\nSerialized {path} successfully."
                            : $"\nFailed to serialize {path}");
                        break;
                    }
                    case 5: {
                        foreach (Country c in countryList) {
                            Console.WriteLine(c.ToString() + "\n");
                        }
                        break;
                    }
                    case 6: {
                        Console.Write("Please enter a country name to search in this instance (not case sensitive): ");
                        string name = Console.ReadLine();
                        bool found = false; // at least one country found
                        foreach (Country c in countryList) {
                            if (c.Name.ToLower().Equals(name.ToLower())) { // makes it not case senstive.
                                Console.WriteLine($"\nThe country {c.Name} exists!\n\n" + c.ToString());
                                found = true;
                            }

                        }
                        if (!found) {
                            Console.WriteLine($"\nThe country {name} wasn't found!");
                        }
                        break;
                    }
                    case 7: {
                        Console.Write("Please enter a currency code to search in this instance: ");
                        string code = Console.ReadLine();

                        for (int i = 0; i < countryList.Count; i++) {
                           // Console.WriteLine($"{i}\n\n");
                            if (countryList[i].Currencies.Count > 0) {
                                for (int j = 0; j < countryList[i].Currencies.Count ; j++) {
                                    
                                    if (countryList[i].Currencies[j].Code.Equals(code)) { // null checks in properties for get;
                                        Console.WriteLine(countryList[i].Name);                  
                                    }
                                }
                            }
                        }


                        break;
                    }
                    case 8: {
                        return;
                    }
                    default: {
                        break;
                    }

                }

                if (menu == exit) {
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nPress the enter key to continue...");
                Console.ReadKey();
            } while (menu != exit);

        }

        [Obsolete("The use of this method is no longer required. Country serialize and deserialize is now typeof List<Country>", true)]
        public void UnitTestCountry() {
            const int exit = 16;
            int menu = exit;

            do {
                Console.Clear();
                Console.WriteLine("\n\nCountry Testing Menu");
                Console.WriteLine("************************");
                Console.WriteLine("1 - Read Currency from JSON file");
                Console.WriteLine("2 - Read Currency from XML file");
                Console.WriteLine("3 - Write Currency from JSON file");
                Console.WriteLine("4 - Write Currency from XML file");
                Console.WriteLine("5 - Display Currency data on screen");
                Console.WriteLine("6 - Read Language from JSON file");
                Console.WriteLine("7 - Read Language from XML file");
                Console.WriteLine("8 - Write Language from JSON file");
                Console.WriteLine("9 - Write Language from XML file");
                Console.WriteLine("10 - Display Language data on screen");
                Console.WriteLine("11 - Read Country from JSON file");
                Console.WriteLine("12 - Read Country from XML file");
                Console.WriteLine("13 - Write Country from JSON file");
                Console.WriteLine("14 - Write Country from XML file");
                Console.WriteLine("15 - Display Country data on screen");
                Console.WriteLine("16 - Exit");

                Console.Write("Enter choice: ");

                string input = Console.ReadLine(); // gets users input as string  

                // if false, set menu to exit. 
                if (!int.TryParse(input, out menu)) {
                    menu = exit;
                }

                //currency instance to serialize
                Currency cur = new Currency {
                    Code = "USD",
                    Name = "U.S Dollar",
                    Symbol = "$"

                };

                Language lan = new Language {
                    ISO639_1 = "en",
                    ISO639_2 = "eng",
                    Name = "English",
                    NativeName = "English"
                };

                Country cou = new Country {
                    Capital = "Washington D.C",
                    Population = 350000000,
                    Region = "Americas",
                    Subregion = "Nothern America"
                };

                cou.Currencies.Add(cur);
                cou.Languages.Add(lan);
                switch (menu) { // swtich on menu's value

                    case 1: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Currency.DeserializeJSON(path, out cur)
                            ? $"Deserialized {path} into local instance.\n"
                            : $"Failed to deserialize {path} into local instance.\n");
                        break;
                    }
                    case 2: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Currency.DeserializeXML(path, out cur)
                            ? $"Deserialized {path} into local instance.\n"
                            : $"Failed to deserialize {path} into local instance.\n");
                        break;
                    }
                    case 3: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(cur.SerializeJSON(path) ? $"Serialized {path} .\n" :
                            $"Failed to Serialize {path} .\n");
                        break;
                    }

                    case 4: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(cur.SerializeXML(path) ? $"Serialized {path} .\n" :
                            $"Failed to Serialize {path} .\n");
                        break;
                    }
                    case 5: {
                        DriverImplementation.DisplayObject(cur);
                        break;
                    }
                    case 6: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Language.DeserializeJSON(path, out lan)
                            ? $"Deserialized {path} into local instance.\n"
                            : $"Failed to deserialize {path} into local instance.\n");
                        break;
                    }
                    case 7: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(Language.DeserializeXML(path, out lan)
                            ? $"Deserialized {path} into local instance.\n"
                            : $"Failed to deserialize {path} into local instance.\n");
                        break;
                    }
                    case 8: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(cur.SerializeJSON(path) ? $"Serialized {path} .\n" :
                            $"Failed to Serialize {path} .\n");
                        break;
                    }
                    case 9: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        Console.WriteLine(cur.SerializeXML(path) ? $"Serialized {path} .\n" :
                            $"Failed to Serialize {path} .\n");
                        break;
                    }
                    case 10: {
                        DriverImplementation.DisplayObject(lan);
                        break;
                    }
                    case 11: {
                        //Console.Write("Please enter a filename: ");
                        //string path = Console.ReadLine();

                        //Console.WriteLine(Country.DeserializeJSON(path, out cou)
                        //    ? $"Deserialized {path} into local instance.\n"
                        //    : $"Failed to deserialize {path} into local instance.\n");
                        break;
                    }
                    case 12: {
                        //Console.Write("Please enter a filename: ");
                        //string path = Console.ReadLine();

                        //Console.WriteLine(Country.DeserializeXML(path, out cou)
                        //    ? $"Deserialized {path} into local instance.\n"
                        //    : $"Failed to deserialize {path} into local instance.\n");
                        break;
                    }
                    case 13: {
                        //Console.Write("Please enter a filename: ");
                        //string path = Console.ReadLine();

                        //Console.WriteLine(cou.SerializeJSON(path) ? $"Serialized {path} .\n" :
                        //    $"Failed to Serialize {path} .\n");
                        break;
                    }
                    case 14: {
                        //Console.Write("Please enter a filename: ");
                        //string path = Console.ReadLine();

                        //Console.WriteLine(cou.SerializeXML(path) ? $"Serialized {path} .\n" :
                        //    $"Failed to Serialize {path} .\n");
                        break;
                    }
                    case 15: {
                        DriverImplementation.DisplayObject(cou);
                        break;
                    }
                    case 16: {
                        return;
                    }

                    default:
                        break;
                }

                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
            } while (menu != exit);
        }

        /// <summary>
        /// Creates a unit test menu to test the classes in the
        /// CountryData class library.
        /// </summary>

        public void UnitTestMenu() {

            const int exit = 4;
            int menu = exit;

            do {
                Console.WriteLine("\n\nCountry Testing Menu");
                Console.WriteLine("**********************");
                Console.WriteLine("1 - Unit Test Currency");
                Console.WriteLine("2 - Unit Test Language");
                Console.WriteLine("3 - Unit Test Country");
                Console.WriteLine("4 - Exit");
                Console.Write("Enter choice: ");

                string input = Console.ReadLine(); // gets users input as string
                CountryAppUnitTesting countryApp = new CountryAppUnitTesting();
                Console.Clear();

                // if false, set menu to exit. 
                if (!int.TryParse(input, out menu)) {
                    menu = exit;
                }

                switch (menu) { // swtich on menu's value

                    case 1:
                        countryApp.UnitTestCurrency();
                        break;
                    case 2:
                        countryApp.UnitTestLanguage();
                        break;
                    case 3:
                        countryApp.UnitTestCountry();
                        break;
                    default:
                        break;
                }

            } while (menu != exit); // method breaks, when menu is = to exit.

        }

        #endregion

    }

    #endregion
}
