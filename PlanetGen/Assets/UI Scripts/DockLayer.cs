using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockLayer : MonoBehaviour
{
    RectTransform rt;
    float maxHeight;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
        maxHeight = 0;
    }

    public void Dock()
    {
        foreach (Transform child in rt)
        {
            if (child.tag != "Not Dock")
                child.gameObject.SetActive(!child.gameObject.activeSelf);
            else
                maxHeight = child.position.y + 15;
        }
        
        
    }
}
