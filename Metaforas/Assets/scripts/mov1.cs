﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {

            if (Input.GetKey(KeyCode.UpArrow)) transform.position += transform.up * Time.deltaTime * 5;

            if (Input.GetKey(KeyCode.DownArrow)) transform.position -= transform.up * Time.deltaTime * 5;

            if (Input.GetKey(KeyCode.RightArrow)) transform.position += transform.right * Time.deltaTime * 5;

            if (Input.GetKey(KeyCode.LeftArrow)) transform.position -= transform.right * Time.deltaTime * 5;

        }


    }
}
