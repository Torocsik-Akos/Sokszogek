namespace Sokszogek.Models
{
    public class Negyzet : Teglalap
    {
        public Negyzet(double oldalA) : base(oldalA)
        {
            OldalA = 4;
        }

        public override double Kerulet()
        {
            return 4 * OldalA;
        }

        public override double Terulet()
        {
            return OldalA * OldalA;
        }
    }
}
