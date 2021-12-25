using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cir = new circle();
            float g =Cir.GetRadius(4);
            Cir.Area();
            Cir.Circumference();
        }
    }
}
