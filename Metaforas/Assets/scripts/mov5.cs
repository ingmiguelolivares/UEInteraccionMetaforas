using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov5 : MonoBehaviour
{
    public float force = 10;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * Time.deltaTime * force;
    }
}
