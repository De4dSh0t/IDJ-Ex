using System;

namespace Ex_Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Notebook n1 = new Notebook("Intel", "i5-8300h", 2.30, "Samsung", "K4AAG085WC", 16, "Nvidia", "GTX 1050Ti", 1291, "Samsung", "PM961", 256);
            // Notebook n2 = new Notebook("AMD", "Ryzen 7 3700X", 3.60, "HyperX", "Fury", 8, "Radeon", "RX570 OC", 1268, "Samsung", "PM961", 256);
            //
            // Console.WriteLine(n1.ToString());
            // Console.WriteLine($"Is cpu1 greater than cpu2? { n1.CompareCpu(n1, n2) }");
            // Console.WriteLine($"Is ram1 greater than ram2? { n1.CompareMemory(n1, n2) }");
            
            bool flag = false;
            string nCpu, mCpu, nRam, mRam, nGpu, mGpu, nDisk, mDisk;
            double sCpu;
            int cRam, sGpu, cDisk;

            Console.WriteLine("-------- Compare Notebook --------");
            Console.WriteLine("CPU Brand: ");
            nCpu = Console.ReadLine();
            Console.WriteLine("CPU Model: ");
            mCpu = Console.ReadLine();
            Console.WriteLine("CPU Clock Speed: ");
            sCpu = double.Parse(Console.ReadLine());
            Console.WriteLine("RAM Brand: ");
            nRam = Console.ReadLine();
            Console.WriteLine("RAM Model: ");
            mRam = Console.ReadLine();
            Console.WriteLine("RAM Capacity: ");
            cRam = Int32.Parse(Console.ReadLine());
            Console.WriteLine("GPU Brand: ");
            nGpu = Console.ReadLine();
            Console.WriteLine("GPU Model: ");
            mGpu = Console.ReadLine();
            Console.WriteLine("GPU Clock Speed: ");
            sGpu = Int32.Parse(Console.ReadLine());
            Console.WriteLine("DISK Brand: ");
            nDisk = Console.ReadLine();
            Console.WriteLine("DISK Model: ");
            mDisk = Console.ReadLine();
            Console.WriteLine("DISK Capacity: ");
            cDisk = Int32.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            
            Notebook n1 = new Notebook(nCpu, mCpu, sCpu, nRam, mRam, cRam, nGpu, mGpu, sGpu, nDisk, mDisk, cDisk);

            while (!flag)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                
                Console.WriteLine("");
                Console.WriteLine("/////////////////////////");
                Console.WriteLine("(1) ToString");
                Console.WriteLine("(2) CompareMemory");
                Console.WriteLine("(3) CompareCpu");
                Console.WriteLine("(0) Exit");
                Console.WriteLine("/////////////////////////");
                Console.WriteLine("");

                if (info.KeyChar == '1')
                {
                    Console.WriteLine(n1.ToString());
                }

                if (info.KeyChar == '2')
                {
                    Console.WriteLine("-------- Notebook 2 --------");
                    Console.WriteLine("CPU Brand: ");
                    nCpu = Console.ReadLine();
                    Console.WriteLine("CPU Model: ");
                    mCpu = Console.ReadLine();
                    Console.WriteLine("CPU Clock Speed: ");
                    sCpu = double.Parse(Console.ReadLine());
                    Console.WriteLine("RAM Brand: ");
                    nRam = Console.ReadLine();
                    Console.WriteLine("RAM Model: ");
                    mRam = Console.ReadLine();
                    Console.WriteLine("RAM Capacity: ");
                    cRam = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("GPU Brand: ");
                    nGpu = Console.ReadLine();
                    Console.WriteLine("GPU Model: ");
                    mGpu = Console.ReadLine();
                    Console.WriteLine("GPU Clock Speed: ");
                    sGpu = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("DISK Brand: ");
                    nDisk = Console.ReadLine();
                    Console.WriteLine("DISK Model: ");
                    mDisk = Console.ReadLine();
                    Console.WriteLine("DISK Capacity: ");
                    cDisk = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    Notebook n2 = new Notebook(nCpu, mCpu, sCpu, nRam, mRam, cRam, nGpu, mGpu, sGpu, nDisk, mDisk, cDisk);

                    if (n1.CompareMemory(n1, n2) == 1)
                    {
                        Console.WriteLine("The first notebook has gratter memory capacity than the second.");
                    }
                    else if(n1.CompareMemory(n1, n2) == -1)
                    {
                        Console.WriteLine("The second notebook has gratter memory capacity than the first.");
                    }
                    else if (n1.CompareMemory(n1, n2) == 0)
                    {
                        Console.WriteLine("Both notebooks have the same memory capacity!");
                    }
                }

                if (info.KeyChar == '3')
                {
                    Console.WriteLine("-------- Notebook 2 --------");
                    Console.WriteLine("CPU Brand: ");
                    nCpu = Console.ReadLine();
                    Console.WriteLine("CPU Model: ");
                    mCpu = Console.ReadLine();
                    Console.WriteLine("CPU Clock Speed: ");
                    sCpu = double.Parse(Console.ReadLine());
                    Console.WriteLine("RAM Brand: ");
                    nRam = Console.ReadLine();
                    Console.WriteLine("RAM Model: ");
                    mRam = Console.ReadLine();
                    Console.WriteLine("RAM Capacity: ");
                    cRam = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("GPU Brand: ");
                    nGpu = Console.ReadLine();
                    Console.WriteLine("GPU Model: ");
                    mGpu = Console.ReadLine();
                    Console.WriteLine("GPU Clock Speed: ");
                    sGpu = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("DISK Brand: ");
                    nDisk = Console.ReadLine();
                    Console.WriteLine("DISK Model: ");
                    mDisk = Console.ReadLine();
                    Console.WriteLine("DISK Capacity: ");
                    cDisk = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------");
                    
                    Notebook n2 = new Notebook(nCpu, mCpu, sCpu, nRam, mRam, cRam, nGpu, mGpu, sGpu, nDisk, mDisk, cDisk);
                    
                    if (n1.CompareCpu(n1, n2) == 1)
                    {
                        Console.WriteLine("The first cpu has a better clock speed than the second.");
                    }
                    else if(n1.CompareCpu(n1, n2) == -1)
                    {
                        Console.WriteLine("The second cpu has a better clock speed than th first.");
                    }
                    else if (n1.CompareCpu(n1, n2) == 0)
                    {
                        Console.WriteLine("Both cpu's have the same clock speed!");
                    }
                }

                if (info.KeyChar == '0')
                {
                    flag = !flag;
                }
            }
        }
    }
}