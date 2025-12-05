using UnityEngine;
using UnityEngine.InputSystem;
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
    
    private InputAction selectAction;
    
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

      selectAction = inputActions.FindAction("Select");
    }
  
    // Create the built in function OnEnable, make it private with no parameters
    private void OnEnable(){
      // When this script is enabled, find the Player action map and enabled it to be used
      inputActions.FindActionMap("Player").Enable();
    }
    // When this script is disabled, find the Player action map and disable it
    private void OnDisable(){
      inputActions.FindActionMap("Player").Disable();
    }
}
