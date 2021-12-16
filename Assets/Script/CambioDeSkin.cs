using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeSkin : MonoBehaviour
{
    public Material[] texturas;
    public SkinnedMeshRenderer SkinesZarigueya;
    public SkinnedMeshRenderer ZarigueyaPlayer;
    public SkinnedMeshRenderer ZarigueyaCria;
    public int SkinActual;
    public void BotonCambioSkin(int seleccionTraje)
    {
        SkinesZarigueya.material = texturas[seleccionTraje];
        SkinActual = seleccionTraje;
        PlayerPrefs.SetInt("SkinActual", SkinActual);
    }

    private void Awake()
    {
        SkinesZarigueya.material = texturas[PlayerPrefs.GetInt("SkinActual")];
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
