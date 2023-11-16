using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator catAnim;

    void Start()
    {
        catAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            catAnim.SetTrigger("jumpUp");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            catAnim.SetTrigger("rollOver");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            catAnim.SetTrigger("fear");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            catAnim.SetTrigger("spin");
        }
    }
}
