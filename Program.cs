
namespace BasicKalıtım
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Canli canli1 = new Canli(10, 30);
            Canli canli2 = new Kedi("Van", 20, 10);
            Kedi kedi1 = new Kedi("Van", 5, 10);
            Koyun koyun1 = new Koyun("Ankara", 50, 65);

            canli1 = kedi1;
            canli1.Konus();

            canli1 = koyun1;
            canli1.Konus();

            canli2.Konus();

        }
    }
}
