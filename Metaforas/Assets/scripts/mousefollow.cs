using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousefollow : MonoBehaviour
{

    private Vector3 mp;
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {

            if (Input.GetMouseButton(0)) {
                mp = Input.mousePosition;
                mp = Camera.main.ScreenToWorldPoint(mp);
                transform.position = Vector2.Lerp(transform.position, mp, moveSpeed);
            
            }

        }




    }
}
