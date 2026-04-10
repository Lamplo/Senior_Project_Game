using UnityEngine;
using System.Collections.Generic;

public class TrinketManager : MonoBehaviour
{
    public static TrinketManager Instance {get;private set;}

    // A list of all trinket buttons
    [SerializeField] List<TrinketButton> _trinketButtons = new List<TrinketButton>();

    private void Awake(){
        // Check Singleton
        if(Instance == null) Instance = this;
        else if(Instance != null) {
            Destroy(this);
            Debug.LogWarning("Cannot have more than one copy of InputManager");
        }
    }


    public void InitializeButtons(WheelContext cxt){
        if (cxt == null){
            Debug.LogError("wheel context is null!");
            return;
        }

        foreach (TrinketButton button in _trinketButtons){
            button.Initialize(cxt);
        }
    }

    public void RegisterButton(TrinketButton button){
        _trinketButtons.Add(button);
    }


}
