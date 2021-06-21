using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public float turnSpeed = 2f;
    public float playerSpeed = 0.1f;
    // Rigidbody m_Rigidbody;
    // Vector3 m_Movement;
    private Rigidbody rigidBody;
    bool pressE;
    
    void Start()
    {
        pressE = true;
        //m_Rigidbody = GetComponent<Rigidbody> ();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            pressE = !pressE;
        }
        if(pressE){
            float horizontalInput = Input.GetAxis("Horizontal");
            
            float verticalInput = Input.GetAxis("Vertical");
            
            rigidBody.transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * playerSpeed * Time.deltaTime);
        }


        // float horizontal = Input.GetAxis ("Horizontal");
        // float vertical = Input.GetAxis ("Vertical");

        // m_Movement.Set(horizontal, 0f, vertical);
        // m_Movement.Normalize ();

        // bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f);
        // bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
        // bool isWalking = hasHorizontalInput || hasVerticalInput;

        // Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        // m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement);




        // if (Input.GetAxisRaw("Horizontal") != 0)
        // {
        //     rigidBody.velocity = transform.right * Input.GetAxisRaw("Horizontal") * playerSpeed;
        // }
        // if (Input.GetAxisRaw("Vertical") != 0)
        // {
        //     rigidBody.velocity = transform.forward * Input.GetAxisRaw("Vertical") * playerSpeed;
        // }
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     rigidBody.velocity = transform.forward * Input.GetAxisRaw("Vertical") * 0;
        // }

        
        
    }
}
