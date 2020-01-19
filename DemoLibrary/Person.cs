using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Person: IPerson
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
    }
}
