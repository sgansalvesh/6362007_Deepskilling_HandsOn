using System;

namespace BuilderPatternExample
{
    
    public class Computer
    {
        
        public string CPU { get; }
        public string RAM { get; }
        public string Storage { get; }
        public string GPU { get; }

        
        private Computer(Builder builder)
        {
            CPU = builder.CPU;
            RAM = builder.RAM;
            Storage = builder.Storage;
            GPU = builder.GPU;
        }

        
        public class Builder
        {
            public string CPU;
            public string RAM;
            public string Storage;
            public string GPU;

            public Builder SetCPU(string cpu)
            {
                CPU = cpu;
                return this;
            }

            public Builder SetRAM(string ram)
            {
                RAM = ram;
                return this;
            }

            public Builder SetStorage(string storage)
            {
                Storage = storage;
                return this;
            }

            public Builder SetGPU(string gpu)
            {
                GPU = gpu;
                return this;
            }

            public Computer Build()
            {
                return new Computer(this);
            }
        }

        public void DisplayConfig()
        {
            Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var gamingPC = new Computer.Builder()
                .SetCPU("Intel i9")
                .SetRAM("32GB")
                .SetStorage("1TB SSD")
                .SetGPU("NVIDIA RTX 4090")
                .Build();

            var officePC = new Computer.Builder()
                .SetCPU("Intel i5")
                .SetRAM("8GB")
                .SetStorage("512GB SSD")
                .Build(); // No GPU

            gamingPC.DisplayConfig();
            officePC.DisplayConfig();
        }
    }
}
