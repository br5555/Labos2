namespace Labos2
{
    public class KompleksniBrojKlasa
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojKlasa(double realniDio, double imaginarniDio)
        {
            this.RealniDio = realniDio;
            this.ImaginarniDio = imaginarniDio;
        }

        public override string ToString()
        {
            string sign = ImaginarniDio < 0 ? "" : "+";
            return $"{RealniDio} {sign} {ImaginarniDio}i";
        }
    }
}