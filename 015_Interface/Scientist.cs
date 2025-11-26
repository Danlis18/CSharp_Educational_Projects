namespace _015_Interface
{
    internal class Scientist : Worker, IScientist, IWorker
    {
        public void Experiment()
        {
            Console.WriteLine("Scientist Experiments");
        }

        public void Investigate()
        {
            Console.WriteLine("Scientist Investigates");
        }

        public void Relax()
        {
            Console.WriteLine("Scientist Relaxes");
        }

        public void Research()
        {
            Console.WriteLine("Scientist Researches");
        }

        public void Work()
        {
            Console.WriteLine("Scientist Works");
        }
    }
}
