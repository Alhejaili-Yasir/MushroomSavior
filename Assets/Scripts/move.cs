using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 4.0f;
    public float jumpForce = 5.0f;
    public AudioClip jumpSound;

    private float horz;
    private float vert;
    private Rigidbody rb;
    private Animator anim;
    private AudioSource audioSource;
    private bool isGrounded;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horz, 0, vert).normalized;

        if (movementDirection.magnitude > 0.1f)
        {
            Vector3 moveOffset = movementDirection * speed * Time.deltaTime;
            rb.MovePosition(rb.position + moveOffset);

            Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);

            anim.SetBool("isRun", true);
        }
        else
        {
            anim.SetBool("isRun", false);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            if (jumpSound != null)
            {
                audioSource.PlayOneShot(jumpSound);
            }
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);
    }
}
