using UnityEngine;

public class SpinContext 
{
    public int baseValue;
    public int finalValue;
    public int multiplier = 1;
    public int additive = 0;

    public SpinContext(int baseValue)
    {
        this.baseValue = baseValue;
        finalValue = baseValue;
        Debug.Log($"Base Value: {baseValue}");
    }

    public void SetValue(int value)
    {
        this.baseValue = value;
        finalValue = value;
        Debug.Log($"Spun Value before spin modifier: {finalValue}");
    }

    public int Resolve()
    {
        finalValue = (baseValue + additive) * multiplier;
        return finalValue;
    }

    public void Reset()
    {
        baseValue = 0;
        finalValue = baseValue;
        multiplier = 1; 
        additive = 0;
    }
}
