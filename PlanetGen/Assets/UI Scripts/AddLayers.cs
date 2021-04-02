using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLayers : MonoBehaviour
{
    GameObject layersContainer;
    public GameObject layerPrefab;
    int lastLayerName = 0;
    private void Awake()
    {
        layersContainer = this.gameObject;    
    }

    public void AddLayer()
    {
        GameObject currentLayer =  Instantiate(layerPrefab, layersContainer.transform);
        currentLayer.name = (lastLayerName + 1).ToString();
        lastLayerName++;
    }
}
