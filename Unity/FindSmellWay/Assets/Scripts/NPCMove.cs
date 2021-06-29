using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove : MonoBehaviour
{
    public Animator animator;
    public Rigidbody myRigidbody;
    public float moveSpeed;
    private float randomX;
    private float randomZ;
    private bool isGrounded;


    void Start()
    {
        moveSpeed = 3f;
        isGrounded = true;
        StartCoroutine(RandomMove());
        StartCoroutine(StopMove());
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = randomX * moveSpeed;
        float inputZ = randomZ * moveSpeed;

        Vector3 moveDirection = new Vector3(inputX, 0f, inputZ);
        transform.position += moveDirection * Time.deltaTime;

        if(moveSpeed == 0f)
        {
            transform.rotation = Quaternion.identity;
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(moveDirection * Time.deltaTime);
        }        
        animator.SetFloat("MoveSpeed", moveSpeed);


    }

    IEnumerator RandomMove()
    {
        animator.SetBool("Grounded", isGrounded);
        while (true)
        {
            moveSpeed = 3f;
            randomX = Random.Range(-1f, 1f);
            randomZ = Random.Range(-1f, 1f);

            yield return new WaitForSeconds(3);
        }
    }

    IEnumerator StopMove()
    {
        while(true)
        {
            moveSpeed = 0f;

            yield return new WaitForSeconds(5);
        }
    }
}
