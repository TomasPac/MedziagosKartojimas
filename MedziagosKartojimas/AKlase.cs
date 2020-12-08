using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedziagosKartojimas
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {

        }
        List<char> balses = new List<char> { 'a', 'e', 'i', 'o', 'u' };

        public override string NameMetodas()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in Name)
            {
                sb.Append(balses.Contains(letter) ? Convert.ToInt32(letter) : letter);
            }
            return sb.ToString();
        }

        public override int NameMetodas(int a)
        {
            int res = 0;
            foreach (var letter in Name)
            {
                res += Convert.ToInt32(letter) * 2;
            }
            return res;
        }
    }
}
