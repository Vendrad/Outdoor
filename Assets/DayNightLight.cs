using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightLight : MonoBehaviour
{
    public int initX;
    public int initY;
    public int initZ;
    public float x;
    public int y;
    public int z;

    private void Start()
    {
        if (initX == 0 && initY == 0 && initZ == 0) return;
        transform.rotation = Quaternion.Euler(new Vector3(initX, initY, initZ));
    }

    void Update()
    {
        transform.Rotate(new Vector3(x, y, z));
    }
}