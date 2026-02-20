using UnityEngine;

public class PiggyBankTrinket : BaseTrinket
{
    [SerializeField, Tooltip("The point multiplier this trinket applies to the next spin.")]
    protected int pointMulitplier = 2;

    protected override void ApplyTrinketAffect()
    {
        if (GameManager.gameIsOver) return; 
        // Add the mulitplier to the next spin
        RouletteWheel.Instance.ApplyMultiplier(pointMulitplier);
        Debug.Log($"Roluette multiplier set to {pointMulitplier}");
    }

    private void Update(){
        if (GameManager.gameIsOver) return;
        
        // Check for input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyTrinketAffect();
            Destroy(gameObject);
        }
    }    
}
