using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class WrongIndexException:Exception
    {
        public WrongIndexException(string message) : base(message) => Console.WriteLine(message);

    }
}
