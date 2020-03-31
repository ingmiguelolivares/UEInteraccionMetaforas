using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov4 : MonoBehaviour
{
    public float force = 10;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {

            if (Input.GetKey(KeyCode.UpArrow)) {
                Vector3 newPosition = transform.position + (transform.up * Time.deltaTime*5);
                rb.MovePosition(newPosition);
            }

            if (Input.GetKey(KeyCode.DownArrow)) {
                Vector3 newPosition = transform.position - (transform.up * Time.deltaTime*5);
                rb.MovePosition(newPosition);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 newPosition = transform.position + (transform.right * Time.deltaTime*5);
                rb.MovePosition(newPosition);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector3 newPosition = transform.position - (transform.right * Time.deltaTime*5);
                rb.MovePosition(newPosition);
            };

        }

    }
}
