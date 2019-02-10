using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConceptController : MonoBehaviour
{
    public Material sphereMat;
    public Material noGravityMat;
    public GameObject title;
    public Concept concept;

    private Vector3 screenPoint;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        title.GetComponent<TextMeshPro>().text = concept.title;
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

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
}