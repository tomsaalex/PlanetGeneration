using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlanetVariables : MonoBehaviour
{
    public Planet p;
    public Slider resolutionSlider;

    void Update()
    {
        p.resolution = (int)resolutionSlider.value;
    }
}
