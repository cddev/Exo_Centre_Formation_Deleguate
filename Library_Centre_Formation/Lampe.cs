using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Centre_Formation
{
    public class Lampe:Composant
    {
        public override string IsComposantOnOff()
        {
            //base.NomComposant = this.ToString();
            return base.IsComposantOnOff();
        }
    }
}
