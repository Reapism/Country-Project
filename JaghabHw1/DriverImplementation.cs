using CountryData;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace JaghabHw1 {

    /// <summary>
    /// DriverImplementation: All Read/Write methods
    /// for serialzing and deserializing JSON and XML
    /// for the Country, Language, and Currency classes.
    /// 
    /// **Also added UnitTesting for Country in the .DLL.
    /// </summary>

    #region DriverImplementation class.

    public class DriverImplementation {

        #region methods

        /// <summary>
        /// Deserializes a serialized Currency type and passes it out.  
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        private void ReadObjectJSON(string path, out Currency type) {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer inSer = new DataContractJsonSerializer(typeof(Currency));

            type = (Currency)inSer.ReadObject(reader);
            reader.Close();
        }

        /// <summary>
        /// Deserializes a serialized Language type and passes it out.  
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        private void ReadObjectJSON(string path, out Language type) {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer inSer = new DataContractJsonSerializer(typeof(Currency));

            type = (Language)inSer.ReadObject(reader);
            reader.Close();
        }

        /// <summary>
        /// Deserializes a serialized Country type and passes it out.  
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        private void ReadObjectJSON(string path, out Country type) {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer inSer = new DataContractJsonSerializer(typeof(Currency));

            type = (Country)inSer.ReadObject(reader);
            reader.Close();
        }

        /// <summary>
        /// Serialize a Country type into JSON.
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        private void WriteObjectJSON(string path, Country type) {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Country));

            ser.WriteObject(writer, type);
            writer.Close();
        }

        /// <summary>
        /// Serialize a Currency type into JSON.
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        private void WriteObjectJSON(string path, Currency type) {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Currency));

            ser.WriteObject(writer, type);
            writer.Close();
        }

        /// <summary>
        /// Serialize a Language type into JSON.
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        private void WriteObjectJSON(string path, Language type) {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Language));

            ser.WriteObject(writer, type);
            writer.Close();
        }

        /// <summary>
        /// Deserializes a serialized Currency type and passes it out.  
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        private void ReadObjectXML(string path, out Currency type) {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractSerializer inSer = new DataContractSerializer(typeof(Currency));

            type = (Currency)inSer.ReadObject(reader);
            reader.Close();
        }

        /// <summary>
        /// Deserializes a serialized Language type and passes it out.  
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        private void ReadObjectXML(string path, out Language type) {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractSerializer inSer = new DataContractSerializer(typeof(Language));

            type = (Language)inSer.ReadObject(reader);
            reader.Close();
        }

        /// <summary>
        /// Deserializes a serialized Country type and passes it out.  
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        private void ReadObjectXML(string path, out Country type) {
            FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read);
            DataContractSerializer inSer = new DataContractSerializer(typeof(Country));

            type = (Country)inSer.ReadObject(reader);
            reader.Close();
        }

        /// <summary>
        /// Serialize a Currency type into XML.
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        private void WriteObjectXML(string path, Currency type) {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractSerializer ser = new DataContractSerializer(typeof(Currency));

            ser.WriteObject(writer, type);
            writer.Close();
        }

        /// <summary>
        /// Serialize a Language type into XML.
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        private void WriteObjectXML(string path, Language type) {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractSerializer ser = new DataContractSerializer(typeof(Language));

            ser.WriteObject(writer, type);
            writer.Close();
        }

        /// <summary>
        /// Serialize a Country type into XML.
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        private void WriteObjectXML(string path, Country type) {
            FileStream writer = new FileStream(path, FileMode.Create, FileAccess.Write);
            DataContractSerializer ser = new DataContractSerializer(typeof(Country));

            ser.WriteObject(writer, type);
            writer.Close();
        }

        /// <summary>
        /// Writes to console the ToString method on an object.
        /// 
        /// <para>Passed object must override the ToString() method to
        /// get the actual information of the object.</para>
        /// </summary>
        /// <param name="obj">The object to call ToString() on.</param>

        private void DisplayObject(object obj) => Console.WriteLine("\n\n" + obj.ToString());

        /// <summary>
        /// Provides the menu for serializing and deserializing the
        /// classes in JSON and XML. Uses instances of the currency,
        /// language, and country class to test the deserialization
        /// into objects.
        /// </summary>

        public void UnitTestCountry() {
            const int exit = 16;
            int menu = exit;

            do {
                Console.Clear();
                Console.WriteLine("\n\nCountry Testing Menu");
                Console.WriteLine("**********************");
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
                Console.WriteLine("6 - Read Country from JSON file");
                Console.WriteLine("7 - Read Country from XML file");
                Console.WriteLine("8 - Write Country from JSON file");
                Console.WriteLine("9 - Write Country from XML file");
                Console.WriteLine("10 - Display Country data on screen");
                Console.WriteLine("16 - Exit");

                Console.Write("Enter choice: ");

                string input = Console.ReadLine(); // gets users input as string
                CountryAppUnitTesting countryApp = new CountryAppUnitTesting();              

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
                    Currency = cur,
                    Language = lan,
                    Population = 350000000,
                    Region = "Americas",
                    Subregion = "Nothern America"
                };

                switch (menu) { // swtich on menu's value

                    case 1: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        ReadObjectJSON(path, out cur);
                        Console.WriteLine($"Deserialized {path} into local instance.\n");
                        break;
                    }
                    case 2: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        ReadObjectXML(path, out cur);
                        Console.WriteLine($"Deserialized {path} into local instance.\n");
                        break;
                    }
                    case 3: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        WriteObjectJSON(path, cur);
                        Console.WriteLine($"Serialized {path} .\n");
                        break;
                    }

                    case 4: {

                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        WriteObjectXML(path, cur);
                        Console.WriteLine($"Serialized {path} .\n");
                        break;
                    }
                    case 5: {
                        DisplayObject(cur);
                        break;
                    }
                    case 6: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        ReadObjectJSON(path, out lan);
                        Console.WriteLine($"Deserialized {path} into local instance.\n");
                        break;
                    }
                    case 7: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        ReadObjectXML(path, out lan);
                        Console.WriteLine($"Deserialized {path} into local instance.\n");
                        break;
                    }
                    case 8: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        WriteObjectJSON(path, lan);
                        Console.WriteLine($"Serialized {path} .\n");
                        break;
                    }
                    case 9: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        WriteObjectXML(path, lan);
                        Console.WriteLine($"Serialized {path} .\n");
                        break;
                    }
                    case 10: {
                        DisplayObject(lan);
                        break;
                    }
                    case 11: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        ReadObjectJSON(path, out cou);
                        Console.WriteLine($"Deserialized {path} into local instance.\n");
                        break;
                    }
                    case 12: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        ReadObjectXML(path, out cou);
                        Console.WriteLine($"Deserialized {path} into local instance.\n");
                        break;
                    }
                    case 13: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        WriteObjectJSON(path, cou);
                        Console.WriteLine($"Serialized {path} .\n");
                        break;
                    }
                    case 14: {
                        Console.Write("Please enter a filename: ");
                        string path = Console.ReadLine();

                        WriteObjectJSON(path, cou);
                        Console.WriteLine($"Serialized {path} .\n");
                        break;
                    }
                    case 15: {
                        DisplayObject(cou);
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
