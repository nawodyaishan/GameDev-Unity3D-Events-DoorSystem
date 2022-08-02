using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveSpeed = 2;
    float rotationSpeed = 4;
    float runningSpeed;
    float vaxis, haxis;
    public bool isJumping, isJumpingAlt, isGrounded = false;
    Vector3 movement;

    void Start()
    {
        Debug.Log("Initialized: (" + this.name + ")");
    }


    void FixedUpdate()
    {
        /*  Controller Mappings */
        vaxis = Input.GetAxis("Vertical");
        haxis = Input.GetAxis("Horizontal");
        isJumping = Input.GetButton("Jump");
        isJumpingAlt = Input.GetKey(KeyCode.Joystick1Button0);

        //Simplified...
        runningSpeed = vaxis;


        if (isGrounded)
        {
            movement = new Vector3(0, 0f,
                runningSpeed * 8); // Multiplier of 8 seems to work well with Rigidbody Mass of 1.
            movement = transform
                .TransformDirection(movement); // transform correction A.K.A. "Move the way we are facing"
        }
        else
        {
            movement *= 0.70f; // Dampen the movement vector while mid-air
        }

        GetComponent<Rigidbody>().AddForce(movement * moveSpeed); // Movement Force


        if ((isJumping || isJumpingAlt) && isGrounded)
        {
            Debug.Log(this.ToString() + " isJumping = " + isJumping);
            GetComponent<Rigidbody>().AddForce(Vector3.up * 150);
        }


        if ((Input.GetAxis("Vertical") != 0f || Input.GetAxis("Horizontal") != 0f) && !isJumping && isGrounded)
        {
            if (Input.GetAxis("Vertical") >= 0)
                transform.Rotate(new Vector3(0, haxis * rotationSpeed, 0));
            else
                transform.Rotate(new Vector3(0, -haxis * rotationSpeed, 0));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited");
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class PlayerController : MonoBehaviour
// {
//     private Rigidbody _rigidbody;
//     private Transform _transform;
//     [SerializeField] private float scale;
//
//     // Start is called before the first frame update
//     void Start()
//     {
//         _transform = GetComponent<Transform>();
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         float x = scale * Time.deltaTime;
//
//         if (Input.GetKeyDown(KeyCode.UpArrow))
//         {
//             _transform.position -= new Vector3(0, 0, x);
//         }
//         else if (Input.GetKeyDown(KeyCode.DownArrow))
//         {
//             _transform.forward += new Vector3(0, 0, x);
//         }
//         else if (Input.GetKeyDown(KeyCode.LeftArrow))
//         {
//             _transform.position += new Vector3(x, 0, 0);
//         }
//         else if (Input.GetKeyDown(KeyCode.RightArrow))
//         {
//             _transform.position -= new Vector3(x, 0, 0);
//         }
//     }
// }