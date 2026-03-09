using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public int currentFloor = 0;
    public float speed = 2f;

    public List<int> requestQueue = new List<int>();

    private bool isMoving = false;
    private Vector3 targetPosition;

    public Transform[] floorPositions;

    void Start()
    {
        for (int i = 0; i < floorPositions.Length; i++)
        {
            if (Mathf.Abs(transform.position.y - floorPositions[i].position.y) < 0.1f)
            {
                currentFloor = i;
                break;
            }
        }
    }
    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                ArriveAtFloor();
            }
        }
        else if (requestQueue.Count > 0)
        {
            MoveToNextFloor();
        }
    }

    public void AddRequest(int floor)
    {
        if (!requestQueue.Contains(floor))
        {
            requestQueue.Add(floor);
        }
    }

    void MoveToNextFloor()
    {
        if (requestQueue.Count == 0)
            return;

        int nextFloor = requestQueue[0];
        requestQueue.RemoveAt(0);

        targetPosition = new Vector3(transform.position.x,floorPositions[nextFloor].position.y,transform.position.z);
        isMoving = true;
    }

    void ArriveAtFloor()
    {
        isMoving = false;

        for (int i = 0; i < floorPositions.Length; i++)
        {
            if (Mathf.Abs(transform.position.y - floorPositions[i].position.y) < 0.1f)
            {
                currentFloor = i;
                break;
            }
        }
    }
}