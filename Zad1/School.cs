using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class School
    {
        List<Class> Classes { get; set; }

        public School(List<Class> classes)
        {
            Classes = classes;
        }
    }
}
