using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines
{
    public class Tank : Machine, WarMachines.Interfaces.ITank
    {
        
        private bool defenseMode=true;
        public bool DefenseMode
        {
            get
            {
                return defenseMode; 
            }
            set
            {
                this.defenseMode = value;
            }
            //set
            //{
            //    if (defenceMode)
            //    {
            //        DefensePoints += 30;
            //        AttackPoints -= 40;
            //    }
            //}
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                DefensePoints -=30;
                AttackPoints +=40;
                defenseMode = false;
            }
            else
            {
                DefensePoints += 30;
                AttackPoints -= 40;
                defenseMode = true;
            }
        }
        //public override double HealthPoints
        //{
        //    get
        //    {
        //        return this.healthPoints;
        //    }
        //    set
        //    {
        //        if (DefenseMode)
        //        {
        //            base.HealthPoints = 130;
        //            base.AttackPoints = 60;
        //        }
        //        else
        //        {
        //            base.healthPoints = 100;
        //            base.AttackPoints = 100;
        //        }
        //    }
        //}
        public override string ToString()
        {

            string result = string.Format("* Defense: {0}",DefenseMode? "ON" :"OFF");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).Append(result);
            return sb.ToString();
        }
    }
}
