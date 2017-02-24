using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    interface IMyQueue<T>:IBuffer<T>
    {
        void Enqueue(T i);
        T Dequeue();
    }
}
