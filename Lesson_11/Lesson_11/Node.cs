﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }

    }
}
