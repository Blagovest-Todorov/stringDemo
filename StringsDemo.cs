namespace _01.strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    class StringsDemo
    {
        string s =
                "Stand up, stan up Balkan superman.";
            //Console.WriteLine("s = \"{0}\"", s);
            //Console.WriteLine("s.Length = {0}", s.Length);
            for (int i = 0; i<s.Length  ; i++)
            {
                Console.WriteLine("index s[{0}] = valueof index:  !{1}!,", i , s[i]);
            }
}
}
