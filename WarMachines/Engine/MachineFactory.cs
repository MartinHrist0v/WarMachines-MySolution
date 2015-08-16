namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    //using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            // TODO: Implement this method
            return new Pilot() { Name = name };
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            // TODO: Implement this method
            return new Tank() { Name = name, AttackPoints = attackPoints-40, DefensePoints = 30+defensePoints, HealthPoints =100 ,DefenseMode =true,};
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            // TODO: Implement this method
            return new Fighter() { Name = name, AttackPoints = attackPoints, DefensePoints = defensePoints, StealthMode = stealthMode, HealthPoints =200 };
        }
    }
}
