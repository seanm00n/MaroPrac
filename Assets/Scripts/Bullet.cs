using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigid;
    RaycastHit hit;
    public LayerMask mask;
    float distance = 1f;

    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        bulletRigid.velocity = transform.forward * speed;
        Destroy(gameObject,3f);
    }


    void Update()
    {
        Debug.DrawRay(transform.position,transform.forward*distance, Color.green);
        if (Physics.Raycast(transform.position, transform.forward,out hit, distance,mask)) {
            Debug.Log("player hit");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement playermovement = other.GetComponent<PlayerMovement>();
        if (other.tag == "Player")
        {
            if(playermovement != null)
            {
                playermovement.Die();
            }
            
        }
    }
}
