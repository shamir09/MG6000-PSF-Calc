using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_6000
{
    class Program
    {
        static void Main(string[] args)
        {
            // Header
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("MG-6000  Windload Capacity Calculator: ");

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    // Ask for Width input from User 
                    Console.Write("   Please enter the width? ");
                    var widthDouble = double.Parse(Console.ReadLine());
                    Console.Write("   Please enter the height? ");
                    var heigthDouble = double.Parse(Console.ReadLine());

                    Console.WriteLine("\n =========================================================================== \n");
                    Console.WriteLine("\t" + GetPSF(widthDouble, heigthDouble));
                    Console.WriteLine("\n ===========================================================================");
                    Console.WriteLine("");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n =========================================================================== \n");
                    Console.WriteLine("\t " + e.Message);
                    Console.WriteLine("\n ===========================================================================");
                    Console.WriteLine("");
                }
            }
        }


        public static string GetPSF(double widthDouble, double heigthDouble)
        {   /* ============================= WORK CONDITIONAL LOGIC TO CALCULATE MULL WINDLOAD CAPACITY =======================================*/
            var psfResult = string.Empty;
               
         

                if (heigthDouble <= 90)                  // At Height of 90"   &   Width:  30", 36", 42", 48", 54", 55", 60"            M1 / J1
                {
                    if (widthDouble <= 55) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF \t M1 / J1"); }
                    else if (widthDouble <= 60) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF \t M1 / J1"); }
                    else if (widthDouble > 60) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
                else if (heigthDouble <= 96)             // At Height of 96"   &   Width:  30", 36", 42", 48", 51", 54", 60"            M1 / J1
                {                                        // At Height of 120"   &   Width:  30", 36", 42", 48", 51", 54", 60" 66", 72"   M3 / J2
                    if (widthDouble <= 48) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF \t M1 / J1 \n \t \t =  +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 51) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -107.6 PSF \t M1 / J1 \n \t \t =  +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 60) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +70.0 / -70.0 PSF   \t M1 / J1 \n \t \t =  +100.0 / -115.0 PSF \t M3 / J2 * Reinforced"); }
                    else if (widthDouble <= 72) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -115.0 PSF" + "  \t *Reinforced M3 / J2"); }
                    else if (widthDouble > 72) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
                else if (heigthDouble <= 102)            // At Height of 102"  &   Width:  30", 36", 42", 48", 54", 57"                 M1 / J1
                {                                                           // &   Width:  30", 36", 42", 48", 54", 60" 66", 71"        M3 / J2
                    if (widthDouble <= 42) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF \t M1 / J1 \n \t \t = +100.0 / -115.0 PSF \t M3 / J2 * Reinforced"); }
                    else if (widthDouble <= 48) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +98.2 / -98.2 PSF \t M1 / J1 \n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 57) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +70.0 / -70.0 PSF \t M1 / J1 \n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 71) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -115.0 PSF" + "  \t *Reinforced M3 / J2"); }       // M2 / J2
                    else if (widthDouble > 71) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
                else if (heigthDouble <= 108)            // At Height of 108"   &   Width:  30", 36", 42", 48", 54"                     M1 / J1
                {                                            // At Height of 108"   &   Width:  30", 36", 42", 48", 54" 60" 66" 67"         M3 / J2
                    if (widthDouble <= 54) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +70.0 / -70.0 PSF \t M1 / J1 \n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 60) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -115.0 PSF" + "  \t *Reinforced M3 / J2"); }       // M3 / J2
                    else if (widthDouble <= 66) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -111.7 PSF" + "  \t *Reinforced M3 / J2"); }       // M3 / J2
                    else if (widthDouble <= 67) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.5 PSF" + "  \t *Reinforced M3 / J2"); }       // M3 / J2
                    else if (widthDouble > 67) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
                else if (heigthDouble <= 114)            // At Height of 114"   &   Width:  30", 36", 42", 48", 51"                     M1 / J1
                {                                                            // &   Width:  30", 36", 42", 48", 54" 60" 63"             M3 / J2
                    if (widthDouble <= 48) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" = +70.0 / -70.0 PSF \t M1 / J1 \n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 51) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" = +69.4 / -69.4 PSF \t M1 / J1 \n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 54) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 60) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" = +100.0 / -106.4 PSF \t M3 / J2 *Reinforced \n \t \t  = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced Cold Rolled"); }
                    else if (widthDouble <= 63) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" = +100.0 / -102.4 PSF \t M3 / J2 *Reinforced \n \t \t  = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced Cold Rolled"); }
                    else if (widthDouble > 63) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
                else if (heigthDouble <= 120)            // At Height of 120"   &   Width:  30", 36", 42", 48"                      M1 / J1
                {                                        // At Height of 120"   &   Width:  48", 54", 58"                           M2 / J2
                                                         // At Height of 120"   &   Width:  54", 60"                                M2 / J2 *Reinforced Cold Rolled
                    if (widthDouble <= 36) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +70.0 / -70.0 PSF \t M1 / J1 \n \t \t  = +110.0 / -115.0 PSF \t M3 / J2 * Reinforced"); }
                    else if (widthDouble <= 42) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +69.9 / -69.9 PSF \t M1 / J1 \n \t \t = +110.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 48) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +62.1 / -62.1 PSF \t M1 / J1 \n \t \t = +110.0 / -115.0 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 54)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +65.0 / -65.0 PSF \t M1 / J1 \n \t \t = +100.0 / -103.9 PSF \t M3 / J2 *Reinforced");
                    psfResult += ("\n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced Cold Rolled");
                    }
                    else if (widthDouble <= 58)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +65.0 / -65.0 PSF \t M2 / J2 *Reinforced \n \t \t = +95.1 / -95.1 PSF \t M3 / J2 *Reinforced");
                    psfResult += ("\n \t \t = +100.0 / -115.0 PSF \t M3 / J2 *Reinforced Cold Rolled");
                    }
                    else if (widthDouble <= 60)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" \t \t = +95.1 / -95.1 PSF \t M3 / J2 * Reinforced");
                    psfResult += ("\n \t \t = +100.0 / -115.0 PSF \t M3 / J2 * Reinforced Cold Rolled");
                    }
                    else if (widthDouble > 60) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
                else if (heigthDouble <= 126)
                {          // At Height of 126" &   Width:  30", 36", 42", 48", 54", 55"           M2 / J2
                           // At Height of 126" &   Width:  30", 36", 42", 48", 54", 55"           M3 / J2 
                           // At Height of 126" &   Width:  30", 36", 42", 48", 54", 55"           M3 / J2  *Reinforced Cold Rolled
                    if (widthDouble <= 42) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF" + "  \t *Reinforced M3 / J2"); }

                    else if (widthDouble <= 48)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -103.9 PSF" + "  \t *Reinforced M3 / J2");
                    psfResult += ("\n \t \t = +100.0 / -110.0 PSF \t M3 / J2 *Reinforced Cold Rolled");
                    }
                    else if (widthDouble <= 54)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +93.6 / -93.6 PSF" + "  \t *Reinforced M3 / J2");
                    psfResult += ("\n \t \t = +100.0 / -107.6 PSF \t M3 / J2 *Reinforced Cold Rolled");
                    }
                    else if (widthDouble <= 55)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +65.0 / -65.0 PSF" + "  \t M2 / J2 *Reinforced");
                    psfResult += ("\n \t \t  = +92.1  / -92.1  PSF \t M3 / J2 *Reinforced");
                    psfResult += ("\n \t \t  = +100.0 / -105.9 PSF \t M3 / J2 *Reinforced Cold Rolled");
                    }
                    else if (widthDouble > 55) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
            }
                else if (heigthDouble <= 132)             // At Height of 132"   &   Width:  30", 36", 42", 48", 53"                M2 / J2
                {                                         // At Height of 132"   &   Width:  30", 36", 42", 48", 53"                M3 / J2
                                                          // At Height of 132"   &   Width:  42"                                    M3 / J2 *Cold Rolled
                    if (widthDouble <= 36) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF" + "  \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 42)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -106.6 PSF" + "  \t M3 / J2 *Reinforced Cold Rolled");
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF" + "  \t M3 / J2 *Reinforced");
                    }
                    else if (widthDouble <= 48)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +65.0  / -65.0  PSF" + "  \t M2 / J2 *Reinforced");
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +94.3  / -94.3  PSF" + "  \t M3 / J2  *Reinforced Cold Rolled");
                    }
                    else if (widthDouble <= 53) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +86.2  / -86.2  PSF" + "  \t M3 / J2 *Reinforced"); }
                    else if (widthDouble > 53) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
            }

                else if (heigthDouble <= 138)            // At Height of 138"   &   Width:  30", 36", 42", 48", 50"                M2 / J2
                {                                        // At Height of 132"   &   Width:  30", 36", 42", 48", 50"                M3 / J2
                                                         // At Height of 132"   &   Width:  42", 48", 50"                          M3 / J2 *Cold Rolled
                    if (widthDouble <= 36) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF" + "  \t  M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 42)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +65.0  / -65.0  PSF" + "  \t  M2 / J2 *Reinforced");
                    psfResult += ("\n \t \t  =  +97.3  / -97.3  PSF" + "  \t  M3 / J2 *Reinforced");
                    psfResult += ("\n \t \t  =  +100.0 / -101.4 PSF" + " \t  M3 / J2 *Reinforced Cold Rolled");
                    }
                    else if (widthDouble <= 48)
                    {
                    psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +60.1  / -60.1 PSF" + "  \t  M2 / J2");
                    psfResult += ("\n \t \t  =  +85.9  / -85.9 PSF" + "  \t  M3 / J2 *Reinforced");
                    psfResult += ("\n \t \t  =  +86.5 / -86.5 PSF" + "   \t  M3 / J2 *Reinforced Cold Rolled");
                    }
                }
                else if (heigthDouble <= 144)            // At Height of 144"   &   Width:  30", 36", 42", 48"                     M2 / J2
                {
                    if (widthDouble <= 36) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +100.0 / -110.0 PSF" + " \t  M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 36) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +65.0 / -65.0 PSF" + "  \t M2 / J2 *Reinforced \n \t \t = +100.0 / -102.8 PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 42) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +59.6 / -59.6 PSF" + "  \t M3 / J2 *Reinforced \n \t \t =  +88.9 / -88.9  PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble <= 48) { psfResult = (widthDouble + "\" x " + heigthDouble + "\" =  +52.7 / -52.7 PSF" + "  \t M3 / J2 *Reinforced \n \t \t  =  +78.6 / -78.6  PSF \t M3 / J2 *Reinforced"); }
                    else if (widthDouble > 48) { psfResult = (widthDouble + "\" x " + heigthDouble + "\"\t DOES NOT COMPLY WITH PRODUCT APPROVAL"); }
                }
            return psfResult;

        }
    }
}
