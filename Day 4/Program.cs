using System;

namespace Day_4
{
    public class Program
    {
        public static void Main(String[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.Add("hello", "merhaba");
            myDictionary.Add("world", "dünya");
        }
    }
}
