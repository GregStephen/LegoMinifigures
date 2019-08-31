using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.LegoClasses
{
    enum BrickType
    {
        Standard,
        Plant,
        Bucket,
        Bars,
        Wheel,
        Glass,
        Dog,
        Cat
    }
    class Brick
    {
        public BrickType _brickStyle { get; private set; }
        public int Strength { get; set; }
        public int CoinAmount { get; }
        public Brick(BrickType brick)
        {
            _brickStyle = brick;
            if (_brickStyle == BrickType.Dog || _brickStyle == BrickType.Cat || _brickStyle == BrickType.Plant)
            {
                Strength = 2;
                CoinAmount = 10;
            }
            else if (_brickStyle == BrickType.Bars)
            {
                Strength = 3;
                CoinAmount = 5;
            }
            else
            {
                Strength = 1;
                CoinAmount = 3;
            }
        }
    }
}
