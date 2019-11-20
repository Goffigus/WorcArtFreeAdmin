using System;
using static System.Console;

namespace WorcArtFreeAdmin
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] univs = {"anna maria college", "eagle hill school",
                "worcester academy", "worcester polytechnic institute","worcester state university",
            "amc", "ehs", "wa","wpi","wsu"};

            Array.Sort(univs); // sorts array

            string uCheck = ReadLine();

            int found;




            while (true)
            {
                uCheck = uCheck.ToLower(); // sets it all lowercase

                found = Array.BinarySearch(univs, uCheck);
                
                if (found >= 0)
                {
                    WriteLine("Free Admission");

                }
                else
                {
                    WriteLine("Call security");
                }
                uCheck = ReadLine();

            }
            

        }
    }
}
