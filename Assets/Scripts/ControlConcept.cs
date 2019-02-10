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
                Select(hit.collider.gameObject);
            }
            else
            {
                Deselect();
            }
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Delete();
        }
    }

    void Select(GameObject gameObject)
    {
        Deselect();
        gameObject.GetComponent<Renderer>().material = selectionMat;
        Debug.Log(gameObject.GetComponent<Renderer>().material);
        // Add bool property "selected"
    }

    void Deselect()
    {
        GameObject[] concepts = GameObject.FindGameObjectsWithTag("Concept");
        // Add bool property "deselected"
        foreach (GameObject concept in concepts)
        {
            concept.GetComponent<Renderer>().material = defaultContainerMat;
        }
    }

    void Delete()
    {
        GameObject[] concepts = GameObject.FindGameObjectsWithTag("Concept");
        // Check bool property selected"
        foreach (GameObject concept in concepts)
        {
            if (concept.GetComponent<Renderer>().material == selectionMat)
            {
                Destroy(concept);
            }
        }
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        // Break out to selection method
        gameObject.GetComponent<Renderer>().material = selectionMat;
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
}