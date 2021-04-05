using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RemoveLayers : MonoBehaviour
{
    Transform layerContainer;
    Button removeButton;
    GameObject actualLayer;
    private void Awake()
    {
        actualLayer = this.transform.parent.gameObject;
        layerContainer = actualLayer.transform.parent;
        removeButton = this.GetComponent<Button>();
        removeButton.onClick.AddListener(RemoveLayerAtIndex);
    }

    void RemoveLayerAtIndex()
    {
        //TODO
        //When erasing a layer, the data doesn't actually get edited, just the interface
        actualLayer.transform.parent.gameObject.GetComponent<AddLayers>().lastLayerName--;
        //TODO
        //Tryparse and other fun stuff. You know the drill by now
        int index = int.Parse(actualLayer.name);


        for(int i = index - 1; i < SaveSystem.currentPlanet.noiseLayers.Count - 1; i++)
        {
            SaveSystem.currentPlanet.noiseLayers[i] = SaveSystem.currentPlanet.noiseLayers[i + 1];
        }

        SaveSystem.currentPlanet.noiseLayers.RemoveAt(SaveSystem.currentPlanet.noiseLayers.Count - 1);

        actualLayer.name = "TBD";
        foreach(Transform layer in layerContainer)
        {
            if (layer == actualLayer.transform)
                continue;
            //TODO
            //Tryparse, yadda yadda
            Debug.Log(layer.name);
            int layerIndex = int.Parse(layer.name);
            if(layerIndex > index)
            {
                layer.gameObject.name = (int.Parse(layer.gameObject.name) - 1).ToString();
            }
        }
        Destroy(actualLayer);
    }
}
