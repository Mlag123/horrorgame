using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float mouseSensevity = 2f;
    private PlayerMotor motor;


    void Start()
    { 
        motor = GetComponent<PlayerMotor>();

        
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHor = transform.right*xMov;
        Vector3 moveVer = transform.forward * zMov;

        Vector3 velocity = (moveHor + moveVer).normalized*speed;

        motor.move(velocity);

        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 rotation = new Vector3(0f, yRot, 0f)*mouseSensevity;


        float XRot = Input.GetAxisRaw("Mouse Y");
        Vector3 camRotation = new Vector3(XRot, 0f, 0f) * mouseSensevity;

        motor.rotate(rotation);
        motor.rotateCam(camRotation);

      

    }
}
