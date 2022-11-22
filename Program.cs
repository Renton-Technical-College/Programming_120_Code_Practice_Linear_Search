using System;

namespace Code_Practice_Linear_Search
{
    class Program
    {
        static string[] countries =
            {
                "China", 
                "United States",
                "India", 
                "Ethiopia",
                "France",
                "Moldova",
                "Eritrea",
                "Uganda",
                "Hong Kong",
                "Hungary"
            };

        static int[] populations =
            {
                1425857090,
                338916212,
                1421019288,
                124613966,
                64678873,
                3451006,
                3708924,
                47000000,
                7488720,
                10188300
            };

        static void Main(string[] args)
        {


            Console.ReadKey();

        } // Main

        // Create three methods that use linear search ( you can use while, for, or foreach. Whichever is appropriate )

        // Method 1:
        // Contains
        // Create a method that returns a bool, and takes a string ( country name ) ( optional, you can have it take an array )
        // A country name is passed in as an argument. Return true if the Country name is in the array, or false if it is not
        // Test Result: "Uganda" - true, "Monaco" - false

        // Method 2:
        // IndexOf
        // Create a method that returns a int, and takes a string ( country name ) ( optional, you can have it take an array )
        // A country name is passed in as an argument. Return the index if the Country name is in the array, or -1
        // Test Result: "Uganda" - 7, "Monaco" - ( -1 )

        // Method 3:
        // Population Range
        // Create a method that doesn't return anything ( void ), it will take 2 paremeters. A low value and a high value.
        // Display all countries and their populations who's populations are between those values
        // Test Result: low = 3000000, high = 4000000

        // Result: 
        // Moldova - 3451006
        // Eritrea - 3708924

        // -------------------------------------------------

        // Create 2 arrays of your own. They must have at least 5 elements.
        // They can be of any type, they just have to be parallel ( have the same capacity and the elements at the same index are related )
        // Create the 3 methods above, but to work with your arrays

        // Ex. string[] discworldBooks = { "Thief of Time", "Night Watch", "Making Money" };
        //     int[]    published = { 2001, 2002, 2007 }
        // Method 1: Contains("Night Watch"); - True
        // Method 2: IndexOf("Making Money"); - 2
        // etc...


    } // class

} // namespace
