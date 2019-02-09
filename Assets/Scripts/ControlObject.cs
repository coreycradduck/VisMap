using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlObject : MonoBehaviour
{
    public Material sphereMat;
    public Material noGravityMat;
    public GameObject title;
    public Bubble bubble;

    // Start is called before the first frame update
    void Start()
    {
        title.GetComponent<TextMeshPro>().text = bubble.title;
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy game object
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }

        // Turn off gravity and change color with spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.GetComponent<Rigidbody2D>().gravityScale > 0)
            {
                gameObject.GetComponent<Renderer>().material = noGravityMat;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material = sphereMat;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }
    }
}