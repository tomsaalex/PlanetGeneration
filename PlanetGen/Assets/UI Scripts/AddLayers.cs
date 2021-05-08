using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLayers : MonoBehaviour
{
    public GameObject layersContainer;
    public GameObject layerPrefab;
    public int lastLayerName = 0;

    public void Awake()
    {
        layersContainer = this.gameObject;
    }

    public void AddLayer()
    {
        GameObject currentLayer =  Instantiate(layerPrefab, layersContainer.transform);
        currentLayer.name = (lastLayerName + 1).ToString();
        
        SaveSystem.currentPlanet.noiseLayers.Add(new SaveSystem.NoiseLayer());
        lastLayerName++;
    }
}
