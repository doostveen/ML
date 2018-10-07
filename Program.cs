using System;

namespace ml_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Machine Learning Test");

            var model = Learner.Train().Result;
            Learner.Evaluate(model);
            Learner.Predict(model);

            Console.WriteLine("Completed.");
        }
    }
}
