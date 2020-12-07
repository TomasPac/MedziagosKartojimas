namespace MedziagosKartojimas
{
    abstract class BaseClass
    {
        private readonly string name;

        public BaseClass(string Name)
        {
            name = Name;
        }
        public abstract string NameMetodas();

        public abstract int NameMetodas(int a);
    }
}
