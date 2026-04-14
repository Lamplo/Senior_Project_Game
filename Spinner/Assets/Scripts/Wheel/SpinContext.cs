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
        Debug.Log($"Base Value: {baseValue}");
    }

    public void SetValue(int value)
    {
        this.baseValue = value;
        Debug.Log($"Spun Value before spin modifier: {baseValue}");
    }

    public int Resolve()
    {
        finalValue = (baseValue + additive) * multiplier;
        return finalValue;
    }

    public void SetMultiplier(int newMultiplier)
    {
        multiplier = newMultiplier;
        Debug.Log($"The next spin has a new mulitplier of {multiplier}");
    }

    public void Reset()
    {
        baseValue = 0;
        finalValue = 0;
        multiplier = 1; 
        additive = 0;
    }
}
