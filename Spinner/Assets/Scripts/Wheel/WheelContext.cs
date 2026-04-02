using UnityEngine;
using System.Collections.Generic;

public class WheelContext
{
    public List<WheelSlot> slots {get; private set;}

    // Constructor
    public WheelContext()
    {
        Initialize(); 
    }

    // Create all the wheel slots and add them to the list
    private void Initialize()
    {
        slots = new List<WheelSlot>
        {
            new WheelSlot(0, SlotColor.Green),
            
            new WheelSlot(1, SlotColor.Red),
            new WheelSlot(2, SlotColor.Black),
            new WheelSlot(3, SlotColor.Red),
            new WheelSlot(4, SlotColor.Black),
            new WheelSlot(5, SlotColor.Red),
            new WheelSlot(6, SlotColor.Black),
            new WheelSlot(7, SlotColor.Red),
            new WheelSlot(8, SlotColor.Black),
            new WheelSlot(9, SlotColor.Red),

            new WheelSlot(10, SlotColor.Black),
            new WheelSlot(11, SlotColor.Red),
            new WheelSlot(12, SlotColor.Black),
            new WheelSlot(13, SlotColor.Red),
            new WheelSlot(14, SlotColor.Black),
            new WheelSlot(15, SlotColor.Red),
            new WheelSlot(16, SlotColor.Black),
            new WheelSlot(17, SlotColor.Red),
            new WheelSlot(18, SlotColor.Black),

            new WheelSlot(19, SlotColor.Red),
            new WheelSlot(20, SlotColor.Black),
            new WheelSlot(21, SlotColor.Red),
            new WheelSlot(22, SlotColor.Black),
            new WheelSlot(23, SlotColor.Red),
            new WheelSlot(24, SlotColor.Black),
            new WheelSlot(25, SlotColor.Red),
            new WheelSlot(26, SlotColor.Black),
            new WheelSlot(27, SlotColor.Red),

            new WheelSlot(28, SlotColor.Black),
            new WheelSlot(29, SlotColor.Red),
            new WheelSlot(30, SlotColor.Black),
            new WheelSlot(31, SlotColor.Red),
            new WheelSlot(32, SlotColor.Black),
            new WheelSlot(33, SlotColor.Red),
            new WheelSlot(34, SlotColor.Black),
            new WheelSlot(35, SlotColor.Red),
            new WheelSlot(36, SlotColor.Black),
        };
    }

}
