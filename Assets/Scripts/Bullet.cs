using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigid;

    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        bulletRigid.velocity = transform.forward * speed;
        Destroy(gameObject,3f);
    }


    void Update()
    {
        
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
