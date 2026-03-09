using UnityEngine;

public class ElevatorManager : MonoBehaviour
{
    public Elevator[] elevators;

    public void RequestElevator(int floor)
    {
        Elevator bestElevator = null;
        int minDistance = int.MaxValue;

        foreach (Elevator elevator in elevators)
        {
            int distance = Mathf.Abs(elevator.currentFloor - floor);

            if (distance < minDistance)
            {
                minDistance = distance;
                bestElevator = elevator;
            }
        }

        if (bestElevator != null)
        {
            bestElevator.AddRequest(floor);
        }
    }
}
