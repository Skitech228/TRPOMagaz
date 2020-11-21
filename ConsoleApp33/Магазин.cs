using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Магазин
    {
        public int bonus =100;
        public int ZP(Продавец_консультант a)
        {
            return a.KolTovar * bonus;
        }
        public int Vir(List<Продавец_консультант> a)
        {
            int Viry=0;
            foreach (var item in a)
            {
                Viry += item.KolTovar * bonus;
            }
            Console.WriteLine(Viry);
            return Viry;
        }
        public void Prod(List<Товар> a, string nazv, Продавец_консультант prod)
        {
            int num=0;
            foreach (var item in a)
            {
                if (item.TovarName == nazv)
                {
                    prod.KolTovar++;
                    break;
                }
                num++;
            }
            a.Remove(a[num]);
            Console.WriteLine();
            Console.WriteLine("Продано");
            Console.WriteLine();
        }
        public void Add(List<Товар> a, string nazv)
        {
            Товар tov = new Товар(nazv);
            a.Add(tov);
            Console.WriteLine();
            Console.WriteLine("Добавлено");
            Console.WriteLine();
        }
    }
}
