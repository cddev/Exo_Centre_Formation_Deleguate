using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Centre_Formation
{

    public delegate string SwitchOnOff();

    public class Interrupteur
    {
        private List<SwitchOnOff> listSwitchs;
        public string NomInterupteur { get; set; }

        public Interrupteur()
        {
            listSwitchs = new List<SwitchOnOff>();
        }
        public Interrupteur(string nom)
        {
            listSwitchs = new List<SwitchOnOff>();
            this.NomInterupteur = nom;

        }
        public void add(SwitchOnOff sw)
        {
            listSwitchs.Add(sw);
        }
        public string SetOnOff()
        {
            string _ret = "L'interupteur " + this.NomInterupteur;
            foreach (SwitchOnOff sw in listSwitchs)
            {
                _ret += " allume "+ sw() + "\n";
            }
            return _ret;

        }

    }
}
