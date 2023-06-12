using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform cameraHolder;
    public static float mouseSensitivity = 0.2f;
    public static float mouseSensStored;
    float verticalLookRotation;

    public Animator animator;

    void Start()
    {
        mouseSensStored = mouseSensitivity;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        bool isShooting = Input.GetMouseButtonDown(0);
        animator.SetBool("isShooting", isShooting);

        //Rotate the screen according to 'x' Axis
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);

        verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
    }
}
