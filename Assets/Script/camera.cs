using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    
    public Vector3 Mouse;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(1))
        {
            transform.position = new Vector3(transform.position.x+(Input.mousePosition-Mouse).x,transform.position.y+(Input.mousePosition-Mouse).y,-10f);
        }
        Mouse = Input.mousePosition;
        if (transform.position.x<= -23.66)
        {
            transform.position = new Vector3(-23.66f, transform.position.y + (Input.mousePosition - Mouse).y, -10f);
        }
        if (transform.position.x >= 22.84)
        {
            transform.position = new Vector3(22.84f, transform.position.y + (Input.mousePosition - Mouse).y, -10f);
        }
        if (transform.position.y<= -13.02)
        {
            transform.position = new Vector3(transform.position.x + (Input.mousePosition - Mouse).x, -13.02f, -10f);
        }
        if (transform.position.y >= 13.46)
        {
            transform.position = new Vector3(transform.position.x + (Input.mousePosition - Mouse).x, 13.46f, -10f);
        }
    }
}
