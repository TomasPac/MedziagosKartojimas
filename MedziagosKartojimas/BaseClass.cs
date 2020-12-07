namespace MedziagosKartojimas
{
    abstract class BaseClass
    {

        public BaseClass(string Name)
        {
            name = Name;
        }
        public string name { get; }

        public abstract string NameMetodas();

        public abstract int NameMetodas(int a);
    }
}
