﻿using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {
            Random rand = new Random ();
            int secretNumber = rand.Next (1, 11);

            for (int i = 0; i < 3; i++) {
                Console.WriteLine ("guess between 1 and 10");
                string userGuess = Console.ReadLine ();
                int userGuessInt = int.Parse (userGuess);
                if (userGuessInt == secretNumber) {
                    Console.WriteLine ($"You guessed it! It was {secretNumber}");
                    return;
                } else if (userGuessInt < secretNumber && i != 2) {
                    Console.WriteLine ("Nope guess higher");
                } else if (userGuessInt > secretNumber && i != 2) {
                    Console.WriteLine ("Nope guess lower");

                } else {
                    Console.WriteLine ("You're WRONGGGGGG");

                }
            }

        }
    }
}