using System;
using System.Collections.Generic;
using System.Text;

namespace Controsha
{
   public interface IEvent
    {
        void Click()
        {
            Console.WriteLine("..........");
        }
    }
  public  interface IAction
    {
        void Click()
        {
            Console.WriteLine("*******");
        }
    }
}
