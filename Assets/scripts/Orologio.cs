using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Orologio : MonoBehaviour
{
    const float oreToGradi = -30f, minutiToGradi = -6f, secondiToGradi = -6f;

    [SerializeField]
    Transform pivotOre, pivotMinuti, pivotSecondi;

    void Update()
    {
        TimeSpan tempo = DateTime.Now.TimeOfDay;
        pivotOre.localRotation = Quaternion.Euler(0f, 0f, oreToGradi * (float)tempo.TotalHours);
        pivotMinuti.localRotation = Quaternion.Euler(0f, 0f, minutiToGradi * (float)tempo.TotalMinutes);
        pivotSecondi.localRotation = Quaternion.Euler(0f, 0f, secondiToGradi * (float)tempo.TotalSeconds);
    }

}
