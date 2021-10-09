using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCotroller : MonoBehaviour
{
    private Rigidbody rgbd;
    public float speed;
    private float l, r;

    void Start()
    {
        rgbd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        l = Input.GetAxisRaw("Horizontal");
        r = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 input = new Vector3(l, 0, r);
        rgbd.MovePosition(transform.position + input * speed * Time.deltaTime);
    }


}
