using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    void Start()
    {
        SpawnTile(0);
        SpawnTile(1);
        SpawnTile(4);
    }

   
    void Update()
    {
        
    }
    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }
}
