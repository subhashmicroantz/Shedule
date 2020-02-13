using System;

namespace CSharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MethodCls obj = new MethodCls();

            obj.DefaultMethod();

            obj.MethodP("Vijay");

            obj.MethodA("viji");

            obj.MethodIntx("10");
            obj.MethodInty("5");
            obj.MethodAdd();

        }

        }
    }
