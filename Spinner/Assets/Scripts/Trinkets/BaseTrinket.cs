using UnityEngine;
public enum TrinketType{
    Passive,
    Consumable
}


public abstract class BaseTrinket : MonoBehaviour, Itrinket
{
    // Declare common attributes and functions across all trinkets

    [SerializeField] TrinketData data; // Ref to scriptable object

    [SerializeField] protected TrinketType trinketType = TrinketType.Consumable;

    public abstract void ModifyWheel(WheelContext context);

    public virtual TrinketType GetType()
    {
        return trinketType;
    }

}
