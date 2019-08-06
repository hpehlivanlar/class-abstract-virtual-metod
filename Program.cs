using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstract_virtual_metot
{
    class Program
    {

        //Virtul metot( sanal metotlar)  ,base class(temel sınıf) içinde bildirimiş vede ondan türtilmiş clas içinde de tekrar türetilebilen metotlardar. Polimophizm(çok biçimlilik)


        static void Main(string[] args)
        {

            Para para = new Para();

            Para parayeni = para;

            parayeni.ParaCek(5,3);


            Havale havale = new Havale();
            parayeni = havale;

            parayeni.ParaCek(56,56);

            Eft eft = new Eft();
            parayeni = eft;
            parayeni.ParaCek(56,65);

            Console.ReadKey();


        }
    }

    class Para
    {

        public virtual void ParaCek(double a,double b)
        {
            Console.WriteLine("para yatrıma işlemi"+(a+b));
            
        }


    }

    class Havale : Para
    {

        public override void ParaCek(double a, double b)
        {

            //base.ParaCek(a,b);

            Console.WriteLine("havale ile para yatırma"+( a + b));
        }


    }


    class Eft : Para
    {
        public override void ParaCek(double a, double b)
        {

            //base.ParaCek(a,b);

            Console.WriteLine("eft  ile para yatırıldı"+(a + b));
        }
    }




}
