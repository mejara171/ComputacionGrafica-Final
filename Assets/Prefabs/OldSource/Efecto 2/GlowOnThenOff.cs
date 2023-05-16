using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowOnThenOff : MonoBehaviour
{
    [SerializeField] Material glowMaterial;
    [SerializeField] Color color;
    [SerializeField] Color glowColor;

    // Start is called before the first frame update
    void Start()
    {
        glowMaterial.SetColor("_Color", color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
