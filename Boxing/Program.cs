using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing has performance penalty

            var list = new ArrayList();
            list.Add(1); //boxing happens
            list.Add("yeasin");
            list.Add(DateTime.Now); //boxing happens

            //use generic type of list if u dont want boxing to happen

            var anotherList = new List<int>();
            anotherList.Add(1); // no boxing
        }
    }
}
