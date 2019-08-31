using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.LegoClasses
{
    enum HeadDesign
    {
        Basic,
        BigGrin,
        Sad,
        Evil,
        Old,
        Ninja,
        Skeleton
    }

    enum BodyDesign
    {
        RedShirt,
        BlueShirt,
        Ninja,
        Skeleton
    }

    enum LegDesign
    {
        BlackPants,
        WhitePants,
        ShortLegs,
        Ninja,
        Skeleton
    }

    enum HatDesign
    {
        Nothing,
        BrownHair,
        GreyHair,
        PirateHat,
        BlueHat,
        BananaSuit,
        Ninja
    }

    enum PropDesign
    {
        Nothing,
        Book,
        NinjaSword,
        Gun,
        WateringCan,
        MagnifyingGlass,
        Cape
    }
    class BasicMinifigure
    {
        public string Name { get; set; }
        public HeadDesign Head { get; set; }
        public BodyDesign Body { get; set; }
        public LegDesign Legs { get; set; }
        public HatDesign Hat { get; set; }
        public PropDesign Prop { get; set; }

        Brick _brickToBreak;

        public int TotalCoins { get; private set; }

        int _hitStrength = 1;

        public BasicMinifigure(string name, HeadDesign head, BodyDesign body, LegDesign legs, HatDesign hat, PropDesign prop)
        {
            Name = name;
            Head = head;
            Body = body;
            Legs = legs;
            Hat = hat;
            Prop = prop;
            if (Head == HeadDesign.Ninja && Body == BodyDesign.Ninja && Legs == LegDesign.Ninja && Hat == HatDesign.Ninja && Prop == PropDesign.NinjaSword)
            {
                Console.WriteLine("CONGRATS ON BEING A NINJA");
                Console.WriteLine("Your strength has increased!");
                _hitStrength = 2;
            }
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is walking around");
        }

        public void Break(Brick brickToBreak)
        {
            _brickToBreak = brickToBreak;
            _brickToBreak.Strength -= _hitStrength;
            if (_brickToBreak.Strength > 0)
            {
                Console.WriteLine($"{Name} hit a {_brickToBreak._brickStyle.ToString().ToLower()} but it just bounces, maybe hit it again?");
            }
            else
            {
                Console.WriteLine($"{Name} broke the fuck outta that {_brickToBreak._brickStyle.ToString().ToLower()}");
                Console.WriteLine($"{Name} gets {_brickToBreak.CoinAmount} coins!");
                TotalCoins += _brickToBreak.CoinAmount;
            }
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jumped!");
        }
    }
}
