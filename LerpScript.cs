using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour { 

    private Vector3 pointA = new Vector3(-2, 3, 10);
    private Vector3 pointB = new Vector3(2, 3, 10);
    private float speed = 1;
    private float t;
    

    void Start(){

    }

    private void Update(){
        t += Time.deltaTime * speed;
        // Moves the object to target position
        transform.position = Vector3.Lerp(pointA, pointB, t);
        // Flip the points once it has reached the target
        if (t >= 1)
        {
          
            pointA = pointB;
            pointB = new Vector3(Random.Range(-10.0f, 10.0f), 3, 10);
            t = 0;
           // speed = speed * 1.1f;
        }
    }
}
