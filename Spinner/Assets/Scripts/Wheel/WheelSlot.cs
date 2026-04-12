using UnityEngine;
using TMPro;

public enum SlotColor {
    Red, 
    Black,
    Green
}

public class WheelSlot
{
    public int number {get;  private set;}
    public SlotColor color {get; private set;}
    public TextMeshProUGUI slotUI {get; private set;}

    // Constructor
    public WheelSlot(int baseNumber, SlotColor baseColor)
    {
        number = baseNumber;
        color = baseColor;

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (slotUI == null)
        {
            return;
        }

        slotUI.text = number.ToString();
    }

    public void SetNumber(int newNumber)
    {
        number = newNumber;
        UpdateUI();
    }
    public void SetColor(SlotColor newColor)
    {
        color = newColor;
    }

    public void SetUI(TextMeshProUGUI uiText)
    {
        slotUI = uiText;
        UpdateUI(); // immediately reflect data in UI
    }
}
