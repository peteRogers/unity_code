using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArduinoListener : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cameraModifier, cubeModifier;
    void Start()
    {
        cameraModifier = GameObject.Find("Main Camera");
        cubeModifier = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
       // string[] sensorList = msg.Split(">");

        // cameraModifier.transform.eulerAngles = new Vector3(
        //     float.Parse(msg)*10,
        //     cameraModifier.transform.eulerAngles.y,
        //     cameraModifier.transform.eulerAngles.z
        //     );
        Vector3 newPosition = cubeModifier.transform.position; // We store the current position
        newPosition.y = float.Parse(msg)/100.0f;
        cubeModifier.transform.position = newPosition;

    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }

}
