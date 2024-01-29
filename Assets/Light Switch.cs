using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    private Color[] colors = { Color.white, Color.red, Color.green, Color.blue };
    private int currentColorIndex = 0;

    void Start()
    {
        light = GetComponent<Light>();
        //light.color = colors[currentColorIndex];

        action.action.Enable();
        action.action.performed += (ctx) => {
        
            currentColorIndex = (currentColorIndex + 1) % colors.Length;

            light.color = colors[currentColorIndex];
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
