using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlConcept : MonoBehaviour
{
    public Material defaultContainerMat;
    public Material selectionMat;
    public GameObject containerText;
    public Concept concept;

    private Vector2 mousePosition;
    private Vector3 screenPoint;
    private Vector3 offset;

    void Start()
    {
        containerText.GetComponent<TextMeshPro>().text = concept.title;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                Select();
            }
            else
            {
                Deselect();
            }

            //Debug.Log("Click detected");
            //RaycastHit hit = new RaycastHit();
            //Debug.Log(hit);
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.Log(ray);

            //if (Physics.Raycast(ray, out hit))
            //{
            //    if (hit.collider.gameObject == this.gameObject)
            //    {
            //        Debug.Log("Click inside");
            //    }
            //    else
            //    {
            //        Debug.Log("Click outside");
            //    }
            //}
        }
    }

    void Select()
    {
        Debug.Log("Concept hit: selecting...");
    }

    void Deselect()
    {
        Debug.Log("No concepts hit: deselecting...");
    }

    //void OnMouseOver()
    //{
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //void OnMouseDown()
    //{
    //    screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    //    offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    //    // Break out to selection method
    //    gameObject.GetComponent<Renderer>().material = selectionMat;
    //}

    //void OnMouseDrag()
    //{
    //    Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    //    Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
    //    transform.position = cursorPosition;
    //}
}