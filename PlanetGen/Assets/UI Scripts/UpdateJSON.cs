using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Globalization;

public class UpdateJSON: MonoBehaviour
{
    public Slider resolutionSlider;
    public Planet planet;
    public TMP_InputField radiusInput;
    public TMP_InputField nameInput;
    public TMP_InputField noiseLayersLengthInput;
    public GameObject noiseLayersContainer;
    WriteJSONToFile WJTF;

    void Awake()
    {
        //UpdateResolution();
        WJTF = GameObject.FindWithTag("GameManager").GetComponent<WriteJSONToFile>();
    }

    public void UpdateName()
    {
        SaveSystem.currentPlanet.name = nameInput.text;
        WJTF.WriteToFile();
        //SaveSystem.Print();
    }

    public void UpdateResolution()
    {
        SaveSystem.currentPlanet.resolution = (int)resolutionSlider.value;
        WJTF.WriteToFile();
        //Debug.Log("UpdateResolution was called");
        //SaveSystem.Print();
    }

    public void UpdateRadius()
    {
        ///TODO
        ///This needs a tryparse and additional checks for letters and other characters

        radiusInput.text = radiusInput.text.Replace(',', '.');

        SaveSystem.currentPlanet.radius = float.Parse(radiusInput.text, CultureInfo.InvariantCulture);

        WJTF.WriteToFile();
        //SaveSystem.Print();
    }

    public void UpdateNumLayers(int value)
    {
        SaveSystem.currentPlanet.noiseLayersLength += value;
        WJTF.WriteToFile();
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
