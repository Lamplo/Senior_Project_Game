using UnityEngine;
using System.Collections.Generic;

public class WheelContext
{
    public List<WheelSlot> _slots {get; private set;}

    // Constructor
    public WheelContext(List<WheelSlot> baseSlots)
    {
        _slots = baseSlots;
    }
}
