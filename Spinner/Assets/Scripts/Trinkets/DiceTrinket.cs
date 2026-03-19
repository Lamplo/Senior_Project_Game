using UnityEngine;

public class DiceTrinket : BaseTrinket
{
    [SerializeField, Tooltip("Adds + 5 to the score.")]
    protected int pointsAdded = 5;

    public override void ApplyTrinketEffect()
    {
        // Add to the score for each spin
        RouletteWheel.Instance.ApplyAdd(pointsAdded);
        Debug.Log($"The Dice added {pointsAdded} to the score");
    }

    /*private void Update()
    {
        if (RouletteWheel.Instance) isSpun = true;
        ApplyTrinketEffect();
    }*/
   
}
