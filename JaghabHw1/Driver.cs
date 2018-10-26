using System;

namespace JaghabHw1 {

    /// <summary>
    /// Main Driver program.
    /// </summary>

    #region Driver Class

    public class Driver {

        /// <summary>
        /// Main entry point in project.
        /// </summary>
        /// <param name="args">console args</param>

        #region Main method.

        static void Main(string[] args) {

            ProjectMenu menu = new ProjectMenu();
            menu.UnitTestCountryList();
         
        }

        #endregion

    }
    #endregion
}
