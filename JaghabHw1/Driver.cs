using CountryData;
using System;

namespace JaghabHw1 {

    /// <summary>
    /// Main Driver program.
    /// </summary>

    public class Driver {

        /// <summary>
        /// Creates a menu to test the classes in the
        /// CountryData class library.
        /// </summary>

        private static void Menu() {

            int menu = 3;

            do {
                Console.WriteLine("\n\nCountry Testing Menu");
                Console.WriteLine("**********************");
                Console.WriteLine("1 - Unit Test Currency");
                Console.WriteLine("2 - Unit Test Language");
                Console.WriteLine("3 - Exit");
                Console.Write("Enter choice: ");

                string input = Console.ReadLine(); // gets users input as string

                if (!int.TryParse(input, out menu)) { //if false, set menu to 3. 
                    menu = 3;
                }
                CountryAppUnitTesting countryApp = new CountryAppUnitTesting();

                switch (menu) { // swtich on menu's value

                    case 1:
                        countryApp.UnitTestCurrency();
                        break;
                    case 2:
                        countryApp.UnitTestLanguage();
                        break;
                    default:
                        break;
                }

            } while (menu != 3); // method breaks, when menu is 3.

        }

        /// <summary>
        /// Main entry point in project.
        /// </summary>
        /// <param name="args">console args</param>

        static void Main(string[] args) {
            Menu();
        }
    }
}
