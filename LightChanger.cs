using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightChanger : MonoBehaviour
{
    public GameObject lightGameObject; // Assign the GameObject with the Light component in the Inspector

    private Light lightComponent;

    private void Start()
    {
        // Get the Light component from the GameObject
        lightComponent = lightGameObject.GetComponent<Light>();

        // Check if the Light component exists
        if (lightComponent != null)
        {   
            // Change the intensity value to a new value
           // lightComponent.intensity = 5.0f; // Change this to your desired intensity value
        }
        else
        {
            Debug.LogWarning("No Light component found on the specified GameObject.");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lightComponent.intensity = 2.0f;
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            lightComponent.intensity = 0.0f;
        }

    }
}
