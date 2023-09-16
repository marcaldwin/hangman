using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace hangman
{

    class program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Hangman");
            string[] Guest_Words = new string[10];
            Guest_Words[0] = "ball";
            Guest_Words[1] = "pen";
            Guest_Words[2] = "paper";
            Guest_Words[3] = "tablet";
            Guest_Words[4] = "laptop";
            Guest_Words[5] = "coffee";
            Guest_Words[6] = "fan";
            Guest_Words[7] = "bag";
            Guest_Words[8] = "car";
            Guest_Words[9] = "pencil Case";
            Random qwerty = new Random();
            var marc = qwerty.Next(0, 9);
            string Guest = Guest_Words[marc];
            char[] Word = new char[Guest.Length];
            Console.WriteLine("Please Enter your Guest: ");

            for (int i = 0; i < Guest.Length; i++) 
                Word [i] = '*';

            while (true)
            {
                char PlayerGuest = char.Parse(Console.ReadLine());
                for (int w = 0; w < Guest.Length; w++)
                {
                    if (PlayerGuest == Guest[w])
                        Word[w] = PlayerGuest;
                }
                Console.WriteLine(Word);
            }
        }
    }
}