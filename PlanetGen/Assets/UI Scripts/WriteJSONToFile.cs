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

        Debug.Log("fdfdf1");
        SaveSystem.PlanetToJSON(SaveSystem.currentPlanet);
        if (autoUpdate.isOn)
        {
            Debug.Log("fdfdf2");
            GameManager.GetComponent<UpdatePlanetFromJSON>().UpdatePlanet();
            planet.GetComponent<Planet>().OnValidate();
        }
    }
}
