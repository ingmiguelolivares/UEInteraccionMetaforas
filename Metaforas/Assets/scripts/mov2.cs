using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {

            if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(Vector3.up * Time.deltaTime*5);

            if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(Vector3.down * Time.deltaTime*5);

            if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Vector3.right * Time.deltaTime*5);

            if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(Vector3.left * Time.deltaTime*5);

        }

    }
}
