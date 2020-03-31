using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov3 : MonoBehaviour
{
    public float force = 5;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * force * Time.deltaTime);
    }
}
