using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        ILogger _logger;
        public Chore(ILogger logger)
        {
            _logger = logger;
        }

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }

        public void PerformWork(double hours)
        {
            _logger.Log($"The chor owner is {Owner.Name} {Owner.SecondName}.");
            _logger.Log($"{ChoreName} chor is being performed...");
        }

        public void CompletemChore()
        {            
            _logger.Log($"{ChoreName} chore is completed.");
        }
    }
}
