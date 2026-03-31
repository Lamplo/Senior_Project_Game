using UnityEngine;

public enum SlotColor {
    Red, 
    Black
}

public class WheelSlot
{
    public int _number {get;  private set;}
    public SlotColor _color {get; private set;}

    // Constructor
    public WheelSlot(int baseNumber, SlotColor baseColor)
    {
        _number = baseNumber;
        _color = baseColor;
    }
}
