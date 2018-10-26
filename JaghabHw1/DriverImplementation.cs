using System;

namespace JaghabHw1 {

    /// <summary>
    /// ExtendCountry: Updated to be a static class
    /// that uses extension methods for the following
    /// classes in our .DLL solution.
    /// 
    /// 
    /// </summary>

    #region DriverImplementation class.

    public class DriverImplementation {

        #region methods

        /// <summary>
        /// Prints an objects ToString() method to console with ample lines inbetween.
        /// <para>Make sure the object passed has overrided the ToString() method, or you will get
        /// unexpected results.</para>
        /// </summary>
        /// <param name="obj">The object to call the ToString() method on.</param>

        public static void DisplayObject(object obj) => Console.WriteLine("\n\n" + obj.ToString() + "\n\n");
      
        #endregion
    }

    #endregion
}
