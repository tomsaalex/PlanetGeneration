using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TempDebug : MonoBehaviour
{
    public Text t; 
    public void UpdateTextThing()
    {
        t.text = SaveSystem.path;
    }
    public void Update()
    {
        UpdateTextThing();
    }
}
