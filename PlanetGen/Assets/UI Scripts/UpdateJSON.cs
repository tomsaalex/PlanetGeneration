using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateJSON : MonoBehaviour
{
    public Slider resolutionSlider;
    public Planet planet;
    public TMP_InputField radiusInput;
    public TMP_InputField nameInput;

    void Start()
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
}
