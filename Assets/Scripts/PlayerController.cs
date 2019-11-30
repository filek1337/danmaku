using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed;
    public float realspeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            realspeed = speed / 2;
        }
        else
        {
            realspeed = speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, realspeed);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -realspeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(realspeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-realspeed, 0);
        }
        

    }
}
