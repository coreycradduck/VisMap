using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObject : MonoBehaviour
{
    public Material sphereMat;
    public Material noGravityMat;

    // Start is called before the first frame update
    void Start()
    {

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