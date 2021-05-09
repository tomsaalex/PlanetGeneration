using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateJSON: MonoBehaviour
{
    public Slider resolutionSlider;
    public Planet planet;
    public TMP_InputField radiusInput;
    public TMP_InputField nameInput;
    public TMP_InputField noiseLayersLengthInput;
    public GameObject noiseLayersContainer;
    void Awake()
    {
        //UpdateResolution();
    }

    public void UpdateName()
    {
        SaveSystem.currentPlanet.name = nameInput.text;
        //SaveSystem.Print();
    }

    public void UpdateResolution()
    {
        SaveSystem.currentPlanet.resolution = (int)resolutionSlider.value;
        Debug.Log("UpdateResolution was called");
        //SaveSystem.Print();
    }

    public void UpdateRadius()
    {
        ///TODO
        ///This needs a tryparse and additional checks for letters and other characters
      
        SaveSystem.currentPlanet.radius = float.Parse(radiusInput.text);
        //SaveSystem.Print();
    }

    public void UpdateNumLayers(int value)
    {
        SaveSystem.currentPlanet.noiseLayersLength += value;
    }

    /*public void UpdateLayerFilterType(GameObject G)
    {

        //UnityEngine.Debug.Log(this.transform.transform.name);
        int positionInArray = int.Parse(G.transform.parent.parent.name) - 1;
        
        SaveSystem.currentPlanet.noiseLayers[positionInArray].noiseSettings.filterType = G.GetComponent<Dropdown>().value;
        //SaveSystem.Print();
    }
    */
}
