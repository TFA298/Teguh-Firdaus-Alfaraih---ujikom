using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Boy_Controller : MonoBehaviour
{
    public float boySpeed = 350.0f;
    public float rotateSpeed = 10.0f;
    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool inGround;

    // Start is called before the first frame update
    void Start()
    {
        controller.gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // inGround = controller.isGrounded;
        // if (inGround && playerVelocity.y < 0)
        // {
        //     playerVelocity.y = 0f;
        // }

        // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // controller.Move(move * Time.deltaTime * boySpeed);

        // if (move != Vector3.zero)
        // {
        //     gameObject.transform.forward = move;
        // }
        controller = GetComponent<CharacterController>();

        transform.Rotate(Input.GetAxis("Vertical"), 0, 0);

        Vector3 right = transform.TransformDirection(Vector3.right);
        float currentSpeed = boySpeed * Input.GetAxis("Horizontal");
        controller.SimpleMove(right * currentSpeed);
    }
}
