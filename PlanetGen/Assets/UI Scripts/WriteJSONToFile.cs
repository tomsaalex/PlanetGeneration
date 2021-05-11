using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteJSONToFile : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject planet;
    public Toggle autoUpdate;

    public void WriteToFile()
    {
        SaveSystem.PlanetToJSON(SaveSystem.currentPlanet);
        if (autoUpdate.isOn)
        {
            GameManager.GetComponent<UpdatePlanetFromJSON>().UpdatePlanet();
            planet.GetComponent<Planet>().OnValidate();
        }
    }
}
