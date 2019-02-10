using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveCanvas : MonoBehaviour
{
    public Button saveCanvasButton;

    void Start()
    {
        saveCanvasButton.onClick.AddListener(SaveCanvasData);
    }

    void SaveCanvasData()
    {
        Debug.Log("Saving!");
    }
}
