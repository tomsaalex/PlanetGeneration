using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Diagnostics;

public class UpdateJSON: MonoBehaviour
{
    public Slider resolutionSlider;
    public Planet planet;
    public TMP_InputField radiusInput;
    public TMP_InputField nameInput;
    public GameObject noiseLayersContainer;
    void Awake()
    {
        UpdateResolution();
    }

    public void UpdateName()
    {
        SaveSystem.currentPlanet.name = nameInput.text;
        SaveSystem.Print();
    }

    public void UpdateResolution()
    {
        SaveSystem.currentPlanet.resolution = (int)resolutionSlider.value;
        SaveSystem.Print();
    }

    public void UpdateRadius()
    {
        ///TODO
        ///This needs a tryparse and additional checks for letters and other characters
      
        SaveSystem.currentPlanet.radius = float.Parse(radiusInput.text);
        SaveSystem.Print();
    }

    public void UpdateLayerFilterType(GameObject G)
    {

        //UnityEngine.Debug.Log(this.transform.transform.name);
        int positionInArray = int.Parse(G.transform.parent.parent.name) - 1;
        
        SaveSystem.currentPlanet.noiseLayers[positionInArray].noiseSettings.filterType = G.GetComponent<Dropdown>().value;
        SaveSystem.Print();
    }
}
