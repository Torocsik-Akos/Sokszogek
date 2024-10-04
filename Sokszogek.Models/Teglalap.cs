namespace Sokszogek.Models
{
    public abstract class Teglalap
    {
        public double OldalA { get; set; }
        public abstract double Kerulet();
        public abstract double Terulet();

        protected Teglalap(double oldalA)
        {
            OldalA = oldalA;
        }
    }
}
