using UnityEngine;

public class RotateWithTorque : MonoBehaviour
{
    Rigidbody rb;
    public float torqueSpeed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddTorque(0, torqueSpeed, 0, ForceMode.Force);
    }
}
