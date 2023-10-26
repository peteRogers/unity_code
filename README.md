# Unity Code
#### Use this code to listen to data from serial (arduino). 

```Javascript
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMessageListener : MonoBehaviour
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
        string[] sensorList = msg.Split(">");
        if (int.Parse(sensorList[1]) == 5)
        {

            cameraModifier.transform.eulerAngles = new Vector3(
                cameraModifier.transform.eulerAngles.x,
                float.Parse(sensorList[0]),
                cameraModifier.transform.eulerAngles.z
                );
        }
        if (int.Parse(sensorList[1]) == 1)
        {

            cameraModifier.transform.eulerAngles = new Vector3(
                float.Parse(sensorList[0]),
                cameraModifier.transform.eulerAngles.y,
                cameraModifier.transform.eulerAngles.z
                );
        }



        //Vector3 newPosition = cubeModifier.transform.position; // We store the current position
        //newPosition.y = float.Parse(sensorList[0])/100.0f;
        //cubeModifier.transform.position = newPosition;

    }
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }

}

```
