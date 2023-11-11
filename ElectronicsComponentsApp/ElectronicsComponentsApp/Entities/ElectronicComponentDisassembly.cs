using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsComponentsApp.Entities
{
    public class ElectronicComponentDisassembly : ElectronicComponent
    {
        public override string ToString() => base.ToString() + " (Demontaż)";
    }
}
