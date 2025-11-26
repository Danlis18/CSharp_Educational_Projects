namespace _015_Interface
{
    class MyClass : InterfaceTEST2, InterfaceTEST1
    {
        void InterfaceTEST1.TestMethod()
        {
            Console.WriteLine("Interface1");
        }

        void InterfaceTEST2.TestMethod()
        {
          
           Console.WriteLine("Interface2");
            
        }
    }
}
