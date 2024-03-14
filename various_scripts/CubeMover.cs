using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour

{
    // Start is called before the first frame update
    float speed = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newXPosition = transform.position.x + speed * Time.deltaTime;
       
        if(newXPosition > 5)
        {
            newXPosition = 0;
        }
        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
    }
}
