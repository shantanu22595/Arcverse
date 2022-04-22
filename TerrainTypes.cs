using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TerrainTypes
{
    public float noiseHeightMultiplierValue;
    public float noiseScale;
    public Sprite sprite;

    private GenTest _genTest;

    public void ChangeValue()
    {
        _genTest.noiseScale = noiseScale;
        _genTest.noiseHeightMultiplier = noiseHeightMultiplierValue;
    }
}
