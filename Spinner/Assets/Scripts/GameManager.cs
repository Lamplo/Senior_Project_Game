using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance {get; private set;}
   // A variable to track the number of spins on the level
   public int maxSpins = 3;
   // A var to track how many spins the player made
   public int amountSpun = 0;
   // A var to track the points needed to beat the level
   private int pointsRequired = 500;

   private void Awake()
    {
        amountSpun = 0;

            // Check Signleton
        if(Instance == null) Instance = this;
        else if(Instance != null) 
        {
            Destroy(this);
            Debug.LogWarning("Cannot have more than one copy of GameManager");
        }
    }     

    public void Spin()
    {
        if (amountSpun >= maxSpins){
            Debug.Log("No Spins Remaining!");
            return;
        }

        // Increment the Spin count
        GameManager.Instance.amountSpun ++;

        // Check if the max spuns is met
        if (amountSpun == maxSpins)
        {
             // If it if is, calculate if player won
             if (ScoreManager.Instance.playerScore >= pointsRequired)
             {
                Debug.Log("You Win");
             }
             else {
                Debug.Log("You Lose!");
             }
        }
    }


}
