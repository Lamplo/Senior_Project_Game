using UnityEngine;

public class DiceTrinket : BaseTrinket
{
    [SerializeField, Tooltip("Adds + 5 to the score.")]
    protected int pointsAdded = 5;

    public override void ModifyWheel(WheelContext context)
    {

    }
    

    /*private void Update()
    {
        if (RouletteWheel.Instance) isSpun = true;
        ApplyTrinketEffect();
    }*/
   
}
