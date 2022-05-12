using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TerrainDatabase : ScriptableObject
{
    public TerrainTypes[] TerrainTypesArray;
    
    public int terrainCount
    {
        get
        {
            return TerrainTypesArray.Length;
        }
    }

    public TerrainTypes GetTerrain(int index)
    {
        return TerrainTypesArray[index];
    }
}
