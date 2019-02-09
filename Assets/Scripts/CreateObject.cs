using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Bubble bubble;
    public GameObject sphere;
    private Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn object with left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 10;

            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            sphere.name = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
            Instantiate(sphere, mousePos, Quaternion.identity);

            Debug.Log(sphere.name);

            // ScriptableObject.CreateInstance("Bubble");
            // bubble.title = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
            // bubble.Print();
        }
    }
}
