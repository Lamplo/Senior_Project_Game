using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get; private set;}

    public int playerScore;
    [SerializeField] private TextMeshProUGUI scoreText; 

    private void Awake()
    {
            // Check Signleton
        if(Instance == null) Instance = this;
        else if(Instance != null) 
        {
            Destroy(this);
            Debug.LogWarning("Cannot have more than one copy of ScoreManager");
        }

        playerScore = 0;
    }

    // Create a public function to add points to the score, it takes an int as a parameter for how many points to add
    public void EarnPoints(int points){
        // Add points to playerScore
        playerScore += points;
        // Udpate the score text
        scoreText.text = playerScore.ToString();
    }

}
