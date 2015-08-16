using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines
{
    public class Fighter : Machine, WarMachines.Interfaces.IFighter
    {
        private bool stealthMode;
        public bool StealthMode
        {
            get { return this.stealthMode; }
            set { this.stealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            if (stealthMode)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
            }
        }
        //override public double HealthPoints
        //{
        //    get
        //    {
        //        return this.healthPoints ;
        //    }
        //    set
        //    {
        //        base.HealthPoints = 200;
        //    }
        //}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string result = string.Format(" *Stealth: {0}",StealthMode? "ON": "OFF");
            sb.AppendLine(base.ToString()).Append(result);
            return sb.ToString();
        }
    }
}
