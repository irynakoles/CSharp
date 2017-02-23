using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    interface IBuffer<T>: IPrintable
    {
        void IsEmpty();
        void IsFull();
        void Peek();

    }
}
