using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    Transform planet;

    private void Start()
    {
        planet = this.gameObject.transform;
    }
    void Update()
    {
        float speedX = Input.GetAxis("Horizontal");
        float speedY = Input.GetAxis("Vertical");
        Debug.Log(speedX);
        Debug.Log(speedY);
        planet.Rotate(speedY, -speedX, 0, Space.World);
    }
}
