using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{
    public float moveSpeed = 8.0f;
    private Rigidbody rb;
    private bool hasLanded = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (hasLanded)
        {
            // 使用 Vector3.forward，它等于 (0,0,1)
            Vector3 movement = Vector3.forward * moveSpeed;
            
            // 直接设置速度，而不是添加力
            rb.velocity = new Vector3(0, rb.velocity.y, movement.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            hasLanded = true;
        }
    }
}



