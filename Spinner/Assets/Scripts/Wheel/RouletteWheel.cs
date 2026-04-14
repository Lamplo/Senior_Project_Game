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

    public void Spin()
    {
      if (GameManager.gameIsOver || isSpun) return;

      isSpun = true;

      // Storing a random wheel slot from the wheel context's list of slots
      WheelSlot slot = GetRandomSlotFromList(_wheelContext.slots);

      // Store the number on the selected wheel slot
      int wheelValue = slot.number;
      Debug.Log($"Wheel Spun: {slot}. Number Spun: {wheelValue}");

      // Assign the wheel value to the spin context
      _spinContext.SetValue(wheelValue);

      // Calculate the earned points after the modifiers
      int finalValue = _spinContext.Resolve();

     //Debug.Log($"Final Spin Value: {finalValue}");

      // Earn points based on the final value 
      ScoreManager.Instance.EarnPoints(finalValue);

      _spinContext.Reset();

      // Trigger the spin of the GameManager
      GameManager.Instance.Spin();

      isSpun = false;
    }

    private WheelSlot GetRandomSlotFromList(List<WheelSlot> wheelList)
    {
      // Check if the list is empty
      if(wheelList.Count == 0) {
        // Return the default value for T
        Debug.LogWarning("Wheel list is empty!");
        return null;
      }

      // Generate a random number from 0 - [# of items in list]
      int randomIndex = UnityEngine.Random.Range(0, wheelList.Count);

      // Use that random to select an element from the list by its index
      return wheelList[randomIndex];
      // Return that element from the list
    }
}
