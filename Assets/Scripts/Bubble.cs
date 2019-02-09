using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bubble", menuName = "Bubble")]
public class Bubble : ScriptableObject
{
    public string title;

    public void Print()
    {
        Debug.Log(title);
    }
}
