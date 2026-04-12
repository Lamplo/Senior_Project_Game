using UnityEngine;

public class RedMarkerTrinket : BaseTrinket
{
    // Doubles red numbers, halves black
    public override void ModifyWheel(WheelContext wheelContext)
    {
        foreach (WheelSlot slot in wheelContext.slots)
        {
            if (slot.color == SlotColor.Red)
            {
                // Double the slots number
                slot.SetNumber(slot.number * 2);
            }
            else if (slot.color == SlotColor.Black)
            {
                // Halve the slots number 
                slot.SetNumber(slot.number / 2);
            }
        }
    }
}
