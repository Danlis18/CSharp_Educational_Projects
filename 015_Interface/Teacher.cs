namespace _015_Interface
{
    class Teacher : Worker, IScientist, IWorker
    {
        public void Experiment()
        {
            Console.WriteLine("Teacher Experiments");
        }

        public void Investigate()
        {
            Console.WriteLine("Teacher Investigates");
        }

        public void Relax()
        {
            Console.WriteLine("Teacher Relaxes");
        }

        public void Research()
        {
            Console.WriteLine("Teacher Researches");
        }

        public void Work()
        {
            Console.WriteLine("Teacher Works");
        }
    }
}
