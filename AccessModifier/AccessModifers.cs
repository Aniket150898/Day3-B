using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class AccessModifers //This is Internal Access Modifier,The code is only accessible within its own assembly,
                                  //but not from another assembly.
    {
        private string name = "Aniket"; //This is Private Access Modifier which one access within Class.
                                        //Outside of Class we cannot access.
        public string name1 = "SKY";//This is public Access Modifier

    }
}
