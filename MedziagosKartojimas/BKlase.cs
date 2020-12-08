using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
    public class BKlase : AKlase, IZodisKitaip
    {
        public BKlase(string name) : base(name)
        {

        }
        public BKlase()
        {

        }
        public List<char> Balses = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        public override string NameMetodas()
        {
            throw new NotImplementedException();
        }

        public override int NameMetodas(int a)
        {
            int res = 0;
            foreach (var letter in Name)
            {
                res += Convert.ToInt32(letter) - a;
            }
            return res;
        }

        public string ZodisBeBalsiu()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in Name)
            {
                if (Balses.Contains(letter)) sb.Append(letter);
            }
            return sb.ToString();
        }

        public string ZodisBePriebalsiu()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in Name)
            {
                if (!Balses.Contains(letter)) sb.Append(letter);
            }

            return sb.ToString();
        }

        public string ZodisSuPakeistomisBalsemis(char ch)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in Name)
            {
                sb.Append(Balses.Contains(letter) ? ch : letter);
            }
            return sb.ToString();
        }

        public string ZodisSuPakeistomisPriebalsemis(int a)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in Name)
            {
                sb.Append(Balses.Contains(letter) ? letter.ToString() : a.ToString());
            }
            return sb.ToString();
        }
    }
}
