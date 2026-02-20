using UnityEngine;
public enum TrinketType{
    Passive,
    Consumable
}

public abstract class BaseTrinket : MonoBehaviour, Itrinket
{
    // Declare common attributes and functions across all trinkets

    protected TrinketData data; // Ref to scriptable object

    protected TrinketType trinketType = TrinketType.Consumable;

    protected virtual void ApplyTrinketAffect()
    {
        Debug.Log($"{data.trinketName}");
    }

}
