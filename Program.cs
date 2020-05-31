using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace DriverApp
{
    //I thought about condensing my program outside of Main, but since it's small, I decided to 
    //leave it in one piece.
    class Program
    {

        public static void Main(string[] args)
        {

            string filePath = @"C:\Documents\drivers.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            Console.WriteLine("Driver");
            string driverName = Console.ReadLine();
            //extra space after name will throw an error without below if statement
            if (driverName == driverName + " " || driverName == driverName + "")
            {
                Console.WriteLine("Trip");
                string newLine = driverName + " " + (Console.ReadLine());
                lines.Add(newLine);
                File.WriteAllLines(filePath, lines);

            }

            foreach (var line in lines)
            {
                //splits line into multiple entries based on space between items
                string[] entries = line.Split(' ');
                {

                    Driver newDriver = new Driver();
                    newDriver.name = entries[0];
                    newDriver.startTime = entries[1];
                    newDriver.endTime = entries[2];
                    newDriver.start = Convert.ToDateTime(entries[1]);
                    newDriver.end = Convert.ToDateTime(entries[2]);
                    newDriver.miles = entries[3];
                    newDriver.interval = newDriver.end - newDriver.start;
                    newDriver.totalMiles = Convert.ToInt32(entries[3]);
                    newDriver.time = (newDriver.interval.TotalMinutes / 60);
                    newDriver.mph = Math.Ceiling(newDriver.totalMiles / newDriver.time);

                    //This block of code is to show that I know how to sort data. However, when sorting
                    //by a specified index becomes much more complicated. That's where I am stuck.
                    //string[] names = new string[]
                    //{
                    //    "Christine",
                    //    "Anna",
                    //    "Amy"
                    //};
                    //Array.Sort(names);
                    //foreach(string name in names)
                    //{
                    //    Console.WriteLine(name);
                    //}
                    //output is Amy, Anna, Christine - ordered ascending by default.


                    //ultimately, I was able to display the needed data, but was not able to sort it 
                    //per notes above.
                    bool isGreater = newDriver.mph > 5;
                    bool isLess = newDriver.mph < 100;

                    if (isGreater == true && isLess == true)
                    
                    {
                        Console.WriteLine($"{newDriver.name}: {newDriver.totalMiles} miles @ {newDriver.mph} mph");
                    }

                }


            }

            Console.ReadLine();
        }

    }
}
    









