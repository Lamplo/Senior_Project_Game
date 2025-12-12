using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
//class organizes data
/* 
    FUNCTION DECLARATION
    // [Accessor] [ReturnType] [Name](Parameters){
    // Function Body
    //}
    //Awake called once when object is enabled

    VAR DECLARATION
    [Accesor][Type][Name]=[Value];

    VAR ASSIGNMENT
    [Var_Name] = [Value]
*/

public class InputManager : MonoBehaviour
{
    public static InputManager Instance {get;private set;}
    private InputActionAsset inputActions;
    private List<int> rouletteWheelList = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};
    
    // PLAYER ACTIONS
    //private InputAction selectAction;
    
    private void Awake(){
      // Check Signleton
      if(Instance == null) Instance = this;
      else if(Instance != null) {
        Destroy(this);
        Debug.LogWarning("Cannot have more than one copy of InputManager");
      }

      // Initialze Members (Variables)
      // By accessing the InputActions variable, call the FindAction var and pass in the select action as the argument.
      // Assign the output of this function to the SelectionAction var

      //selectAction = inputActions.FindAction("Select");
    }
  
    // Create the built in function OnEnable, make it private with no parameters
    private void OnEnable(){
      // When this script is enabled, find the Player action map and enabled it to be used
      //inputActions.FindActionMap("Player").Enable();
    }

    // When this script is disabled, find the Player action map and disable it
    private void OnDisable(){
      //inputActions.FindActionMap("Player").Disable();
    }

    public void Spin(){
      // Randomly select an element from the roulette Wheel list, store that element in a variable
      int randomSlot = GetRandomElementFromList<int>(rouletteWheelList);
      // Print that output to the console
      Debug.Log(randomSlot);
    }

    private T GetRandomElementFromList<T>(List<T> list){
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
