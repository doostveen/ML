using System;

namespace ml_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Machine Learning Test");

            var learner = new Learner();
            learner.Learn();
            learner.Estimate();

            Console.WriteLine("Completed.");
        }
    }
}
