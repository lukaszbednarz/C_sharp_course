using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Call_a_Generic_Method
{
    enum JobStatus
    {
        Unknown,
        Created,
        InProgress,
        Completed,
        Archived,
    }

    class Program
    {
        static void Main(string[] args)
        {
            var statuses = new[]
        {
            "Created",
            "InProgress",
            "Completed",
            "Archived",
            "asdf", // should parse to Unknown
        };

            foreach (var str in statuses)
            {
                JobStatus status = JobStatus.Unknown;
                // TODO: Call Enum.TryParse<T>(...) to convert the strings to type JobStatus.
                Enum.TryParse<JobStatus>(str, out status);

                Console.WriteLine(status);
            }

            Console.ReadKey();
        }
    }

}
