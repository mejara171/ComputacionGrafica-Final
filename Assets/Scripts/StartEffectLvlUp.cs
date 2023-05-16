using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class StartEffectLvlUp : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] VisualEffect particleSystem;
    [SerializeField] GameObject effect2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            StartEffect();
        }

        if (Input.GetKey(KeyCode.S))
        {
            stopEffect();
        }
    }

    public void StartEffect()
    {
        effect2.SetActive(true); ;
        particleSystem.Play();
        animator.SetTrigger("StartAnimation");

    }

    public void stopEffect()
    {
        effect2.SetActive(false);
        animator.ResetTrigger("StartAnimation");
    }
}
