using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;


public static  class SaveSystem
{
    public static PlanetStruct currentPlanet;

    public static void Awake()
    {
        currentPlanet = new PlanetStruct();
        currentPlanet.noiseLayers = new NoiseLayer[2];
    }

    public static void Print()
    {
        string json = JsonConvert.SerializeObject(currentPlanet);
        Debug.Log(json);
    }

    public struct PlanetStruct
    {
        public string name;
        public float resolution;
        public float radius;

        public int noiseLayersLength;
        public NoiseLayer[] noiseLayers;
    }

    public struct NoiseLayer
    {
        public bool enabled;
        public bool useFirstLayerAsMask;

        public NoiseSettings noiseSettings;
    }

    public struct NoiseSettings
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
    }
}
