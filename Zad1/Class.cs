using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class Class
    {
        string Uuid;
        List<Student> Students { get; set; }
        List<Teacher> Teachers { get; set; }

        public Class(string uuid, List<Student> students, List<Teacher> teachers)
        {
            Uuid = uuid;
            Students = students;
            Teachers = teachers;
        }
    }
}
