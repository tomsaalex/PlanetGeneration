using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteJSONToFile : MonoBehaviour
{
    public void WriteToFile()
    {
        SaveSystem.PlanetToJSON(SaveSystem.currentPlanet);
    }
}
