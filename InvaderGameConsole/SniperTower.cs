using System;
namespace InvaderGameConsole
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;
        protected override Double Accuracy { get; } = 1.0;

        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}
