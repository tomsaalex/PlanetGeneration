using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using static SaveSystem;

public class UpdatePlanetFromJSON : MonoBehaviour
{
    public Planet planet;
    public PlanetStruct JSON;

    string pathToJSON; 
    private void Awake()
    {
        pathToJSON = Application.dataPath + "/SaveFiles/file.json";

    }

    int frame = 0;
    void Update()
    {
        frame++;
        if (frame % 500 == 0)
            //UpdatePlanet();
            ;
       }

    void UpdatePlanet()
    {
        JSON = JsonUtility.FromJson<PlanetStruct>(File.ReadAllText(pathToJSON));


        Debug.Log("Workin'");
        //planet.name = JSON.name;
        //planet.resolution = JSON.resolution;

        planet.shapeSettings.planetRadius = JSON.radius;
/*
        for(int i = 0; i < JSON.noiseLayers.Count; i++)
        {
            planet.shapeSettings.noiseLayers[i].enabled = JSON.noiseLayers[i].enabled;
            planet.shapeSettings.noiseLayers[i].useFirstLayerAsMask = JSON.noiseLayers[i].useFirstLayerAsMask;
        
            
        }
  */          

    }

}
