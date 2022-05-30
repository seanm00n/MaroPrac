using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public int rotationValue = 60;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0,rotationValue*Time.deltaTime,0));
    }
}
