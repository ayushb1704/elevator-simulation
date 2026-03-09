using UnityEngine;
using TMPro;

public class FloorDisplay : MonoBehaviour
{
    public Elevator elevator;
    public TextMeshProUGUI displayText;

    void Update()
    {
        displayText.text = "Floor: " + elevator.currentFloor.ToString();
    }
}