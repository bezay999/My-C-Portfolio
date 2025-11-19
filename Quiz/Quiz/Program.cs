using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            int score = 0;

            string[] questions = 
                {"President of the USA is Trump? Yes or No", 
                    "The capital of Poland is Warsaw? Yes or No", 
                        "The elephants live in Europe? Yes or No",
                            "The UK is in EU? Yes or No" };
          
            
            bool[] responses = {true, true, false, false};

            for (int askingIndex = 0; askingIndex < questions.Length; askingIndex++)
            {
                Console.WriteLine(questions[askingIndex]);
                string input = Console.ReadLine();
                input = input.ToUpper();
                bool inputBool = input == "YES";

                if (responses[askingIndex] == inputBool)
                {
                    Console.WriteLine(true);
                    score++;
                }
                else
                {
                    Console.WriteLine(false);
                }
                
                
            }

        Console.WriteLine($"You answered {score} questions! You've got {score} scores.");
        }
    }
}