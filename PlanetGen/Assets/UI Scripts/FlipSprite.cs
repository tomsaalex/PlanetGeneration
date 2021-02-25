using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    public float angleToFlip;
    public GameObject spriteToFlip;

    Vector3 flipAngle;

    private void Start()
    {
        flipAngle = new Vector3(0, 0, angleToFlip);
    }

    public void Flip()
    {
        spriteToFlip.transform.Rotate(flipAngle);
        flipAngle *= -1;
    }

    void OnEnable()
    {
        if (flipAngle.z < 0)
            Flip();
    }
}
