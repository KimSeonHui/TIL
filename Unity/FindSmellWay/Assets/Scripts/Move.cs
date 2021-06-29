using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed;
    public float mouseSensitivity;
    private float jumpSpeed;
    public Rigidbody myRigidbody;
    public Camera myCam;
    private float rotationX;

    public GameManager gameManager;



    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        mouseSensitivity = 300f;
        jumpSpeed = 200f;
        rotationX = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.isEndedGame)
        {
            float inputX = Input.GetAxis("Horizontal") * speed;
            float inputZ = Input.GetAxis("Vertical") * speed;

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            rotationX -= mouseY;
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            myCam.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
            transform.Rotate(0f, mouseX, 0f);

            Vector3 moveDirection = new Vector3(inputX, 0f, inputZ);

            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                transform.Translate(moveDirection * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.Space) && IsGround())
            {
                myRigidbody.AddForce(0f, jumpSpeed, 0f);
            }
        }
        
    }

    private bool IsGround()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
}
