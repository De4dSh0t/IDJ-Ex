﻿using System;
using System.Collections.Generic;

namespace Ex_BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> ids = new List<string>();

            while (input != "End")
            {
                string[] words = input.Split(" ");

                if (words.Length == 3)
                {
                    IIdentifiable citizen = new Citizen(words[0], Int32.Parse(words[1]), words[2]);
                    ids.Add(citizen.Id);
                }
                else if(words.Length == 2)
                {
                    IIdentifiable robot = new Robot(words[0], words[1]);
                    ids.Add(robot.Id);
                }
                
                input = Console.ReadLine();
            }
            
            string fakeId = Console.ReadLine();

            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i].Contains(fakeId))
                {
                    Console.WriteLine(ids[i]);
                }
            }
        }
    }
}