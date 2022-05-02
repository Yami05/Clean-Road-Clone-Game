using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManagerAndCarMovement : MonoBehaviour
{
    private Touch touch;
    private float speedOfMovement;
    [SerializeField] private float rotationSpeed;
    [SerializeField] float carSpeed;
    Rigidbody rb;
    private float rotation = -90;
    float limits;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        speedOfMovement = 0.3f * Time.deltaTime;
        rotationSpeed = 150;

    }


    void FixedUpdate()
    {

        Vector3 forward = new Vector3(1 * Time.deltaTime * carSpeed, 0, 0);

        //movement part

        rb.MovePosition(transform.position + transform.TransformDirection(forward));




        //swipe Part
        // limits=(Mathf.Clamp()
        rotation = Mathf.Clamp(rotation, -130, -50);
        var rot = transform.localEulerAngles;
        rot.y = rotation;
        transform.localEulerAngles = rot;

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {

                if (touch.deltaPosition.x < 0)
                {
                    rotation -= rotationSpeed * Time.deltaTime;
                }
                if (touch.deltaPosition.x > 0)
                {
                    rotation += rotationSpeed * Time.deltaTime;
                }
            }
        }
        else if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < 0)
            {
                rotation -= rotationSpeed * Time.deltaTime;
            }
            if (Input.mousePosition.x > 0)
            {
                rotation += rotationSpeed * Time.deltaTime;
            }
        }



    }
}