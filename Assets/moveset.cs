using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveset : MonoBehaviour
{
    private Rigidbody Rigidbody;
    float forvardspeed = 12f;

    // Start is called before the first frame update
    private void Awake()
    {
        Rigidbody= GetComponent<Rigidbody>();

     
    }

    // Update is called once per frame
    void Update()
    {
        //if (Rigidbody.velocity.x > forvardspeed)
        //{
        //    Rigidbody.velocity = Rigidbody.velocity.normalized * forvardspeed;
        //}
    }
    private void FixedUpdate()
    {


        //if(Input.GetKey(KeyCode.W))
        //{
        //    Rigidbody.AddForce(Vector3.forward*forvardspeed);                                                                                
        //}    
        //if(Input.GetKey(KeyCode.S))
        //{
        //    Rigidbody.AddForce(Vector3.back*forvardspeed);
        //}    
        //if( Input.GetKey(KeyCode.D))
        //{
        //    Rigidbody.AddForce(Vector3.right * forvardspeed);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Rigidbody.AddForce(Vector3.left * forvardspeed);
        //}

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        var newVelocity = new Vector3(h, 0.0f, v) * forvardspeed;
        newVelocity = Vector3.ClampMagnitude(newVelocity, forvardspeed);
        if(Input.GetKey(KeyCode.LeftShift))
        {
            forvardspeed = 20f;
        }
        else 
        { 
            forvardspeed = 12f;
        }
        newVelocity.y = Rigidbody.velocity.y;

        Rigidbody.velocity = newVelocity;
    }
}
