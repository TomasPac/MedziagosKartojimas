namespace MedziagosKartojimas
{
    public abstract class BaseClass
    {

        public BaseClass(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public abstract string NameMetodas();

        public abstract int NameMetodas(int a);
    }
}
