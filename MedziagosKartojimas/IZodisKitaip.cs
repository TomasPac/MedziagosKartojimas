using System.Text;

namespace MedziagosKartojimas
{
    public interface IZodisKitaip
    {
        public string ZodisBeBalsiu();
        public string ZodisBePriebalsiu();
        public string ZodisSuPakeistomisBalsemis(char ch);
        public string ZodisSuPakeistomisPriebalsemis(int a);
    }
}
