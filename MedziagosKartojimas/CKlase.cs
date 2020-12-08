namespace MedziagosKartojimas
{
    public class CKlase : BKlase
    {

        public int Skaicius { get; set; }
        public string Zodis { get; set; }
        public double DoubleSkaicius { get; set; }
        public AKlase AObjektas { get; set; }
        public CKlase(string name) : base(name)
        {

        }
        public CKlase(string name, int skaicius) :base(name)
        {
            Skaicius = skaicius;
        }
        public CKlase(string name, int skaicius, string zodis) : base(name)
        {
            Skaicius = skaicius;
            Zodis = zodis;
        }
        public CKlase(string name, int skaicius, string zodis, AKlase aObjektas) : base(name)
        {
            Skaicius = skaicius;
            Zodis = zodis;
            AObjektas = aObjektas;
        }
    }
}
