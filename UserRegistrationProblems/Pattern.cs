﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblems
{
    public class Pattern
    {
        //UC1-First name starts with Cap and has minimum 3 characters
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";

        //UC2-Last name starts with Cap and has minimum 3 characters
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";

        //UC3-Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions
        public static string EmailIdPattern = "^[A-Za-z]+[.][a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2}[.][a-zA-Z]{2}$";//abc.xyz@bl.co.in

        //UC4-Country code follow by space and 10 digit number.
        public static string MobileNumberPattern = "^[1-9]{2}?[ ][0-9]{10}$";//91 9966576672

        //UC5-Password Rule1– minimum 8 Characters.
        public static string PasswordRule1Pattern = "^[a-zA-Z0-9]{8,}$";

        /// <summary>
        /// This method used to check Validation
        /// </summary>
        public static void ValidatePattern(string[] inputs, string pattern)
        {
            foreach (string result in inputs)
            {
                if (Regex.IsMatch(result, pattern))
                {
                    Console.WriteLine("{0}    => valid", result);
                }
                else
                {
                    Console.WriteLine("{0}    => Invalid", result);
                }
            }
        }
    }
}