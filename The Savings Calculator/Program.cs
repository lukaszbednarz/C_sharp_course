using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using LearningLine.Practice;

namespace The_Savings_Calculator
{
    class Program
    {
        enum Quotes { ammount, duration, intrest, futureValue};
        enum Response { ammount, intrest, duration, futureValue };

        static void Main(string[] args)
        {
            _ReadConfigFileAndPrintTitle();

            _QueryDepositDetailsAndPrintFutureValue();

            _AskForKeyPress();

        }

        private static void _QueryDepositDetailsAndPrintFutureValue()
        {
            string ammountQuerryMsg     = "Enter a monthly savings ammount ($): ";
            string yearsQuerryMsg       = "Enter the # of years: ";
            string intrestQuerryMsg     = "Enter the annual intrest rate: ";

            string ammountRespMsg       = "Montly Payment:";
            string intrestRespMsg       = "Montly Intrest Rate:";
            string durationRespMsg      = "Duration:";
            string futureValRespMsg     = "FutureVal:";

            //enum Quotes {ammount, years, intrest};

            List<string> querryList = new List<string> { 
                                                   ammountQuerryMsg, 
                                                   yearsQuerryMsg, 
                                                   intrestQuerryMsg
                                                   };

            List<string> respList = new List<string> { 
                                                   ammountRespMsg, 
                                                   intrestRespMsg,
                                                   durationRespMsg, 
                                                   futureValRespMsg
                                                   };
            List<string> respFormList = new List<string> { 
                                                           "${0:F2}",
                                                           "{0:G4}",
                                                           "{0:F0} months",
                                                           "${0:F2}"};
            
            List<int> lengthList = new List<int> { 
                                                   ammountQuerryMsg.Length, 
                                                   yearsQuerryMsg.Length, 
                                                   intrestQuerryMsg.Length
                                                   };

            List<int> respLengthList = new List<int> { 
                                                   ammountRespMsg.Length, 
                                                   durationRespMsg.Length, 
                                                   intrestRespMsg.Length,
                                                   futureValRespMsg.Length
                                                   };

            List<double> factorList = new List<double> { 
                                                        1,
                                                        12,
                                                        (float)1/(float)12,
                                                        1};

            List<double> dataList = new List<double> {};
            
            int querryFieldLen = lengthList.Max();

            querryFieldLen++;

            int respFieldLen = respLengthList.Max();

            respFieldLen += 4;
            
            string format = string.Format("{{0,{0}}}", querryFieldLen);

            string respFormat = string.Format("{{0,-{0}}}", respFieldLen);

            for (int i = 0; i < querryList.Count; i++) 
            {
                string userInput;
                Console.Write(string.Format(format, querryList[i]));
                userInput = Console.ReadLine();
                dataList.Add(double.Parse(userInput) * factorList[i]);
            }
            
            Console.Write("\n");

            double futureValue = SavingsCalc.CalculateFutureValue(
                                                                  dataList[(int)Quotes.ammount],
                                                                  (int)dataList[(int)Quotes.duration], 
                                                                  0.01*dataList[(int)Quotes.intrest]
                                                                  );

            dataList.Add(futureValue);

            int[] dataOrder = {0, 2, 1, 3};
            
                       
            
            foreach ( int i in Enum.GetValues(typeof(Response)))
            {
                
                Console.WriteLine(string.Format(respFormat, respList[i]) +
                               string.Format(respFormList[i], dataList[dataOrder[i]]));
             }

            Console.Write("\n");


        }

        private static void _ReadConfigFileAndPrintTitle()
        {
            string title = ConfigurationManager.AppSettings["title"];

            Console.WriteLine(title + "\n");

        }

        private static void _AskForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
