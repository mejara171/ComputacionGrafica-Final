using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] GameObject effect1GameObject;
    [SerializeField] GameObject effect2GameObject;
    [SerializeField] GameObject effect3GameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayEffect1()
    {
        effect1GameObject.SetActive(true);
        effect2GameObject.SetActive(false);
        effect3GameObject.SetActive(false);
    }

    public void PlayEffect2()
    {
        effect1GameObject.SetActive(false);
        effect2GameObject.SetActive(true);
        effect3GameObject.SetActive(false);   
    }

    public void PlayEffect3()
    {
        effect1GameObject.SetActive(false);
        effect2GameObject.SetActive(false);
        effect3GameObject.SetActive(true);
    }

}
