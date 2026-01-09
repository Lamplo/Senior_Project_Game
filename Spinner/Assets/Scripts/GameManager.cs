using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance {get; private set;}
   // A variable to track the number of spins on the level
   public int remainingSpins = 3;
   // A var to track the points needed to beat the level
   private int pointsRequired = 20;

   public static bool gameIsOver = false;

   private void Awake()
    {
            // Check Signleton
        if(Instance == null) Instance = this;
        else if(Instance != null) 
        {
            Destroy(this);
            Debug.LogWarning("Cannot have more than one copy of GameManager");
        }

        remainingSpins = 3;
    }  

    private void Start()
    {
        gameIsOver = false;
    }   

    public void Spin()
    {
        if (gameIsOver) return;

        // Decrement the remaining spin count
        remainingSpins--;

        // Tell the UI Manager to Udpate the score text
        UIManager.Instance.UpdateUI(ScoreManager.Instance.playerScore, remainingSpins);

        // Check if the max spuns is met
        if (remainingSpins < 1)
        {
            //Set the game to be over
            gameIsOver = true;
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
