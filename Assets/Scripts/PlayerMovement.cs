using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;
    public int speed = 10;
    float rayDistance = 1.1f;
    public LayerMask mask;
    float y;
    float x;
    void Start()
    {

    }
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Physics.Raycast(transform.position, -transform.up, rayDistance,mask))
            {
                //인수로 넣어준 mask와 충돌한 대상이 같을때 참을 반환
                rigid.AddForce(new Vector3(0, 300, 0));
            }
            
        }
    }
    void Move()
    {
        Vector3 vec = new Vector3(0, 0, 0);
        y = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        vec += new Vector3(x * speed, rigid.velocity.y, y * speed);

        rigid.velocity = vec;
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
