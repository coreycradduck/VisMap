using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConceptCreator : MonoBehaviour
{
    public GameObject conceptContainer;
    public Concept concept;
    private Vector3 mousePos;
    public Button addConceptButton;
    public Button saveCanvasButton;
    public TMP_InputField conceptTitleInputField;

    private void Start()
    {
        addConceptButton.onClick.AddListener(AddConcept);
        saveCanvasButton.onClick.AddListener(SaveCanvas);
    }

    void Update()
    {

    }

    void AddConcept()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(conceptContainer, mousePos, Quaternion.identity);

        concept.title = conceptTitleInputField.text;

    }

    void SaveCanvas()
    {
        Debug.Log("Saving!");
    }
}
