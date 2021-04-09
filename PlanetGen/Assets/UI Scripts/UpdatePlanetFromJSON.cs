using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using static SaveSystem;


public class UpdatePlanetFromJSON : MonoBehaviour
{
    public Planet planet;
    PlanetStruct json; 
    string path;

    

    private void Awake()
    {
        path = Application.dataPath + "/SaveFiles/file.json";
    }

    public void UpdatePlanet()
    {
        string jsonAsText = File.ReadAllText(path);
        json = JsonUtility.FromJson<PlanetStruct>(jsonAsText);


        //Debug.Log("The planet was updated");
        planet.resolution = json.resolution;
        //Debug.Log(json.radius);
        planet.shapeSettings.planetRadius = json.radius;
        Debug.Log(planet.shapeSettings.planetRadius);
    }
}
