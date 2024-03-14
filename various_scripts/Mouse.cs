using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    public Vector2 turn;
    public float sensitivity = 4f;
    public Vector3 deltaMove;
    public GameObject mover;
    //GameObject cameraModifier;

    // Start is called before the first frame update
    void Start()
    {

      //  Cursor.lockState = CursorLockMode.Locked;
        //cameraModifier = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        mover.transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        //mover.transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);


        //cameraModifier.transform.eulerAngles = new Vector3(
        //      cameraModifier.transform.eulerAngles.x,
        //     Input.GetAxis("Mouse X")*100f,
        //     cameraModifier.transform.eulerAngles.z
        //);



    }
}
