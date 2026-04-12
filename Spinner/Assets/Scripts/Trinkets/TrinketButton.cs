using UnityEngine;
using UnityEngine.UI;

public class TrinketButton : MonoBehaviour
{
    [SerializeField]  Button _button;

    [SerializeField] BaseTrinket _trinket;

    private WheelContext _wheelContext;
    private SpinContext _spinContext;

    private void Awake(){
        _button = GetComponent<Button>();
        _trinket = GetComponent<BaseTrinket>();
    }

    private void Start(){
        TrinketManager.Instance.RegisterButton(this);
    }

    public void Initialize(WheelContext wheelContext, SpinContext spinContext)
    {

        _wheelContext = wheelContext;
        _spinContext = spinContext;

        // register a click listener
        _button.onClick.AddListener(OnClicked);
    }

    private void OnClicked(){

        AudioManager.Instance.PlaySound("Click");
        _trinket.ModifyWheel(_wheelContext);
        _trinket.ModifySpin(_spinContext);
        Debug.Log("Button has been clicked");

        // Despawn the button
        Destroy(gameObject);
    }   

}
