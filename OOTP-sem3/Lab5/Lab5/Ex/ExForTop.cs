using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Ex
{
    class ExForTop : Exception
    {
        public float Top { get; set; }

        public ExForTop(string message, float TopUp) : base(message)
        {
            this.Top = TopUp;
        }
    }
}
