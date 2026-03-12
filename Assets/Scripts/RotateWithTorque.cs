using UnityEngine;
using UnityEngine.InputSystem;

public class RotateWithTorque : MonoBehaviour
{
    Rigidbody rb;
    public float torqueForce = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(0, 0, torqueForce, ForceMode.Force);
        }
    }
}
