using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScale : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    public Material Material;
    
    
    float scale = 1;
    

    [SerializeField] Slider sizeSlider;
    [SerializeField] Slider ColorRSlider;
    [SerializeField] Slider ColorGSlider;
    [SerializeField] Slider ColorBSlider;

    public void Start()
    {
        sizeSlider.value = 1;
        ColorRSlider.value = 0;
        ColorGSlider.value = 0;
        ColorBSlider.value = 0;

        Material.color = new Color(ColorRSlider.value, ColorGSlider.value, ColorBSlider.value);
    }

    public void Update()
    {
        ChangeScale();
        ChangeColor();
    }


    public void ChangeScale()
    {
        scale = sizeSlider.value;

        object1.transform.localScale = new Vector3(scale, scale, scale);
        object2.transform.localScale = new Vector3(scale, scale, scale);
        object3.transform.localScale = new Vector3(scale, scale, scale);
    }

    public void ChangeColor()
    {
        Material.color = new Color(ColorRSlider.value, ColorGSlider.value, ColorBSlider.value);
    }

    public void DefaultSize()
    {
        sizeSlider.value = 1;

        object1.transform.localScale = new Vector3(1, 1, 1);
        object2.transform.localScale = new Vector3(1, 1, 1);
        object3.transform.localScale = new Vector3(1, 1, 1);
    }

}
