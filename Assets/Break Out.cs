using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    public InputActionReference action;
    public Transform roomTransform; // Reference to the room's transform
    public Transform externalViewTransform; // Reference to the external viewing point's transform

    private bool isPlayerInRoom = true;


    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) => Teleport();
    }

    // Update is called once per frame
    void Teleport()
    {
        if (isPlayerInRoom) 
        {
            transform.position = externalViewTransform.position;
        }
        else
        {
            transform.position = roomTransform.position;
        }

        isPlayerInRoom = !isPlayerInRoom;
    }
}
