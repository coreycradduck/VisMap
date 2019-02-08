using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }

        // Turn off gravity with spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.GetComponent<Rigidbody2D>().gravityScale > 0)
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }
    }
}