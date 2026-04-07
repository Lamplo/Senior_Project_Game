using UnityEngine;
using UnityEngine.UI;

public class TrinketButton : MonoBehaviour
{
    [SerializeField]  Button _button;

    [SerializeField] BaseTrinket _trinket;

    private WheelContext _context;

    private void Awake(){
        _button = GetComponent<Button>();
        _trinket = GetComponent<BaseTrinket>();
    }

    private void Start(){
        TrinketManager.Instance.RegisterButton(this);
    }

    public void Initialize(WheelContext context)
    {
        if (context == null){
            Debug.LogError("Wheel context is null!");
            return;
        }

        _context = context;

        // register a click listener
        _button.onClick.AddListener(OnClicked);
    }

    private void OnClicked(){
        if (_context == null){
            Debug.LogError("No wheel context assigned!");
            return;
        }

        AudioManager.Instance.PlaySound("Click");
        _trinket.ModifyWheel(_context);
    }

}
