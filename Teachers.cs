using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Midterm_2131419
{
    class Teachers : CollectionBase
    {
        public void add(Teacher teacher)
        {
            List.Add(teacher);
        }
        public Teacher this[int index]
        {
            get
            {
                return (Teacher)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
