using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Centre_Formation
{
    public class Composant
    {
        public bool IsOnOff { get; set; }
        public string NomComposant { get; set; }

        public Composant()
        {
            this.IsOnOff = false;
        }
        public Composant(string nom)
        {
            
            this.IsOnOff = false;
            this.NomComposant = nom;
        }

        public virtual string IsComposantOnOff()
        {
            //if (!this.IsOnOff)
            //{
            //    this.IsOnOff = true;
                return this.ToString();
            //}
            //else
            //{
                //this.IsOnOff = false;
                //return this.NomComposant + " est eteint ";
            //}
            
        }
    }
}
