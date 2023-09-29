using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEFTRIGHT : MonoBehaviour
{
    private bool movingLeft;
    void Start()
    {
        movingLeft = true;
    }
    void Update()
    {
        if (movingLeft == true)
        {
            // move left
            if (transform.position.x <= -4) movingLeft = false;
        }
        else
        {
            // move right
        }
    }
}
