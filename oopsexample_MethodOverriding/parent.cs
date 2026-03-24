using System;
using System.Collections.Generic;
using System.Text;

namespace oopsexample_MethodOverriding
{
    internal class parent
    { //virtual method always in parent class
        public virtual void sum()
        {
            int x = 10, y = 20, z;
            z = x + y;
            Console.WriteLine("the sum is " + z);
        }
        public void display()//normal method we can't overirde with out virtual keyword
        {
            Console.WriteLine("i am from display ");//without virtual keyword we cannot override the method in child class
        }
    }
}