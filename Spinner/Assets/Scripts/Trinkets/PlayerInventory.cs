using UnityEngine;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField, Tooltip("The list of trinkets the player has equipped")]
    private List<BaseTrinket> equippedTrinkets = new List<BaseTrinket>();
    
    private void Start(){
        // Check if any trinkets are passive buffs
        // For each trinket in equipped Trinkets
        foreach (BaseTrinket trinket in equippedTrinkets){
            // Check if it is a passive
            if (trinket.GetType() == TrinketType.Passive){
                //  trigger passive effect
                trinket.ApplyTrinketEffect();
            }
            else if (trinket.GetType() == TrinketType.Consumable){
                // Handle logic, or ignore
            }
        }
    }
}
