using UnityEngine;

public class DiceTrinket : BaseTrinket
{
    [SerializeField, Tooltip("Adds + 5 to the score.")]
    protected int pointsAdded = 5;

    public override void ModifyWheel(WheelContext context)
    {
        // Change the slot numbers to 36
        // Store the current list of slots
        
        // Reassign the values here
        // Plug the new list back into the wheel context
        // Delete The Trinket

    }

}
