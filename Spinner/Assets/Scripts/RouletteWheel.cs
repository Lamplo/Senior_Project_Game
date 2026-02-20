using UnityEngine;
using System.Collections.Generic;

public class RouletteWheel : MonoBehaviour
{
     
    public static RouletteWheel Instance{get; private set;}
     
    private List<int> rouletteWheelList = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};
    [SerializeField]
    private int pointMulitplier = 1;

    private void Awake(){
      // Check Singleton
      if(Instance == null) Instance = this;
      else if(Instance != null) {
        Destroy(this);
      }
    }

    public void Spin(){
      if (GameManager.gameIsOver) return;

      // Randomly select an element from the roulette Wheel list, store that element in a variable
      int randomSlot = GetRandomElementFromList<int>(rouletteWheelList);
      // Print that output to the console
      Debug.Log(randomSlot * pointMulitplier);
      // Add points to the score
      ScoreManager.Instance.EarnPoints(randomSlot * pointMulitplier);
      // Reset the multiplier
      pointMulitplier = 1;
    }

    private T GetRandomElementFromList<T>(List<T> list)
    {
      // Check if the list is empty
      if(list.Count == 0) {
        // Return the default value for T
        return default(T);
      }

      // Generate a random number from 0 - [# of items in list]
      int randomIndex = UnityEngine.Random.Range(0, list.Count);

      // Use that random to select an element from the list by its index
      return list[randomIndex];
      // Return that element from the list
    }

    public void ApplyMultiplier(int newMultiplier){
      // Takes in an int and sets the multipler for the next spin to that number
      pointMulitplier = newMultiplier;
    }
}
