using UnityEngine;
using System.Collections.Generic;
using System;
using TMPro;

public class RouletteWheel : MonoBehaviour
{
     
    public static RouletteWheel Instance{get; private set;}

    [SerializeField] private List<TextMeshProUGUI> slotsUI = new List<TextMeshProUGUI>();
     
    private WheelContext _context;

    private int pointMulitplier = 1;
    private int pointsAdded = 0; // New
    public bool isSpun = false; // New

    private void Awake(){
      // Check Singleton
      if(Instance == null) Instance = this;
      else if(Instance != null) {
        Destroy(this);
      }

      // Create/Construct a new WheelContext and assing it to the _context
      _context = new WheelContext();
      // Reset spin
      isSpun = false;
    }

    private void Start(){
      // Pass the wheel context to the Trinket Manager
      TrinketManager.Instance.InitializeButtons(_context);
      
      // Safety check
      if (_context.slots.Count != slotsUI.Count)
      {
          Debug.LogError("Slots and UI count mismatch!");
          return;
      }

      // Assign each UI element to its corresponding slot
      for (int i = 0; i < _context.slots.Count; i++)
      {
          _context.slots[i].SetUI(slotsUI[i]);
      }
    }

    public void Spin(){

      if (GameManager.gameIsOver) return; // Do nothing if the game is over
      if (isSpun) return; // Prevent a new spin while the wheel is currently spinning

      isSpun = true; // New

      // Randomly select an element from the roulette Wheel list, store that element in a variable
      int randomSlot = GetRandomElementFromList<WheelSlot>(_context.slots).number;
      // Print that output to the console
      Debug.Log((randomSlot + pointsAdded) * pointMulitplier); // New
      // Add points to the score
      ScoreManager.Instance.EarnPoints((randomSlot + pointsAdded) * pointMulitplier); // New
      // Reset the multiplier
      pointMulitplier = 1;

      isSpun = false; // New
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
      // Takes in an int and sets the multipler for the next isSpun to that number
      pointMulitplier = newMultiplier;
    }

    public void ApplyAdd(int newAdd){ // New
      pointsAdded = newAdd; // New
    }
}
