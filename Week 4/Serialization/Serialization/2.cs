
using System;


namespace Serialization
{
    [Serializable]
    class Complex
    {
        public int a;
        public int b;

        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }


        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex w1, Complex w2)
        {
            
            Complex w = new Complex((w1.a * w2.b + w2.a * w1.b), (w1.b * w2.b));
            w.Simplify();
            return w;
        }
        public static Complex operator -(Complex w1, Complex w2)
        {
            Complex w = new Complex(w1.a * w2.b - w2.a * w1.b, (w1.b * w2.b));
            w.Simplify();
            return w;
        }
        public static Complex operator *(Complex w1, Complex w2)
        {

            Complex w = new Complex(w1.a * w2.a, w1.b * w2.b);
            w.Simplify();
            return w;
        }
        public static Complex operator /(Complex w1, Complex w2)
        {  

            Complex w = new Complex(w1.a * w2.b, w1.b * w2.a);
            w.Simplify();
            return w;
        }

        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            int nod = _a + _b;
            a /= nod;
            b /= nod;
        }
    }
}