using System;
using System.Collections.Generic;
namespace matherOfTheUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            List<List<int>> multiplier = new List<List<int>>();

            
            int multipleRandom = generator.Next(11);
            int score = 0;  //startar randomizer och ger score på 0 

            /*System.Console.WriteLine("what is");
            Console.WriteLine("x * " + multipleRandom + " = " ); 

            string answerX = Console.ReadLine();

            bool lyckad = TryParse(answerX);
            while (lyckad == false){
                System.Console.WriteLine("invalid answer");
                answerX = Console.ReadLine();
                lyckad = TryParse(answerX);
            }


            int playerAnswer= PlayerAnswer(answerX);

            int playerResult = playerAnswer * multipleRandom; 
            int correctanswer = randomizer / multipleRandom; 

            if (playerAnswer!=randomizer){
                System.Console.WriteLine("you wrote in " + playerResult);
                System.Console.WriteLine("thats wrong sorry! Correct answer is" + correctanswer);

            }
            else{
                System.Console.WriteLine("you got it right! one point added");
                score++; 
            }

            Console.ReadLine();
        }*/

        static List<int>  MultiplicationFactor(int factor){
            int secondFactor =1; 
            List<int> result = new List<int>();
            while(secondFactor != 11){
                result.Add(factor*secondFactor);
                secondFactor++; 
            }
    
            return result;
        }
       /* static int PlayerAnswer (string answerX){ //ger oss spelarens svar som en int 
            int playerAnswer;
            bool lyckad = int.TryParse(answerX, out playerAnswer);
            return playerAnswer;
        }
        static bool TryParse(string answerX){ //gör en tryparse
            
            int x; 
            bool lyckad = int.TryParse(answerX, out x);
            return lyckad;
        }*/
        
    }
}
}