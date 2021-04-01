using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SaveSystem;
using TMPro;


public class ConstructLayer : MonoBehaviour
{
    NoiseLayer currentLayer;
    SaveSystem.NoiseSettings currentSettings;


    public void UpdateEnabled()
    {
        //
    }

    public void UpdateUseFirstLayerAsMask()
    {
          // 
    }

    public void UpdateFilterType()
    {
        int fType = this.transform.Find("Noise Settings").Find("Dropdown").GetComponent<TMP_Dropdown>().value;
        currentSettings.filterType = fType;
    }

    public void UpdateStrength()
    {
        string strengthString = this.transform.Find("Noise Settings").Find("Simple Noise Settings").Find("StrengthInput").GetComponent<TMP_InputField>().text;
        
        
        //TODO
        //Additional checks like a tryparse
        
        float strengthValue = float.Parse(strengthString);
    }

    public void UpdateNumLayers()
    {

    }

    public void UpdateBaseRoughness()
    {

    }

    public void UpdateRoughness()
    {

    }

    public void UpdatePersistence()
    {

    }

    public void UpdateCenterX()
    {

    }

    public void UpdateCenterY()
    {

    }

    public void UpdateCenterZ()
    {

    }

    public void UpdateMinValue()
    {

    }

}
