using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicKalıtım
{
    internal class Canli
    {
        public double boy;
        public double agirlik;
        

        public Canli(double boy, double agirlik)
        {
            this.boy = boy;
            this.agirlik = agirlik;
        }

        public virtual void Konus()
        {
            Console.WriteLine("Ben konusamam!!!");
        }
    }

    class Kedi: Canli
    {
        public string tur;
        public Kedi(string tur, int boy, int agirlik): base(boy, agirlik)
        //base: ile yukarıda tanımlanan double boy ve agirlik'i alıyor(boy ve ağırlıgı kalıtıldıgı sınıftan alıyor)
        {
            this.tur = tur;
        }   

        public override void Konus()
        {
            Console.WriteLine("Ben bir kediyim.");    
        }
    }

    class Koyun: Canli
    {
        public string tur;
        
        public Koyun(string tur, int boy, int agirlik) : base(boy, agirlik)
        {
            this.tur = tur;
        }

        public override void Konus()
        {
            base.Konus();
            //base.konus dediğimizde kalıtım aldıgı sınıftaki konus fonksiyonuna gider ve "Ben konusamam!!!" yazar
        }
    }




}
