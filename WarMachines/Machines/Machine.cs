using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines
{
    public class Machine : WarMachines.Interfaces.IMachine
    {
        private string name;
        private Pilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defencePoins;
        private IList<string> targets = new List<string>();
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

        public Interfaces.IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value is WarMachines.Pilot)
                {
                    pilot = (WarMachines.Pilot)value;
                }
                else
                {
                    throw new ArgumentException("Invalid Pilot"); 
                }
            }
        }

        public  double HealthPoints { 
            get
            {
                return this.healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }//different for tanks and fighters 


        public double AttackPoints
        {
            get { return this.attackPoints; }
            set {this.attackPoints = value;}
        }

        public double DefensePoints
        {
            get { return this.defencePoins; }
            set { defencePoins = value; }
        }

        public IList<string> Targets
        {
           get { return this.targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
            
        }
        public override string ToString()
        {
            string result = string.Format("- {0}\n *Type: {1}\n *Health: {2}\n *Attack: {3}\n *Defense: {4}\n *Targets: {5}",
                this.name, this.GetType(), this.HealthPoints, this.attackPoints, this.DefensePoints, 
                this.Targets.Count() != 0 ? string.Join(", ", Targets) : "None");
            return result;
        }
    }
}
