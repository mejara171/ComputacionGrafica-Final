using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlEffect1 : MonoBehaviour
{
    [SerializeField] ParticleSystem particula;
    Animator animator;
    private int EscudoActive;
    bool Activete=true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        EscudoActive= Animator.StringToHash("escudo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1) && Activete)
        {
            Activete = false;
            animator.SetTrigger(EscudoActive);
            if (particula != null)
             
            particula.Play(true);
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(3f);
        animator.SetTrigger(EscudoActive);
        yield return new WaitForSeconds(3f);

        Activete = true;
    }

    public void StartEffect()
    {
        Activete = false;
        animator.SetTrigger(EscudoActive);
        if (particula != null)

            particula.Play(true);
        StartCoroutine(Fade());
    }
}
