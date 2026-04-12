using UnityEngine;
using System;

public class SlotMachineTrinket : BaseTrinket
{
    public override void ModifyWheel(WheelContext wheelContext)
    {
        foreach (WheelSlot slot in wheelContext.slots)
        {
            slot.SetNumber(UnityEngine.Random.Range(-10, 51));
        }
    }
}
