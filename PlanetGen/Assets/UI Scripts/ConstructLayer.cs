using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SaveSystem;
using TMPro;
using UnityEngine.UI;

public class ConstructLayer : MonoBehaviour
{
    NoiseLayer currentLayer;
    SaveSystem.NoiseSettings currentSettings;


    private void Awake()
    {
        currentLayer = new SaveSystem.NoiseLayer();
        currentSettings = new SaveSystem.NoiseSettings();
    }

    void UpdateCurrentLayer()
    {
        currentLayer.noiseSettings = currentSettings;
        SaveSystem.currentPlanet.noiseLayers[int.Parse(this.name) - 1] = currentLayer;
        //SaveSystem.Print();
    }


    public void UpdateEnabled()
    {
        //TODO 
        bool enabled = this.transform.Find("EnabledToggle").GetComponent<Toggle>().isOn;
        currentLayer.enabled = enabled;
        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateUseFirstLayerAsMask()
    {
        // TODO
        // Add UseFirstLayerAsMask
        bool useAsMask = this.transform.Find("UseAsMaskToggle").GetComponent<Toggle>().isOn;
        currentLayer.useFirstLayerAsMask = useAsMask;
        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateFilterType()
    {
        int fType = this.transform.Find("Noise Settings").Find("Dropdown").GetComponent<TMP_Dropdown>().value;
        currentSettings.filterType = fType;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateStrength()
    {
        string strengthString = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("StrengthInput").GetComponent<TMP_InputField>().text;
        
        
        //TODO
        //Additional checks like a tryparse
        
        float strengthValue = float.Parse(strengthString);
        currentSettings.strength = strengthValue;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateNumLayers()
    {
        int numLayers = (int)this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("NumLayersSlider").GetComponent<Slider>().value;
        currentSettings.numLayers = numLayers;
        
        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateBaseRoughness()
    {
        //TODO
        //Additional checks like a tryparse
        string baseRoughnessInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("BaseRoughnessInput").GetComponent<TMP_InputField>().text;

        float baseRoughness = float.Parse(baseRoughnessInput);
        currentSettings.baseRoughness = baseRoughness;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateRoughness()
    {
        //TODO
        //Additional checks like a tryparse
        string roughnessInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("RoughnessInput").GetComponent<TMP_InputField>().text;

        float roughness = float.Parse(roughnessInput);
        currentSettings.roughness = roughness;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdatePersistence()
    {
        //TODO
        //Additional checks like a tryparse
        string persistenceInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("PersistenceInput").GetComponent<TMP_InputField>().text;

        float persistence = float.Parse(persistenceInput);
        currentSettings.persistence = persistence;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateCenterX()
    {
        //TODO
        //Additional checks like a tryparse
        string centerXInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterXInput").GetComponent<TMP_InputField>().text;

        float centerX = float.Parse(centerXInput);
        currentSettings.CenterX = centerX;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateCenterY()
    {
        //TODO
        //Additional checks like a tryparse
        string centerYInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterYInput").GetComponent<TMP_InputField>().text;

        float centerY = float.Parse(centerYInput);
        currentSettings.CenterY = centerY;


        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateCenterZ()
    {
        //TODO
        //Additional checks like a tryparse
        string centerZInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("Center").Find("CenterZInput").GetComponent<TMP_InputField>().text;

        float centerZ = float.Parse(centerZInput);
        currentSettings.CenterZ = centerZ;


        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

    public void UpdateMinValue()
    {
        //TODO
        //Additional checks like a tryparse
        string minValueInput = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("MinValueInput").GetComponent<TMP_InputField>().text;

        float minValue = float.Parse(minValueInput);
        currentSettings.minValue = minValue;

        UpdateCurrentLayer(); 
        //SaveSystem.Print();
    }

}
