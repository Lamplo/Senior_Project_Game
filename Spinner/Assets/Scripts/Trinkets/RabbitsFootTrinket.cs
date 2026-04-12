using UnityEngine;

public class RabbitsFootTrinket : BaseTrinket
{
    protected int slotModifier = -10;
    protected int spinBonus = 1;

    public override void ModifyWheel(WheelContext context)
    {
        // Access the wheell context and loop through each slot
        foreach (WheelSlot slot in context.slots)
        {
            slot.SetNumber(slot.number + slotModifier);
        }   

        // Add a spin
        GameManager.Instance.AddSpin(spinBonus);

        Debug.Log($"{this} modified the wheel!");

    }
}
