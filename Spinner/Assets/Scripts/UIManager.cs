using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // Create a public static varable of type UIManager called Instance
    public static UIManager Instance {private set; get;}

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI spinText;

    private void Awake(){
      // Check Singleton
      if(Instance == null) Instance = this;
      else if(Instance != null) {
        Destroy(this);
      }
    }

    private void Start(){
        UpdateUI(0, GameManager.Instance.remainingSpins);
    }

    public void UpdateUI(int score, int spinsLeft){
        if (GameManager.gameIsOver) return;

        // Update the UI based on the spin of the wheel
        // Update the score text
        scoreText.text = score.ToString();
        spinText.text = spinsLeft.ToString();
    }
        

}
