using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinsDezaris : MonoBehaviour
{
    public SkinnedMeshRenderer ZarigueyaPlayer;
    public SkinnedMeshRenderer ZarigueyaCria;
    public Material[] texturas;

   

    public void Awake()
    {
        ZarigueyaPlayer.material = texturas[PlayerPrefs.GetInt("SkinActual")];
        ZarigueyaCria.material = texturas[PlayerPrefs.GetInt("SkinActual")];

    }
}
