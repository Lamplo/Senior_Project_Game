using UnityEngine;

public enum SlotColor {
    Red, 
    Black,
    Green
}

public class WheelSlot
{
    public int number {get;  private set;}
    public SlotColor color {get; private set;}

    // Constructor
    public WheelSlot(int baseNumber, SlotColor baseColor)
    {
        number = baseNumber;
        color = baseColor;
    }
}
