# Unity Code

#### [link for the 'ardity' plugin asset for Unity](https://ardity.dwilches.com/)

#### [HDRI Sky Box files](https://hdri-haven.com/)


#### Arduino code for the rotaryEncoder. 
```Javascript

#include <Arduino.h>
#include <RotaryEncoder.h>

#define PIN_IN1 A2
#define PIN_IN2 A3

int pos = 0;

// Setup a RotaryEncoder with 4 steps per latch for the 2 signal input pins:
// RotaryEncoder encoder(PIN_IN1, PIN_IN2, RotaryEncoder::LatchMode::FOUR3);

// Setup a RotaryEncoder with 2 steps per latch for the 2 signal input pins:
RotaryEncoder encoder(PIN_IN1, PIN_IN2, RotaryEncoder::LatchMode::TWO03);

void setup()
{
  Serial.begin(9600);

} // setup()


// Read the current position of the encoder and print out when changed.
void loop(){
  encoder.tick();
  int newPos = encoder.getPosition();
  if (pos != newPos) {
    pos = newPos;
  } // if
  Serial.println(pos);
}

// The End

```

#### Use this code to listen to data from serial (arduino). 

```Javascript
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
        newPosition.y = float.Parse(msg)/10.0f;
        cubeModifier.transform.position = newPosition;
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}

```
