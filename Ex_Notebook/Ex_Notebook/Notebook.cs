using System;
using System.Reflection.Emit;

namespace Ex_Notebook
{
    public class Notebook
    {
        private Cpu cpu;
        private Ram ram;
        private Gpu gpu;
        private Disk disk;
        
        public Notebook()
        {
            cpu.Name = String.Empty;
            cpu.Model = String.Empty;
            cpu.ClockSpeed = 0;
            
            ram.Name = String.Empty;
            ram.Model = String.Empty;
            ram.Capacity = 0;
            
            gpu.Name = String.Empty;
            gpu.Model = String.Empty;
            gpu.ClockSpeed = 0;
            
            disk.Name = String.Empty;
            disk.Model = String.Empty;
            disk.Capacity = 0;
        }

        public Notebook(string nCpu, string mCpu, float sCpu, string nRam, string mRam, float cRam, string nGpu, string mGpu, float sGpu, string nDisk, string mDisk, float cDisk)
        {
            cpu.Name = nCpu;
            cpu.Model = mCpu;
            cpu.ClockSpeed = sCpu;

            ram.Name = nRam;
            ram.Model = mRam;
            ram.Capacity = cRam;

            gpu.Name = nGpu;
            gpu.Model = mGpu;
            gpu.ClockSpeed = sGpu;

            disk.Name = nDisk;
            disk.Model = mDisk;
            disk.Capacity = cDisk;
        }
    }
}