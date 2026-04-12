using UnityEngine;
using System.Collections.Generic;
using System;
using TMPro;

public class RouletteWheel : MonoBehaviour
{
     
    public static RouletteWheel Instance{get; private set;}

    [SerializeField] private List<TextMeshProUGUI> slotsUI = new List<TextMeshProUGUI>();
     
    private WheelContext _wheelContext;
    private SpinContext _spinContext;

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
      _wheelContext = new WheelContext();

      _spinContext = new SpinContext(0);
      // Reset spin
      isSpun = false;
    }

    private void Start(){
      // Pass the wheel context to the Trinket Manager
      TrinketManager.Instance.InitializeButtons(_wheelContext, _spinContext);
      
      // Safety check
      if (_wheelContext.slots.Count != slotsUI.Count)
      {
          Debug.LogError("Slots and UI count mismatch!");
          return;
      }

      // Assign each UI element to its corresponding slot
      for (int i = 0; i < _wheelContext.slots.Count; i++)
      {
          _wheelContext.slots[i].SetUI(slotsUI[i]);
      }
    }

    public void Spin(){

      if (GameManager.gameIsOver) return; // Do nothing if the game is over
      if (isSpun) return; // Prevent a new spin while the wheel is currently spinning

      isSpun = true; // New

      // Randomly select an element from the roulette Wheel list, store that element in a variable
      int randomSlot = GetRandomElementFromList<WheelSlot>(_wheelContext.slots).number;
      // Update the spin context
      _spinContext.SetValue(randomSlot);
      // Resolve the SpinContext & modifiers
      randomSlot = _spinContext.Resolve();
      // Print that output to the console
      Debug.Log((randomSlot + pointsAdded) * pointMulitplier); // New
      // Add points to the score
      ScoreManager.Instance.EarnPoints((randomSlot + pointsAdded) * pointMulitplier); // New
      // Reset the multiplier
      pointMulitplier = 1;

      isSpun = false; // New
      _spinContext.Reset();
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
}
