using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    interface IMyStack<T>: IBuffer<T>
    {
        void Push(T i);
        T Pop();
    }
}
