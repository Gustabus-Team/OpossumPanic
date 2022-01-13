using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarTextura : MonoBehaviour
{

    public Material    [] texturas;
    public int numeroSkin;
    void Start()
    {
        numeroSkin = PlayerPrefs.GetInt("SkinActual");

        GetComponent<MeshRenderer>().material = texturas[numeroSkin];// texute("body", texturas[numeroSkin]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
