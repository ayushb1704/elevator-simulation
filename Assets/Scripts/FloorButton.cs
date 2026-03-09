using UnityEngine;

public class FloorButton : MonoBehaviour
{
    public ElevatorManager manager;

    public void PressButton(int floorNumber)
    {
        manager.RequestElevator(floorNumber);
    }
}