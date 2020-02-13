using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples
{
    public class MethodCls
    {
        public int i;
        public int x;
        public int y;
        public int z;

        public string str;

        public void DefaultMethod()
        {
            Console.WriteLine("Subash name");
        }

        internal void MethodIntx(string v)
        {
            throw new NotImplementedException();
        }

        internal void MethodAdd()
        {
            throw new NotImplementedException();
        }

        internal void MethodInty(string v)
        {
            throw new NotImplementedException();
        }

        public void MethodP(string name)
        {
            Console.WriteLine("My Name is " + name);
        }


        public void MethodA(string name2)
        {
            Console.WriteLine(name2);
        }

        public void MethodIntx(int x)
        {
            Console.WriteLine(x);

        }
        public void MethodInty(int y)
        {
            Console.WriteLine(y);
        }

        public void MethodAdd(int z)
        {
            Console.WriteLine(z = x + y);
        }

    

    }
}
