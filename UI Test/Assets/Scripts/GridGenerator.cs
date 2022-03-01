using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    private List<GameObject> prefabs = new List<GameObject>();
    public List<Text> Data = new List<Text>();

    public void GetTiles(int setTilesNo)   // get tiles number and call instantiation function
    {
        if(setTilesNo > 390)
        {
            return;
        }
        for (int i = 0; i < setTilesNo; i++)
        {
            TileGeneration();
        }
    }

    void TileGeneration()       // Instantiate the tiles
    {
        GameObject prefab = Instantiate(tilePrefab,gameObject.transform);
        prefabs.Add(prefab);
        AddData();
    }
    void AddData()           // Adding the data to the text component of tiles
    { 
        for (int i = 0; i < prefabs.Count; i++)
        {
            Text data = prefabs[i].GetComponentInChildren<Text>();
            if(data != null)
            {
                Data.Add(data);
                data.text = Random.Range(0,10).ToString();
                data.gameObject.SetActive(false);
            }
        }
    }
}
