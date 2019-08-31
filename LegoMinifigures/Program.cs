using System;
using LegoMinifigures.LegoClasses;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var dude = new BasicMinifigure("Larry", HeadDesign.BigGrin, BodyDesign.BlueShirt, LegDesign.BlackPants, HatDesign.BrownHair, PropDesign.Gun);
            var plant = new Brick(BrickType.Plant);
            dude.Break(plant);
            dude.Break(plant);
            Console.WriteLine(dude.TotalCoins);
            var bars = new Brick(BrickType.Bars);
            var ninja = new BasicMinifigure("David The Ninja", HeadDesign.Ninja, BodyDesign.Ninja, LegDesign.Ninja, HatDesign.Ninja, PropDesign.NinjaSword);
            ninja.Break(bars);
            ninja.Break(plant);
        }
    }
}
