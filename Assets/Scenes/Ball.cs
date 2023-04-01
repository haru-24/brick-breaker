using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 1.0f;
    private Rigidbody myRigit;

    // Start is called before the first frame update
    void Start()
    {
        myRigit = this.GetComponent<Rigidbody>();
        myRigit.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
