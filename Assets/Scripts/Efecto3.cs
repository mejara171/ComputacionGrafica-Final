using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efecto3 : MonoBehaviour
{
    [SerializeField] ParticleSystem particula;
    [SerializeField] GameObject objetoparticula;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Keypad3)|| Input.GetKeyDown(KeyCode.Alpha3))
        {
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("efecto activo ");
        objetoparticula.transform.position = new Vector3(transform.position.x, transform.position.y - 0.23f, transform.position.z);
        particula.Play(true);

    }

    public void StartEffect()
    {
        transform.position = new Vector3(transform.position.x, 2, transform.position.z);
        Debug.Log("efecto");
    }
}
