using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(0, -2000, 0); // The position the door should slide to when opened
    public float slidingSpeed = 50f; // The speed at which the door slides

    private Vector3 initialPosition; // The initial position of the door
    private bool isOpen = false; // Flag to track if the door is open

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the object that triggered the collider is the player or any other object you want to trigger the door
        if (other.CompareTag("BallTrigger"))
        {
            if (!isOpen)
            {
                OpenDoor();
            }
        }
    }
    void OpenDoor()
    {
        // Move the door to the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, slidingSpeed * Time.deltaTime);
        isOpen = true;
    }
}
