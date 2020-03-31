using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse : MonoBehaviour
{

    private Vector3 mp, inicial;
    private bool movestate = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        if (movestate == true){
            if (Input.GetMouseButton(0))
            {
                inicial = transform.position;
                mp = Input.mousePosition;
                mp = Camera.main.ScreenToWorldPoint(mp);
                Vector3 newpos = new Vector3(mp.x, mp.y, inicial.z);

                transform.position = newpos;

            }

           
        }
    }

    void OnMouseOver()
    {
        movestate = true;
        print(movestate);
    }

    void OnMouseExit()
    {
        movestate = false;
        print(movestate);
    }
}
