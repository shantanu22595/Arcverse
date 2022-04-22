using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TerrainManager : MonoBehaviour
{

    public TerrainDatabase terrainDatabase;
    public Image terrainSprite;



    private int selectedOption = 0;
    
    private void Start()
    {
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateTerrain(selectedOption);
    }


    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= terrainDatabase.terrainCount)
        {
            selectedOption = 0;
        }
        UpdateTerrain(selectedOption);
        Save();
    }

    public void PreviousOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = terrainDatabase.terrainCount - 1;
        }
        UpdateTerrain(selectedOption);
        Save();
    }
    

    private void UpdateTerrain(int selectedOption)
    {
        TerrainTypes terrainTypes = terrainDatabase.GetTerrain(selectedOption);
        terrainSprite.sprite = terrainTypes.sprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void LoadScene()
    {
        TerrainTypes terrainTypes = terrainDatabase.GetTerrain(selectedOption);
        SceneManager.LoadScene("Scene");
    }
}