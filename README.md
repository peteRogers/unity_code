# Unity Code

#### [link for the 'ardity' plugin asset for Unity](https://ardity.dwilches.com/)

#### Use this code to listen to data from serial (arduino). 
```Javascript
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMessageListener : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cubeModifier;

    void Start()
    {
       // cubeModifier = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        //not needed because the data arriving updates everything
    }

    void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
        string[] sensorList = msg.Split(">");
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
