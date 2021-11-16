using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10.0f;
    private float verticalInput;
    public float turnSpeed = 20.0f;
    private float zMax = 450f;
        void Start()
        {
              transform.position = Vector3.zero;
        }
        void Update()
        {
         verticalInput = Input.GetAxis("Vertical");
                    transform.Translate(Vector3.forward * Time.deltaTime * speed);
                         transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);
             
         if (transform.position.z > zMax)
         {
            Debug.Log(message: "THE END");
            Time.timeScale = 0;
         }
        }
}
