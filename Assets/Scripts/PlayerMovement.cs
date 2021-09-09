using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float smoothTime = 1f;
    [SerializeField]
    private float wheelRotationFactor = 90f;
    [SerializeField]
    private Transform leftWheel;
    [SerializeField]
    private Transform rightWheel;
    private Camera mainCam;

    private float targetX;
    private float vel = 0f;
    void Start()
    {
        mainCam = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
            targetX = touchPosition.x;
        }
        float newXPosition = Mathf.SmoothDamp(transform.position.x, targetX, ref vel,smoothTime * Time.deltaTime);
        Vector3 wheelRotation = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.position.x * wheelRotationFactor);
        leftWheel.localEulerAngles = wheelRotation;
        rightWheel.localEulerAngles = wheelRotation;
        transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);

    }
}
