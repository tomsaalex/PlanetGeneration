using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using static SaveSystem;
using UnityEngine.UI;
using TMPro;

public class UpdateUIFromJSON : MonoBehaviour
{
    public GameObject layersContainer;
    public Planet planet;
    PlanetStruct json;
    public string path;
    Transform canvas;
    Transform GeneralSettings;
    public Transform FindChildWithTag(Transform parent, string tag)
    {
        foreach (Transform child in parent)
            if (child.tag == tag)
                return child.gameObject.transform;
        return null;
    }

    public void UpdateUI()
    {
        string jsonAsText = File.ReadAllText(path);
        json = JsonUtility.FromJson<PlanetStruct>(jsonAsText);
        canvas = layersContainer.transform.parent.parent.parent.parent;

        GeneralSettings = FindChildWithTag(canvas, "GeneralSettings");
        Debug.Log("dfdf");
        FindChildWithTag(GeneralSettings, "ResolutionSlider").gameObject.GetComponent<Slider>().value = json.resolution;
        FindChildWithTag(GeneralSettings, "NameInput").gameObject.GetComponent<TMP_InputField>().text = json.name;

        int noiseLayersLength = json.noiseLayersLength;
        for(int i = 1; i <= noiseLayersLength; i++)
        {
            layersContainer.GetComponent<AddLayers>().AddLayer();
        }
    }

}
