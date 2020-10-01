using System;
using System.Collections.Generic;
namespace matherOfTheUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int multipleRandom = generator.Next(1,10);
            int score = 0;  //startar randomizer och ger score på 0 

            List<List<int>> multiplier = new List<List<int>>();

            List <int> factor = new List<int>();

            int factorListAdd=0;

            for (factorListAdd = 0; factorListAdd< 10; factorListAdd++) // gör en loop så factor listan får 1,2,3 etc i sig
            {
                factor.Add(factorListAdd);
            }

            int factorAdd = 0;

            for (factorAdd = 0; factorAdd< 11; factorAdd++) // gör en loop som multipliserar och ger ny lista med produkten av factorAdd * multiplicationfactor
            {
                multiplier.Add(new List<int>(MultiplicationFactor(factorAdd)));

            }

            

            System.Console.WriteLine("what is");
            Console.Write("x * "); 
            Console.Write(factor[multipleRandom]);

            int listChosen = factor[multipleRandom]; 
            Console.Write(" = ");
            Console.Write(multiplier[listChosen][multipleRandom]);
            Console.WriteLine();

            string playerAnswerString = Console.ReadLine();

            int playerChoice = PlayerAnswer(playerAnswerString);

            bool lyckad = TryParse(playerAnswerString);

            while (lyckad != true){
                System.Console.WriteLine("invalid answer");
                playerAnswerString = Console.ReadLine();
                playerChoice = PlayerAnswer(playerAnswerString);
                lyckad = TryParse(playerAnswerString); 
            }


            int rightAnswer = multiplier[listChosen][multipleRandom] / factor[multipleRandom] ;
            int playerInput = multiplier[listChosen][multipleRandom] / playerChoice; 

            if (playerChoice == rightAnswer){
                System.Console.WriteLine("correct! one point added");
                score++; 
            }
            else{
                System.Console.WriteLine("incorrect the right answer was" + rightAnswer);
                System.Console.WriteLine("you wrote" + playerInput);
             }


            Console.ReadLine();
        }

        static List<int>  MultiplicationFactor(int factor){ //multiplicerar och returnerar en lista, i fallet av 3 så ser listan ut 3,6,9 etc
            int secondFactor =1; 
            List<int> result = new List<int>();
            for(secondFactor = 1; secondFactor < 11; secondFactor++){
                result.Add(factor*secondFactor);
            }

            return result;
        }
       static int PlayerAnswer (string answerX){ //ger oss spelarens svar som en int 
            int playerAnswer;
            bool lyckad = int.TryParse(answerX, out playerAnswer);
            return playerAnswer;
        }
        static bool TryParse(string answerX){ //gör en tryparse
            
            int x; 
            bool lyckad = int.TryParse(answerX, out x);
            return lyckad;
        }
    }
}