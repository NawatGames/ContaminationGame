using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int rows = 6;
    [SerializeField] private int cols = 6;
    [SerializeField] private float tilesize = 1;
    [SerializeField] private GameObject prefab_plains;
    [SerializeField] private GameObject prefab_forest;
    [SerializeField] private GameObject prefab_rivers;
    [SerializeField] private GameObject prefab_mountains;
    [SerializeField] private GameObject prefab_cities;
    
    private Dictionary<int, GameObject> tileset;
    private Dictionary<int, GameObject> tile_groups;
    
    void Start()
    {
        CreateTileset();
        GenerateGrid();
    }

    
    private void CreateTileset()
    {
        /*  Collect and assign ID codes to the tile prefabs, for ease of access. 
            Best ordered to match land elevation.  */
        
        tileset = new Dictionary<int, GameObject>();
        tileset.Add(0, prefab_plains);
        tileset.Add(1, prefab_forest);
        tileset.Add(2, prefab_rivers);
        tileset.Add(3, prefab_cities);
        tileset.Add(4, prefab_mountains);
    }
    
    
    private void GenerateGrid()
    {   
        GameObject referenceTile = (GameObject) Instantiate(tileset[Random.Range(0, 5)]);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                GameObject tile = (GameObject) Instantiate(tileset[Random.Range(0, 5)], transform);

                float posX = col * tilesize;
                float posY = row * -tilesize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(referenceTile);
        
        float gridW = cols * tilesize;
        float gridH = rows * tilesize;
        transform.position = new Vector2(-gridW / 2 + tilesize / 2, gridH / 2 - tilesize / 2);
    }
}