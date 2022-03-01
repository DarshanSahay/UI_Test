using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataGenerator : MonoBehaviour
{
    public UIHandler handler;
    private Color tileColor;
    public Image buttonImage;
    public int noOfClicks;
    public Button tile;
    public Text data;
    public int areaOfInterest;

    void Start()
    {
        tile.onClick.AddListener(OnClick);
        buttonImage = GetComponent<Image>();
        tileColor = GetRandomColour32();
        handler = FindObjectOfType<UIHandler>();
    }
    void Update()
    {
        if (noOfClicks == 0)
        {
            buttonImage.color = Color.white;
        }
        if (noOfClicks == 1)
        {
            buttonImage.color = tileColor;
        }
    }
    public void OnClick()       //function to show data on clicking tile
    {
        areaOfInterest = handler.area;
        Collider2D[] tiles = Physics2D.OverlapBoxAll(transform.position, new Vector2(115f * areaOfInterest , 115f * areaOfInterest) ,0f); //get the required tiles to show data for
        foreach (Collider2D item in tiles)
        {
            if(item != null)
            {
                DataGenerator gen = item.GetComponent<DataGenerator>();
                gen.noOfClicks = 1;
                if (gen != null)
                {
                    gen.data.gameObject.SetActive(true);
                }
            }
        }
        if (noOfClicks == 0)
        {
            noOfClicks = 1;
        }
    }
    private Color32 GetRandomColour32()               //get random color
    {
                                                      //using Color32
        return new Color32(
          (byte)UnityEngine.Random.Range(0, 255),     //Red
          (byte)UnityEngine.Random.Range(0, 255),     //Green
          (byte)UnityEngine.Random.Range(0, 255),     //Blue
          255                                         //Alpha (transparency)
        );
    }
}
