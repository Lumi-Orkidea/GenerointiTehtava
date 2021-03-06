using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make your generation algorithm here
public class Generate : MonoBehaviour {

    public TileType[] tileTypes; // all the tiletypes given in the editor
    public GameObject player;
    public GameObject enemy;

    //the size of the generated map
    private int mapSizeX = 10;
    private int mapSizeY = 10;



    
    void Start()
    {
        GenerateMap();
    }
    
    /*
     * Generates a map
     * Currently just a green field with a player and an enemy
     */ 
    void GenerateMap()
    {
        for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                TileType tt = tileTypes[0];
                GameObject go =Instantiate(tt.tileVisual, new Vector3(x, y,0), Quaternion.identity);
            }
        }
        GameObject newPlayer = Instantiate(player, new Vector3(0,0,-0.5f),Quaternion.identity); //spawn one player
        GameObject newEnemy = Instantiate(enemy, new Vector3(9, 9, -0.5f), Quaternion.identity); //and one enemy
    }
}
