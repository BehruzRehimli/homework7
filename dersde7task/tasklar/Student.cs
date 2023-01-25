using System;
using System.Collections.Generic;
using System.Text;

namespace tasklar
{
    internal class Student
    {
        public string FullName;
        public byte GroupN;
        public byte Point;

        public bool IsGraduated()
        {
            if (Point>=65)
            {
                return true;
            }
            return false;
        }
    }
}
