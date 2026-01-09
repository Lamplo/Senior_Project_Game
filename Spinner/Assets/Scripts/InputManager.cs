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
    // PLAYER ACTIONS
    //private InputAction selectAction;
    
    private void Awake(){
      // Check Singleton
      if(Instance == null) Instance = this;
      else if(Instance != null) {
        Destroy(this);
        Debug.LogWarning("Cannot have more than one copy of InputManager");
      }
    }
}
