using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    public List<GameObject> prefabs = new List<GameObject>();
    public List<Text> Data = new List<Text>();
    public int setTilesNo = 0;

    public void Generate(int setTilesNo)
    {
        for (int i = 0; i < setTilesNo; i++)
        {
            TileGeneration();
        }
    }

    void TileGeneration()
    {
        GameObject prefab = Instantiate(tilePrefab,gameObject.transform);
        prefabs.Add(prefab);
        AddData();
    }
    void AddData()
    { 
        for (int i = 0; i < prefabs.Count; i++)
        {
            Text data = prefabs[i].GetComponentInChildren<Text>();
            if(data != null)
            {
                Data.Add(data);
                data.text = (i+1).ToString();
                data.gameObject.SetActive(false);
            }
        }
    }
}
