namespace threadRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready, Set Go...");
            int t1Location = 0;
            int t2Location = 0;
            int t3Location = 0;
            int t4Location = 0;
            int t5Location = 0;

            //Creating Tasks
            Task t1 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.CurrentThread.Name = "Ariel";
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t1Location);
                }
            });
            

            Task t2 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.CurrentThread.Name = "Snow White";
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t2Location);
                }
            });
            

            Task t3 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.CurrentThread.Name = "Rapunzel";
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t3Location);
                }
            });
            

            Task t4 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.CurrentThread.Name = "Sleeping Beauty";
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t4Location);
                }
            });
           

            Task t5 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.CurrentThread.Name = "Cinderella";
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t5Location);
                }
            });

            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            Task.WaitAny(t5);
            Console.WriteLine("Race has ended");

        }
        static void MoveIt(ref int location)
        {
            location++;
            Console.WriteLine($"{Thread.CurrentThread.Name} location={location}");
            if (location >= 100)
            {
                
                Console.WriteLine($"{Thread.CurrentThread.Name} is the winner");
                return;
            }
        }

    }
}