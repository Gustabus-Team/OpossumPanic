using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform PanelConSkins;
    public Button skinsBoton;
    public Button tiendaBoton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonTiendaPresionado()
    {
        skinsBoton.interactable = false;
        tiendaBoton.interactable = false;
        PanelConSkins.DOAnchorPosX(0, 0.5f);
    }
    public void BotonVolverPresionado()
    {
        skinsBoton.interactable = true;
        tiendaBoton.interactable = true;
        PanelConSkins.DOAnchorPosX(-2000, 0.5f);

    }

}
