using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect2Intensity : MonoBehaviour
{
    [SerializeField] Material glowMaterial;
    [SerializeField] Material escudoMaterial;
    [SerializeField] Material caidaMaterial;

    public float MyIntensityEffect1; //between -0.5 and 4 for MAX MIN
    public float MyIntensityEffect2; //between -0.5 and 4 for MAX MIN

    float mySizeEffect1;


    [SerializeField] Slider intensitySlider;
    [SerializeField] Slider sizeSlider;

    [SerializeField] List<GameObject> Effect1GameObjects = new List<GameObject>();

    [SerializeField] List<GameObject> Effect2GameObjects = new List<GameObject>();

    [SerializeField] List<GameObject> Effect3GameObjects = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Efecto1Intensity();
        Efecto2Intensity();
        Efecto3Intensity();

        Efecto1Size();

        Efecto2Size();

        Efecto3Size();

    }

    void Efecto1Size()
    {
        mySizeEffect1 = 0.75f + sizeSlider.value * 1.25f ;

        foreach (var item in Effect1GameObjects)
        {
            item.transform.localScale = new Vector3(1 * mySizeEffect1, 1 * mySizeEffect1, 1 * mySizeEffect1);
        }
    }

    void Efecto2Size()
    {
        float mySizeEffect2 = 0.25f+sizeSlider.value;
        mySizeEffect2 = mySizeEffect2 / 2;

        float divider0 = 2.5f;
        float divider1 = 6;
        float divider2 = 8;

        Effect2GameObjects[0].transform.localScale = new Vector3(1 * mySizeEffect2* divider0, 1 * mySizeEffect2* divider0, 1 * mySizeEffect2* divider0);
        Effect2GameObjects[1].transform.localScale = new Vector3(1 * mySizeEffect2/ divider1, 1 * mySizeEffect2/ divider1, 1 * mySizeEffect2/ divider1);
        Effect2GameObjects[2].transform.localScale = new Vector3(1 * mySizeEffect2/ divider2, 1 * mySizeEffect2/ divider2, 1 * mySizeEffect2/ divider2);
    }

    void Efecto3Size()
    {

        float mySizeEffect3 = 0.55f + sizeSlider.value * 1.75f;

        foreach (var item in Effect3GameObjects)
        {
            item.transform.localScale = new Vector3(1 * mySizeEffect3, 1 * mySizeEffect3, 1 * mySizeEffect3);
        }
    }

    void Efecto1Intensity()
    {

        MyIntensityEffect2 = 0.5f*intensitySlider.value * 8;

        escudoMaterial.SetFloat("_interfecsionfallout", MyIntensityEffect2);
        escudoMaterial.SetFloat("_Rimfallof", 0.5f*intensitySlider.value*2+0.84f);
    }
    void Efecto2Intensity()
    {
        MyIntensityEffect1 = intensitySlider.value * -3 + 2.5f;

        glowMaterial.SetFloat("_Intensity", MyIntensityEffect1);

    }

    void Efecto3Intensity()
    {

        caidaMaterial.SetFloat("_Intensity", intensitySlider.value*3f);
    }
}
