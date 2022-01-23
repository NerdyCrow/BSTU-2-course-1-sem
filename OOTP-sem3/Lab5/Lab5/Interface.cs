using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IGeneric<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }

    public interface IPastry
    {
        void Print();
    }

    public interface ICloneable
    {
        object Clone();
        void Sort();
    }
}
