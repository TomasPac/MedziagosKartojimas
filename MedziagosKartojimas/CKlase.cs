namespace MedziagosKartojimas
{
    public class CKlase : BKlase
    {

        public int Skaicius { get; set; }
        public string Zodis { get; set; }
        public double DoubleSkaicius { get; set; }
        public AKlase AObjektas { get; set; }
        public CKlase() 
        {

        }
        public CKlase(int skaicius)
        {
            Skaicius = skaicius;
        }
        public CKlase(int skaicius, string zodis) :this(skaicius)
        {
            Zodis = zodis;
        }
        public CKlase(int skaicius, string zodis, AKlase aObjektas) : this(skaicius, zodis)
        {
            AObjektas = aObjektas;
        }
    }
}
