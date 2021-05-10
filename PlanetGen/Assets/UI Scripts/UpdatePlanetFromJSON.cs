using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using static SaveSystem;


public class UpdatePlanetFromJSON : MonoBehaviour
{
    public Planet planet;
    PlanetStruct json; 
    public string path;

    

    private void Awake()
    {
        //path = Application.dataPath + "/SaveFiles/file.json";
    }

    public void UpdatePlanet()
    {
        string jsonAsText = File.ReadAllText(path);
        json = JsonUtility.FromJson<PlanetStruct>(jsonAsText);


        //Debug.Log("The planet was updated");
        planet.resolution = json.resolution;
        //Debug.Log(json.radius);
        planet.shapeSettings.planetRadius = json.radius;
        planet.shapeSettings.noiseLayers = new ShapeSettings.NoiseLayer[json.noiseLayersLength];
        

        for(int i = 0; i < json.noiseLayersLength; i++)
        {
            planet.shapeSettings.noiseLayers[i] = new ShapeSettings.NoiseLayer();
            planet.shapeSettings.noiseLayers[i].noiseSettings = new NoiseSettings();
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings = new NoiseSettings.SimpleNoiseSettings();

            //Debug.Log(i);
            //Debug.Log(planet.shapeSettings.noiseLayers[i]);
            planet.shapeSettings.noiseLayers[i].enabled = json.noiseLayers[i].enabled;
            planet.shapeSettings.noiseLayers[i].useFirstLayerAsMask = json.noiseLayers[i].useFirstLayerAsMask;


            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.strength = json.noiseLayers[i].noiseSettings.strength;
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.numLayers = json.noiseLayers[i].noiseSettings.numLayers;
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.baseRougness = json.noiseLayers[i].noiseSettings.baseRoughness;
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.roughness = json.noiseLayers[i].noiseSettings.roughness;
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.persistence = json.noiseLayers[i].noiseSettings.persistence;
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.centre = new Vector3(json.noiseLayers[i].noiseSettings.CenterX, json.noiseLayers[i].noiseSettings.CenterY, json.noiseLayers[i].noiseSettings.CenterZ);
            planet.shapeSettings.noiseLayers[i].noiseSettings.simpleNoiseSettings.minValue = json.noiseLayers[i].noiseSettings.minValue;
        }
    }
}
