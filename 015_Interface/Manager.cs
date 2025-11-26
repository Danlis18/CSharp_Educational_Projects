namespace _015_Interface
{
    class Manager : Worker, IManager, IWorker
    {
        public void Control()
        {
            Console.WriteLine("Manager Controls");
        }

        public void Organize()
        {
            Console.WriteLine("Manager Organize");
        }

        public void Motivate()
        {
            Console.WriteLine("Manager Motivate");
        }

        public void Plan()
        {
            Console.WriteLine("Manager Plan");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work");
        }

        public void Relax()
        {
            Console.WriteLine("Manager Relax");
        }
    }
}
