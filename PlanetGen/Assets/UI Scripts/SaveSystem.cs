using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveSystem
{
    public static PlanetStruct currentPlanet;
    
    public static void Awake()
    {
        currentPlanet = new PlanetStruct();
    }

    public static void PlanetToJSON(PlanetStruct planet)
    {
        string json = JsonUtility.ToJson(planet);
        Debug.Log(json);
        string path = Application.dataPath + "/SaveFiles/file.json";
        File.WriteAllText(path, json);
    }

    public static void Print()
    {
        string json = JsonUtility.ToJson(currentPlanet);
        Debug.Log(json);
    }
    [System.Serializable]
    public class PlanetStruct
    {
        public string name;
        public int resolution;
        public float radius;

        public int noiseLayersLength;
        public List<NoiseLayer> noiseLayers;
    
        public PlanetStruct()
        {
            name = "";
            resolution = 0;
            radius = 0;

            noiseLayersLength = 0;
            noiseLayers = new List<NoiseLayer>();
        }
    }
    [System.Serializable]
    public class NoiseLayer
    {
        public bool enabled;
        public bool useFirstLayerAsMask;

        public NoiseSettings noiseSettings;

        public NoiseLayer()
        {
            enabled = true;
            useFirstLayerAsMask = true;

            noiseSettings = new NoiseSettings();
        }
    }
    [System.Serializable]
    public class NoiseSettings
    {
        public int filterType;

        public float strength;
        public int numLayers;
        public float baseRoughness;
        public float roughness;
        public float persistence;

        public float CenterX;
        public float CenterY;
        public float CenterZ;

        public float minValue;
        public float weightMultiplier;

        public NoiseSettings()
        {
            filterType = 0;
            strength = 0;
            numLayers = 0;
            baseRoughness = 0;
            roughness = 0;
            persistence = 0;

            CenterX = 0;
            CenterY = 0;
            CenterZ = 0;

            minValue = 0;
            weightMultiplier = 0;
        }
    }
}
