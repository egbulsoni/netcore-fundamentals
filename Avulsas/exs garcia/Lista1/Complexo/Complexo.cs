namespace Complexo
{   
    class Complexo
    {
        public double a { get; set; }
        public double b { get; set; }

        public Complexo(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public Complexo soma(Complexo x, Complexo y)
        {
            var c1 = x.a + y.a;
            var c2 = x.b + y.b;
            return new Complexo(c1,c2);
        }

        public Complexo multiplica(Complexo x, Complexo y)
        {
            // COMPLEXO B, RICO EM VITAMINAS
            Complexo b = new Complexo((x.a*y.a - x.b*y.b),(x.a*y.b + y.a+x.b));
            return b;
        }

        public string toString()
        {
            return $"número: {this.a}+{this.b}i";
        }


    }
}