using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TerrainDatabase : ScriptableObject
{
   public TerrainTypes[] terrains;

   public int terrainCount
   {
      get
      {
         return terrains.Length;
      }
   }

   public TerrainTypes GetTerrain(int index)
   {
      return terrains[index];
   }
}
