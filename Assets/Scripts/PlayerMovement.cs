using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public int speed = 10;
    float y;
    float x;
    void Start()
    {

    }
    void Update()
    {
        Vector3 vec = new Vector3(0,0,0);

        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        vec += new Vector3(x*speed, 0, y*speed);

        rigid.velocity = vec;
    }
}
