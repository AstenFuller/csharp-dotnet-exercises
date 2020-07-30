using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        // public static string ReverseStringHard(string quote)
        // {
        //     throw new NotImplementedException();
        // }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }
        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int one, int two) {
            return one + two;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static double Divide(double one, double two) {
            return one / two;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age) {
            if(age >= 18) {
                return true;
            } else {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName) {
            return fullName.Split(' ')[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string hard) {
            char[] array = new char[hard.Length];
            int forward = 0;
            for(int i = hard.Length - 1; i >= 0; i--) {
                array[forward++] = hard[i];
            }
            return new string(array);
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string easy) {
            return new string(easy.ToCharArray().Reverse().ToArray());
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */
         public static string PrintTimesTable(int num) {
             var timesTable = String.Join(
                 Environment.NewLine,
                num + " * 1 = " + num,
                num + " * 2 = " + (num * 2),
                num + " * 3 = " + (num * 3),
                num + " * 4 = " + (num * 4),
                num + " * 5 = " + (num * 5),
                num + " * 6 = " + (num * 6),
                num + " * 7 = " + (num * 7),
                num + " * 8 = " + (num * 8),
                num + " * 9 = " + (num * 9),
                num + " * 10 = " + (num * 10)
             );
             return timesTable;
         }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double k) {
            return Math.Round(k * 9 / 5 - 459.67, 2);
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] arr) {
            double num = 0;
            for(int i = 0; i <= arr.Length - 1; i++) {
                num = num + arr[i];
            }
            return num / arr.Length;

        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] arr) {
            return arr.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
         public static string DrawTriangle(int number, int width) {
             string triangle = "";
             for(int i = width; i >= 1; i--){
                 if(i == width) {
                     for(int j = 1; j <= i; j++) {
                         triangle = triangle + number.ToString();
                     }
                 } else {
                     triangle = triangle + "\n";
                     for(int h = 1; h <= i; h++) {
                         triangle = triangle + number.ToString();
                     }
                 }
             }
             return triangle;
         }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds) {
            double totalHours = Convert.ToDouble(hours) + Convert.ToDouble(minutes) / 60 + Convert.ToDouble(seconds) / 60 / 60;
            string mph = Convert.ToString(Math.Round(distance / totalHours));
            return mph + "MPH";
        }


        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letter) {
            if(Char.ToLower(letter) == 'a' || Char.ToLower(letter) == 'e' || Char.ToLower(letter) == 'i' || Char.ToLower(letter) == 'o' || Char.ToLower(letter) == 'u') {
                return true;
            } else {
                return false;
            }
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char letter) {
            if(Char.ToLower(letter) == 'a' || Char.ToLower(letter) == 'e' || Char.ToLower(letter) == 'i' || Char.ToLower(letter) == 'o' || Char.ToLower(letter) == 'u') {
                return false;
            } else {
                return true;
            }
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int num) {
            int count = 0;
            while(num != 1) {
                if(num % 2 == 0) {
                    num = num / 2;
                    count++;
                } else {
                    num = (num * 3) + 1;
                    count++;
                }
            }
            return count;
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static Array GetNext7Days(DateTime dateTime) {
            DateTime[] dateTimes = new DateTime[] 
            {
                dateTime,
                dateTime.AddDays(1),
                dateTime.AddDays(2),
                dateTime.AddDays(3),
                dateTime.AddDays(4),
                dateTime.AddDays(5),
                dateTime.AddDays(6)
            };
            return dateTimes;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int year) {
            if(DateTime.IsLeapYear(year)) {
                return true;
            } else {
                return false;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

         public static string DuckGoose(int num) {
             string duckGoose = "";
             for(int i = 1; i <= num; i++) {
                 if(i == 1) {
                     duckGoose = duckGoose + "1";
                 } else if (i % 3 == 0 && i % 5 == 0) {
                     duckGoose = duckGoose + Environment.NewLine + "DuckGoose";
                 } else if (i % 5 == 0) {
                     duckGoose = duckGoose + Environment.NewLine + "Goose";
                 } else if (i % 3 == 0) {
                     duckGoose = duckGoose + Environment.NewLine + "Duck";
                 } else {
                     duckGoose = duckGoose + Environment.NewLine + i.ToString();
                 }
             }
             return duckGoose;
         }

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}