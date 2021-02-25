using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockLayer : MonoBehaviour
{
    RectTransform rt;
    public float ogHeight;
    public bool docked;

    private void Start()
    {
        docked = false;
        rt = GetComponent<RectTransform>();
        ogHeight = rt.sizeDelta.y;
    }

    public void DockManager()
    {
        if (rt.gameObject.GetComponent<DockLayer>().docked)
        {
            UnDock();
            docked = false;
        }
        else
        {
            Dock(0, true);
            docked = true;
        }
    }

    public void Dock(float heightDiff, bool disableItems)
    {
        if(disableItems)
            foreach (RectTransform child in rt)
            {
                if (child.tag != "Not Dock")
                     child.gameObject.SetActive(!child.gameObject.activeSelf);
            }

        
        if(heightDiff == 0)
            heightDiff = rt.sizeDelta.y - 15;
        
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, rt.sizeDelta.y - heightDiff);
        if(rt.parent.gameObject.tag != "Not Dock")
            rt.transform.parent.GetComponent<DockLayer>().Dock(heightDiff, false);
    }

    public void UnDock()
    {
        //Debug.Log($"Undocking {rt.gameObject.name}");
        foreach (RectTransform child in rt)
        {
            if (!child.gameObject.active)
            {
                child.gameObject.SetActive(true);
                if (child.gameObject.tag == "Layer")
                {
                    child.GetComponent<DockLayer>().UnDock();
                    child.GetComponent<DockLayer>().docked = false;

                }
            }
        }
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, rt.gameObject.GetComponent<DockLayer>().ogHeight);

        if (rt.parent.gameObject.tag != "Not Dock")
            rt.transform.parent.GetComponent<DockLayer>().UnDock();
    }
}
