using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    abstract class Buffer
    {   
        // Will be override for stack and queue 
        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract void Print();

    }
}
