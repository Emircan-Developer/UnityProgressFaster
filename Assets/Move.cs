using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    public int speed;
    float x, y;
    public CharacterController charControl;
    Rigidbody ActorRigid;
    // Start is called before the first frame update
    void Start()
    {
        ActorRigid = GetComponent<Rigidbody>();      
    }
    
    // Update is called once per frame
    void Update()
    {
        GetInput();
        charControl.Move(move());
    }
    Vector3 move()
    {
        Vector3 move = transform.right * speed * x + transform.forward * speed * y;
        move.y -= 9.8f;

        return move * Time.deltaTime;
    }
    private void GetInput()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }
}
