using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TerrainManager : MonoBehaviour
{
    public TerrainDatabase terrainD;
    public Image terrainSprite;

    private int selectOption = 0;

    private void Start()
    {
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectOption = 0;
        }
        else
        {
            Load();
        }
        UpdateTerrain(selectOption);
    }
    
    

    public void PreviousOption()
    {
        selectOption--;
        if (selectOption < 0)
        {
            selectOption = terrainD.terrainCount - 1;
        }
        UpdateTerrain(selectOption);
        Save();
    }
    

    private void UpdateTerrain(int selectedOption)
    {
        TerrainTypes terrainTypes = terrainD.GetTerrain(selectedOption);
        terrainSprite.sprite = terrainTypes.sprite;
    }
    
    private void Load()
    {
        selectOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectOption);
    }

    public void LoadScene()
    {
        TerrainTypes terrainTypes = terrainD.GetTerrain(selectOption);
        SceneManager.LoadScene("MainMenu");
    }
    
    public void NextOption()
    {
        selectOption++;
        if (selectOption >= terrainD.terrainCount)
        {
            selectOption = 0;
        }
        UpdateTerrain(selectOption);
        Save();
    }
}
