using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Network
    {
        private List<Computer> computers = new List<Computer>();

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void RemoveComputer(Computer computer)
        {
            computers.Remove(computer);
        }

        public void SimulateNetwork()
        {
            if (computers.Count < 2)
            {
                Console.WriteLine("The network needs at least two computers to operate.");
                return;
            }

            Random random = new Random();

            for (int i = 0; i < computers.Count; i++)
            {
                int targetIndex = random.Next(computers.Count);
                Computer sourceComputer = computers[i];
                Computer targetComputer = computers[targetIndex];

                if (sourceComputer != targetComputer)
                {
                    IConnectable sourceConnectable = sourceComputer as IConnectable;
                    sourceConnectable?.TransmitData("Sample data", targetComputer);
                }
            }
        }
    }
}
