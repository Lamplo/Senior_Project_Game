using UnityEngine;

public class PiggyBankTrinket : BaseTrinket
{
    [SerializeField, Tooltip("The point multiplier this trinket applies to the next spin.")]
    protected int pointMulitplier = 2;

    public override void ApplyTrinketEffect()
    {
        if (GameManager.gameIsOver) return; 
        // Add the mulitplier to the next spin
        RouletteWheel.Instance.ApplyMultiplier(pointMulitplier);
        Debug.Log($"Roulette multiplier set to {pointMulitplier}");
    }

    private void Update(){
        if (GameManager.gameIsOver) return;
        
        // Check for input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyTrinketEffect();
            Destroy(gameObject);
        }
    }    
}
