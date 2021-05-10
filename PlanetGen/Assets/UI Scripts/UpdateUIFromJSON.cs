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
    PlanetStruct json;
    public string path;
    Transform canvas;
    Transform GeneralSettings;
    Transform ShapeSettings;
    GameObject GameManager;
    
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
        //json = SaveSystem.currentPlanet;
        canvas = layersContainer.transform.parent.parent.parent.parent;

        GeneralSettings = FindChildWithTag(canvas, "GeneralSettings");
        ShapeSettings = FindChildWithTag(canvas, "ShapeSettings");
        GameManager = GameObject.FindWithTag("GameManager");

        FindChildWithTag(GeneralSettings, "ResolutionSlider").gameObject.GetComponent<Slider>().value = json.resolution;
        FindChildWithTag(GeneralSettings, "NameInput").gameObject.GetComponent<TMP_InputField>().text = json.name;
        FindChildWithTag(ShapeSettings, "RadiusInput").gameObject.GetComponent<TMP_InputField>().text = json.radius.ToString();

        int noiseLayersLength = json.noiseLayersLength;
        Transform currentLayer;
        for(int i = 1; i <= noiseLayersLength; i++)
        {
            layersContainer.GetComponent<AddLayers>().AddLayer();
            GameManager.GetComponent<UpdateJSON>().UpdateNumLayers(1);
            currentLayer = layersContainer.transform.Find(i.ToString());
            currentLayer.Find("EnabledToggle").gameObject.GetComponent<Toggle>().isOn = json.noiseLayers[i - 1].enabled;
            currentLayer.Find("UseAsMaskToggle").gameObject.GetComponent<Toggle>().isOn = json.noiseLayers[i - 1].useFirstLayerAsMask;

            currentLayer.Find("Noise Settings").Find("Dropdown").gameObject.GetComponent<TMP_Dropdown>().value = json.noiseLayers[i - 1].noiseSettings.filterType;
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("StrengthInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.strength.ToString();
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("NumLayersSlider").gameObject.GetComponent<Slider>().value = json.noiseLayers[i - 1].noiseSettings.numLayers;
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("BaseRoughnessInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.baseRoughness.ToString();
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("RoughnessInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.roughness.ToString();
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("PersistenceInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.persistence.ToString();
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterXInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.CenterX.ToString();
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterYInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.CenterY.ToString();
            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterZInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.CenterZ.ToString();

            currentLayer.Find("Noise Settings").Find("Simple Noise Settings").Find("MinValueInput").gameObject.GetComponent<TMP_InputField>().text = json.noiseLayers[i - 1].noiseSettings.minValue.ToString();



        }



    }

}
