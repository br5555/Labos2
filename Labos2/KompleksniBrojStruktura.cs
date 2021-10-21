namespace Labos2
{
    public struct KompleksniBrojStruktura
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBrojStruktura(double realniDio, double imaginarniDio)
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