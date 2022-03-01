using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Camera mainCamera;
    public Slider zoomSlider;
    public GridGenerator gGenerator;
    public int area;
    public Text textfield1;
    public Text textfield2;

    void Update()
    {
        mainCamera.orthographicSize = zoomSlider.value;
    }
    public void ReadStringInput(int no)
    {
        no = int.Parse(textfield1.text);
        gGenerator.GetTiles(no);
    }
    public void GetAreaofIntrest(int data)
    {
       area = data;
       area = int.Parse(textfield2.text);
    }
}
