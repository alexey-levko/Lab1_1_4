using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType

        enum ComputerType { Desktop, Laptop, Server };

        // 2) declare struct Computer

        struct Computer
        {
            public ComputerType EOMType;
            public int numberOfCPUCores;
            public int CPUClockRate;
            public int memorySize;
            public int HDDSize;
        }

        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)

            Computer[][] ComputersInOffice = new Computer[4][];

            // 4) set the size of every array in jagged array (number of computers)

            ComputersInOffice[0] = new Computer[5];
            ComputersInOffice[1] = new Computer[3];
            ComputersInOffice[2] = new Computer[5];
            ComputersInOffice[3] = new Computer[4];

            // 5) initialize array
            // Note: use loops and if-else statements

            /* another variant

            Computer DesktopConfiguration;
            DesktopConfiguration.EOMType = ComputerType.Desktop;
            DesktopConfiguration.numberOfCPUCores = 4;
            DesktopConfiguration.CPUClockRate = 2500;
            DesktopConfiguration.memorySize = 6;
            DesktopConfiguration.HDDSize = 500;

            Computer LaptopConfiguration;
            LaptopConfiguration.EOMType = ComputerType.Laptop;
            LaptopConfiguration.numberOfCPUCores = 2;
            LaptopConfiguration.CPUClockRate = 1700;
            LaptopConfiguration.memorySize = 4;
            LaptopConfiguration.HDDSize = 250;

            Computer ServerConfiguration;
            ServerConfiguration.EOMType = ComputerType.Server;
            ServerConfiguration.numberOfCPUCores = 8;
            ServerConfiguration.CPUClockRate = 3000;
            ServerConfiguration.memorySize = 16;
            ServerConfiguration.HDDSize = 2048;

            ComputersInOffice[0][0] = DesktopConfiguration;
            ComputersInOffice[0][1] = DesktopConfiguration;
            ComputersInOffice[0][2] = LaptopConfiguration;
            ComputersInOffice[0][3] = LaptopConfiguration;
            ComputersInOffice[0][4] = ServerConfiguration;

            ComputersInOffice[1][0] = LaptopConfiguration;
            ComputersInOffice[1][1] = LaptopConfiguration;
            ComputersInOffice[1][2] = LaptopConfiguration;

            ComputersInOffice[2][0] = DesktopConfiguration;
            ComputersInOffice[2][1] = DesktopConfiguration;
            ComputersInOffice[2][2] = DesktopConfiguration;
            ComputersInOffice[2][3] = LaptopConfiguration;
            ComputersInOffice[2][4] = LaptopConfiguration;

            ComputersInOffice[3][0] = DesktopConfiguration;
            ComputersInOffice[3][1] = LaptopConfiguration;
            ComputersInOffice[3][2] = ServerConfiguration;
            ComputersInOffice[3][3] = ServerConfiguration;
            */

            for (int depCount = 0; depCount < ComputersInOffice.Length; depCount++)
            {
                for (int compInDepCount = 0; compInDepCount < ComputersInOffice[depCount].Length; compInDepCount++)
                {
                    if (((depCount == 0) && (compInDepCount == 0 || compInDepCount == 1)) ||
                        ((depCount == 2) && (compInDepCount == 0 || compInDepCount == 1 || compInDepCount == 2)) ||
                        ((depCount == 3) && (compInDepCount == 0)))
                    {
                        ComputersInOffice[depCount][compInDepCount].EOMType = ComputerType.Desktop;
                        ComputersInOffice[depCount][compInDepCount].numberOfCPUCores = 4;
                        ComputersInOffice[depCount][compInDepCount].CPUClockRate = 2500;
                        ComputersInOffice[depCount][compInDepCount].memorySize = 6;
                        ComputersInOffice[depCount][compInDepCount].HDDSize = 500;
                    }
                    else
                    if (((depCount == 0) && (compInDepCount == 2 || compInDepCount == 3)) ||
                        ((depCount == 1)) ||
                        ((depCount == 2) && (compInDepCount == 3 || compInDepCount == 4)) ||
                        ((depCount == 3) && (compInDepCount == 1)))
                    {
                        ComputersInOffice[depCount][compInDepCount].EOMType = ComputerType.Laptop;
                        ComputersInOffice[depCount][compInDepCount].numberOfCPUCores = 2;
                        ComputersInOffice[depCount][compInDepCount].CPUClockRate = 1700;
                        ComputersInOffice[depCount][compInDepCount].memorySize = 4;
                        ComputersInOffice[depCount][compInDepCount].HDDSize = 250;
                    }
                    else
                    {
                        ComputersInOffice[depCount][compInDepCount].EOMType = ComputerType.Server;
                        ComputersInOffice[depCount][compInDepCount].numberOfCPUCores = 8;
                        ComputersInOffice[depCount][compInDepCount].CPUClockRate = 3000;
                        ComputersInOffice[depCount][compInDepCount].memorySize = 16;
                        ComputersInOffice[depCount][compInDepCount].HDDSize = 2048;
                    }
                }
            }

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            int desktopTotalNumber=0, laptopTotalNumber=0, serverTotalNumber=0;
            int allTotalNumber = 0;
            
            for (int depCount = 0; depCount < ComputersInOffice.Length; depCount++)
            {
                for (int compInDepCount = 0; compInDepCount < ComputersInOffice[depCount].Length; compInDepCount++)
                {
                    allTotalNumber++;

                    switch (ComputersInOffice[depCount][compInDepCount].EOMType)
                    {
                        case ComputerType.Desktop:
                            desktopTotalNumber++;
                            break;
                        case ComputerType.Laptop:
                            laptopTotalNumber++;
                            break;
                        case ComputerType.Server:
                            serverTotalNumber++;
                            break;
                    }
                }
            }

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            int largestHDDDep = 0;
            int largestHDDComp = 0;
            int largestHDDSize = ComputersInOffice[0][0].HDDSize;

            for (int depCount = 0; depCount < ComputersInOffice.Length; depCount++)
            {
                for (int compInDepCount = 0; compInDepCount < ComputersInOffice[depCount].Length; compInDepCount++)
                {
                    if (ComputersInOffice[depCount][compInDepCount].HDDSize>largestHDDSize)
                    {
                        largestHDDDep = depCount;
                        largestHDDComp = compInDepCount;
                        largestHDDSize = ComputersInOffice[depCount][compInDepCount].HDDSize;
                    }
                }
            }

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            int lowestPCDep = 0;
            int lowestPCInd = 0;
            int lowestCPU = ComputersInOffice[0][0].numberOfCPUCores;
            int lowestMemory = ComputersInOffice[0][0].memorySize;

            for (int depCount = 0; depCount < ComputersInOffice.Length; depCount++)
            {
                for (int compInDepCount = 0; compInDepCount < ComputersInOffice[depCount].Length; compInDepCount++)
                {
                    if ( (ComputersInOffice[depCount][compInDepCount].numberOfCPUCores < lowestCPU) &&
                         (ComputersInOffice[depCount][compInDepCount].memorySize < lowestMemory) )
                    {
                        lowestPCDep = depCount;
                        lowestPCInd = compInDepCount;
                        lowestCPU = ComputersInOffice[depCount][compInDepCount].numberOfCPUCores;
                        lowestMemory = ComputersInOffice[depCount][compInDepCount].memorySize;
                    }
                }
            }

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

            for (int depCount = 0; depCount < ComputersInOffice.Length; depCount++)
            {
                for (int compInDepCount = 0; compInDepCount < ComputersInOffice[depCount].Length; compInDepCount++)
                {
                    if (ComputersInOffice[depCount][compInDepCount].EOMType == ComputerType.Desktop)
                    {
                        ComputersInOffice[depCount][compInDepCount].memorySize = 8;
                    }
                }
            }

        }
    }
}
