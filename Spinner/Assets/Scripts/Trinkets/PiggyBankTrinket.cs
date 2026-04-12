using UnityEngine;

public class PiggyBankTrinket : BaseTrinket
{
    [SerializeField, Tooltip("The point multiplier this trinket applies to the next spin.")]
    protected int pointMulitplier = 2;

    public override void ModifySpin(SpinContext context)
    {
        context.multiplier = pointMulitplier; 
    }
   
}
