﻿string[] words = { "Mumbai", "Kolkata", "Chennai", "Delhi", "Banglore" };
            Array.Sort(words);
            Console.WriteLine($"The sorted list of words is : ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }