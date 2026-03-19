using UnityEngine;
public enum TrinketType{
    Passive,
    Consumable
}

public abstract class BaseTrinket : MonoBehaviour, Itrinket
{
    // Declare common attributes and functions across all trinkets

    protected TrinketData data; // Ref to scriptable object

    [SerializeField] protected TrinketType trinketType = TrinketType.Consumable;

    protected void Start()
    {
        // Check the type of consumeable and handle its logic
        switch (trinketType)
        {
            case TrinketType.Passive:
            // If the trinket is a passive, apply its effect immediately
            ApplyTrinketEffect();
            break;
            case TrinketType.Consumable:
            // Handle consumeable logic
            break;
        }
    }

    public virtual void ApplyTrinketEffect()
    {
        Debug.Log($"{data.trinketName}");
    }

    public TrinketType GetType()
    {
        return trinketType;
    }

}
