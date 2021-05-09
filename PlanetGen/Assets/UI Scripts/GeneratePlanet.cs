using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratePlanet : MonoBehaviour
{
    public GameObject GameManager;
    public Planet planet;

    public void Generate()
    {
        GameManager.GetComponent<WriteJSONToFile>().WriteToFile();
        GameManager.GetComponent<UpdatePlanetFromJSON>().UpdatePlanet();
        planet.GetComponent<Planet>().OnValidate();
    }
}
