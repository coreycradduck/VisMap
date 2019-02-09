using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConceptCreator : MonoBehaviour
{
    public GameObject concept;
    private Vector3 mousePos;
    public Button create;

    private void Start()
    {
        create.onClick.AddListener(AddConcept);
    }

    void Update()
    {

    }

    void AddConcept()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(concept, mousePos, Quaternion.identity);
    }
}
