using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{ 
    void OnTriggerEnter(Collider Collider)
    {
        Collider.transform.position = new Vector3(57.93f, 96.562f, -20.02f);
    }
}