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
    public void ReadStringInput()
    {
        int number = int.Parse(textfield1.text);
        gGenerator.Generate(number);
    }
    public void GetAreaofIntrest()
    {
       area = int.Parse(textfield2.text);
    }
}
