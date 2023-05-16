using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] GameObject effect1GameObject;
    [SerializeField] GameObject effect2GameObject;
    [SerializeField] GameObject effect3GameObject;

    [SerializeField] StartEffectLvlUp effectLvlUp;

    [SerializeField] ControlEffect1 controlEffect1;

    [SerializeField] Efecto3 efecto3;

    // Start is called before the first frame update
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

        StartCoroutine(PlayEffect1Delay());
        effectLvlUp.stopEffect();
    }

    public void PlayEffect2()
    {



        effect1GameObject.SetActive(false);
        effect2GameObject.SetActive(true);
        effect3GameObject.SetActive(false);

        effectLvlUp.StartEffect();
    }

    public void PlayEffect3()
    {
        effectLvlUp.stopEffect();

        effect1GameObject.SetActive(false);
        effect2GameObject.SetActive(false);
        effect3GameObject.SetActive(true);

        efecto3.StartEffect();
    }

    IEnumerator PlayEffect1Delay()
    {
        yield return new WaitForSeconds(0.1f);
        controlEffect1.StartEffect();
    }
}
