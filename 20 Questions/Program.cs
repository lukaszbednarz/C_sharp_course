using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_Questions
{
    delegate bool AskDelegate(string question);
    delegate void ResponseDelegate(bool answer);

    class Program
    {
        static void Main(string[] args)
        {

            //AskDelegate ask = AskOnConsole;
            //AskDelegate ask = AskOnColorfulConsole;
            AskDelegate ask = AskWithMessageBox;
            ResponseDelegate resp = RespondOnConsole;
            resp += PlayBeep;

            PlayTwentyQuestions(ask, resp); // after

        }

        static bool AskOnConsole(string question)
        {

            Console.Write(question + " ");

            var answer = Console.ReadKey(true).Key == ConsoleKey.Y;

            return answer;

        }

        static void RespondOnConsole(bool answer)
        {

            Console.WriteLine(answer ? "Yes!" : "No!");

        }

        static void PlayBeep(bool response)
        {

            var freq = response ? 1600 : 400;

            Console.Beep(freq, 500);

        }


        static bool AskWithMessageBox(string question)
        {

            var result = System.Windows.Forms.MessageBox.Show(question,

                         "Question", System.Windows.Forms.MessageBoxButtons.YesNo);

            return result == System.Windows.Forms.DialogResult.Yes;

        }


        static bool AskOnColorfulConsole(string question)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(question + " ");

            var answer = Console.ReadKey(true).Key == ConsoleKey.Y;
            Console.ForegroundColor = ConsoleColor.Yellow;

            return answer;

        }

        private static void PlayTwentyQuestions(AskDelegate del, ResponseDelegate resp)
        {

            while (true)
            {

                var question = QuestionsDb.GetRandomQuestion();


                var answer = del(question);
                
                //Console.WriteLine(answer ? "Yes!" : "No!");

                resp(answer);

            }

        }

    }

    static class QuestionsDb
    {

        static string[] questions = new string[]
        {
            "Is it an animal?",
            "Can it do tricks?",
            "Can you see it in a zoo?",
            "Does it lay eggs?",
            "Does it like to run?",
            "Does it roar?",
            "Do you find it in the sky?",
            "Does it come in different colors?",
            "Is it wild?",
            "Does it have hands?",

        };

        static Random rng = new Random();

        public static string GetRandomQuestion()
        {

            return questions[rng.Next(questions.Length)];

        }

    }

}
