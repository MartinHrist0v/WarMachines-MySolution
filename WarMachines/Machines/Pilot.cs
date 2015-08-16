using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines
{
    public class Pilot : WarMachines.Interfaces.IPilot
    {
        private string name;
        private string report;
        private List<Interfaces.IMachine> machines = new List<Interfaces.IMachine>();
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name Can Not Be Empty or Null ");
                }
            }
        }

        public void AddMachine(Interfaces.IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            string info;
            if (this.machines.Count()>1)
	        {
		     info = string.Format("{0} - {1} machines",this.name,this.machines.Count());
	        }
            else if (this.machines.Count()==1)
	        {
		      info = string.Format("{0} - 1 machine", this.name);
	        }
            else
        	{
                info = string.Format("{0} - no machines", this.name);
	        }
            sb.AppendLine(info);
            foreach (var item in this.machines)
	        {
                sb.AppendLine(item.ToString());
	        }
            return sb.ToString();
        }
    }
}
