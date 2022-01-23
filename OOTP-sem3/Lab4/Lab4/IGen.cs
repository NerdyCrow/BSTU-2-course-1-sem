using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    interface IGen<T>
    {

        void Add(T data);
        void RemoveInd(int ind);
        void Contains(char data);
    }
}
