namespace oopsexample_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {//if the program in running ..we called this process is runtime 
            child c1 = new child();
            c1.sum();//in runtime it will call the first overide method.if there no overide method it will go to  virtal method.
            c1.display();
            c1.sum();
            Console.ReadLine();
        }
    }
}