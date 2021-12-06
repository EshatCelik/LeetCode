using System;

namespace MorsAlphabeth
{
    class Program
    {
        class TwoDShape
        {
            double width;
            double height;
            public TwoDShape()
            {
                width = height = 0.0;
            }
            public TwoDShape(double w,double h)
            {
                width=w;
                height=h;
            }
            public TwoDShape(double x)
            {
                width=height=x;
            }
            public double Width { get { return width; } set { width = value; } }
            public double Height { get { return height; } set { height = value; } }
            public void show()
            {
                Console.WriteLine("x, y" + width +" ,"+height);
            }
        }
        class Triangle : TwoDShape
        {
            string stil;

            public Triangle()
            {
                stil = null;
            }
            public Triangle(string s,double h, double w):base(h, w)
            {
                stil = s;
            }
            public Triangle(string s, double h):base(h)
            {
                stil = "ikizkenar";
            }
            public double area()
            {
                return Height * Width / 2;
            }
        }
        interface IA
        {
            int meth(int x);
        }
        interface IB
        {
            int meth(int x);
        }
        //class A : IA, IB
        //{
        //     int IA.meth(int x)
        //    {
        //        return x + x;
        //    }
        //     int IB.meth(int x) 
        //    {
        //        return x * x; 
        //    }

        //    public int MethA(int x)
        //    {
        //        IA a = this;
        //       return a.meth(x);
        //    }
        //    public int MethB(int x)
        //    { 
        //        IB b = this;
        //        return b.meth(x);
        //    }
        //}

        class A
        {
           
            public void sayHello() 
            {
                Console.WriteLine("hello");
            }
        }
        class B:A
        {

        }

        class Test <T> where T : A
        {
            T obj;
            public Test(T o)
            {
                obj = o;
            }
            public void sayHelloGeneric()
            {
                Console.WriteLine("hello");
            }
        }
        class C
        {

        }
        static void Main(string[] args)
        {


            A a = new A();
            B b = new B();
            C c = new C();

            Test<A> t = new Test<A>(a);
            t.sayHelloGeneric();
            Test<B> tB= new Test<B>(b);
            tB.sayHelloGeneric();

            //char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            //    'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //string[] morseLetters = { "    ", ". ___", "___ . . .", "___ . ___ .", "___ . .", ".", ". . ___ .", "___ ___ .",
            //    ". . . .", ". .", ". ___ ___ ___", "___ . ___", ". ___ . .", "___ ___", "___ .", "___ ___ ___", ". ___ ___ .",
            //    "___ ___ . ___", ". ___ .", ". . .", "_", ". . ___", ". . . ___", ". ___ ___", "___ . . ___", "___ . ___ ___",
            //    "___ ___ . .", ". ___ ___ ___ ___", ". . ___ ___ ___", ". . . ___ ___", ". . . . ___", ". . . . .", "___ . . . .",
            //    "___ ___ . . .", "___ ___ ___ . .", "___ ___ ___ ___ .", "___ ___ ___ ___ ___" };


            //Console.WriteLine("Bir Yazı giriniz    : ");
            //string yazi = Console.ReadLine();
            //yazi = yazi.ToLower();
            //string ceviri = "";
            ////e=.
            ////s=. . . 
            ////h=. . . .
            ////a=. ___
            ////t=_
            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    for (int j = 0; j< letters.Length; j++)
            //    {

            //        if (yazi[i] ==letters[j])
            //        {
            //            ceviri += morseLetters[j]+"";
            //        }
            //    }
            //}

            //Console.WriteLine("Çeviri   :" + ceviri);
        }
    }
}
