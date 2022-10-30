using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Group
    {
        List<Students> _groupList = new List<Students>(); 
        public void Add(Students student)
        {
            _groupList.Add(student);

        }

        public void PrintGroup()
        {
            for (int i = 0; i < _groupList.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + _groupList[i].Name + "\t" + _groupList[i].Age);
            }

        }

    }
}