using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;


public class SaveSystem : MonoBehaviour
{


    
    void Start()
    {
    }

    struct Planet
    {
        string name;
        int resolution;
        float radius;

        int noiseLayersLength;
        NoiseLayer[] noiseLayers;
    }

    struct NoiseLayer
    {
        bool enabled;
        bool useFirstLayerAsMask;

        NoiseSettings noiseSettings;
    }

    struct NoiseSettings
    {
        string filterType;

        float strength;
        int numLayers;
        float baseRoughness;
        float persistence;

        float CenterX;
        float CenterY;
        float CenterZ;

        float minValue;
        float weightMultiplier;
    }
}
