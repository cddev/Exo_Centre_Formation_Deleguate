using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Centre_Formation;

namespace Centre_Formation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Composant> LComposant = new List<Composant>();
            LComposant.Add(new Ventilateur());
            LComposant.Add(new Lampe());


            Interrupteur i1 = new Interrupteur("Legrand");
            Interrupteur i2 = new Interrupteur("Leroy");

            foreach (Composant c in LComposant)
            {
                i1.add(new SwitchOnOff(c.IsComposantOnOff));
                i2.add(new SwitchOnOff(c.IsComposantOnOff));
            }

            Console.WriteLine(i1.SetOnOff());
            Console.WriteLine(i2.SetOnOff());

            Console.WriteLine("Press quit ");
            Console.ReadKey();

        }
    }
}
