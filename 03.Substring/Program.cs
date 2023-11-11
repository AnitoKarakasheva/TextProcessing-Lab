﻿using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////// Variant 1 ////////////////////////////////////////
            //string wordRemove = Console.ReadLine();
            //string text = Console.ReadLine();

            // while(text.Contains(wordRemove))
            // {
            //     int startIndexWordOfRemove = text.IndexOf(wordRemove);
            //     text = text.Remove(startIndexWordOfRemove, wordRemove.Length);

            // }
            // Console.WriteLine(text);


            ///////////////////////////////////////////////////////////////////////////// Variant 2 //////////////////////////////////////
            string wordRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(wordRemove))
            {
                text = text.Replace(wordRemove, "");

            }
            Console.WriteLine(text);


        }
    }
}
        
