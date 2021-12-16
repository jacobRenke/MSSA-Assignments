using System;

namespace example
{
    class Human
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public int favorite_number { get; set; }

        public Human (string first_name = "John", string last_name = "Doe", int age = 18, int favorite_number = 7) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.favorite_number = favorite_number;
        }
        // Create a method to return the human's favorite number
        public int getFavNum()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favNum = Convert.ToInt32(Console.ReadLine());
            return favNum;
        }
        // Create a favoriteFood method to select that the favorite food is pizza.

        // Create a openLoveLetter method that will only receive read only variables. Human won't be able to open letter.
    }
}
