using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel : MonoBehaviour
{
    public float speed = 5.0f;
    public KeyCode up;
    public KeyCode down;

    void Update()
    {
        if(Input.GetKey(up) && transform.position.y < 5.5)
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }

        if (Input.GetKey(down) && transform.position.y > -3.5)
        {
            transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
        }
    }
 }
