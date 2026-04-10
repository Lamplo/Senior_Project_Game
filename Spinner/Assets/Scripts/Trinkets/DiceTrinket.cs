using UnityEngine;

public class DiceTrinket : BaseTrinket
{
    [SerializeField, Tooltip("Permanantly adds + 5 to the score.")]
    protected int slotModifier = 5;

    public override void ModifyWheel(WheelContext context)
    {
        // Access the wheell context and loop through each slot
        foreach (WheelSlot slot in context.slots)
        {
            slot.SetNumber(slot.number + slotModifier);
        }   

        Debug.Log($"{this} modified the wheel!");

    }

}
