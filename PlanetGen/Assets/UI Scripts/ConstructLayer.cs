using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SaveSystem;
using TMPro;
using UnityEngine.UI;
using System.Globalization;

public class ConstructLayer : MonoBehaviour
{
    NoiseLayer currentLayer;
    SaveSystem.NoiseSettings currentSettings;
    WriteJSONToFile WJTF;

    private void Awake()
    {
        currentLayer = new SaveSystem.NoiseLayer();
        currentSettings = new SaveSystem.NoiseSettings();
        WJTF = GameObject.FindWithTag("GameManager").GetComponent<WriteJSONToFile>();
    }

    void UpdateCurrentLayer()
    {
        currentLayer.noiseSettings = currentSettings;
        SaveSystem.currentPlanet.noiseLayers[int.Parse(this.name) - 1] = currentLayer;
        WJTF.WriteToFile();
    }


    public void UpdateEnabled()
    {
        //TODO 
        bool enabled = this.transform.Find("EnabledToggle").GetComponent<Toggle>().isOn;
        currentLayer.enabled = enabled;
        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateUseFirstLayerAsMask()
    {
        // TODO
        // Add UseFirstLayerAsMask
        bool useAsMask = this.transform.Find("UseAsMaskToggle").GetComponent<Toggle>().isOn;
        currentLayer.useFirstLayerAsMask = useAsMask;
        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateFilterType()
    {
        int fType = this.transform.Find("Noise Settings").Find("Dropdown").GetComponent<TMP_Dropdown>().value;
        currentSettings.filterType = fType;

        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateStrength()
    {
        string strengthString = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("StrengthInput").GetComponent<TMP_InputField>().text;


        //TODO
        //Additional checks like a tryparse

        strengthString = strengthString.Replace(',', '.');
        float strengthValue = float.Parse(strengthString, CultureInfo.InvariantCulture);
        
        currentSettings.strength = strengthValue;
        Debug.Log(strengthString);
        Debug.Log(strengthValue);
        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateNumLayers()
    {
        int numLayers = (int)this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("NumLayersSlider").GetComponent<Slider>().value;
        currentSettings.numLayers = numLayers;
        
        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateBaseRoughness()
    {
        //TODO
        //Additional checks like a tryparse
        string baseRoughnessInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("BaseRoughnessInput").GetComponent<TMP_InputField>().text;

        baseRoughnessInput = baseRoughnessInput.Replace(',', '.');
        float baseRoughness = float.Parse(baseRoughnessInput, CultureInfo.InvariantCulture);
        currentSettings.baseRoughness = baseRoughness;

        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateRoughness()
    {
        //TODO
        //Additional checks like a tryparse
        string roughnessInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("RoughnessInput").GetComponent<TMP_InputField>().text;

        roughnessInput = roughnessInput.Replace(',', '.');
        float roughness = float.Parse(roughnessInput, CultureInfo.InvariantCulture);
        currentSettings.roughness = roughness;

        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdatePersistence()
    {
        //TODO
        //Additional checks like a tryparse
        string persistenceInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("PersistenceInput").GetComponent<TMP_InputField>().text;


        persistenceInput = persistenceInput.Replace(',', '.');
        float persistence = float.Parse(persistenceInput, CultureInfo.InvariantCulture);
        currentSettings.persistence = persistence;

        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateCenterX()
    {
        //TODO
        //Additional checks like a tryparse
        string centerXInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterXInput").GetComponent<TMP_InputField>().text;


        centerXInput = centerXInput.Replace(',', '.');
        float centerX = float.Parse(centerXInput, CultureInfo.InvariantCulture);
        currentSettings.CenterX = centerX;

        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateCenterY()
    {
        //TODO
        //Additional checks like a tryparse
        string centerYInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterYInput").GetComponent<TMP_InputField>().text;

        centerYInput = centerYInput.Replace(',', '.');
        float centerY = float.Parse(centerYInput, CultureInfo.InvariantCulture);
        currentSettings.CenterY = centerY;


        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateCenterZ()
    {
        //TODO
        //Additional checks like a tryparse
        string centerZInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterZInput").GetComponent<TMP_InputField>().text;

        centerZInput = centerZInput.Replace(',', '.');
        float centerZ = float.Parse(centerZInput, CultureInfo.InvariantCulture);
        currentSettings.CenterZ = centerZ;


        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

    public void UpdateMinValue()
    {
        //TODO
        //Additional checks like a tryparse
        string minValueInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("MinValueInput").GetComponent<TMP_InputField>().text;

        minValueInput = minValueInput.Replace(',', '.');
        float minValue = float.Parse(minValueInput, CultureInfo.InvariantCulture);
        currentSettings.minValue = minValue;

        UpdateCurrentLayer(); 
        WJTF.WriteToFile();
    }

}
