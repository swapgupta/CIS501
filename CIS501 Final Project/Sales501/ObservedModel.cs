using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    public abstract class ObservedModel
    {
        private List<Observer> registry = new List<Observer>();
        public string Error { get; set; }

        public void register(Observer x)
        {
            registry.Add(x);
        }

        public void notify()
        {
            foreach (Observer x in registry)
            {
                x();
            }
        }
    }
}
