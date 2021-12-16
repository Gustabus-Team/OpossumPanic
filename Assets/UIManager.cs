using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform cargandoPantalla;
    public RectTransform PanelConSkins;
    public RectTransform panelTienda;
    public Button skinsBoton;
    public Button tiendaBoton;
    private void Awake()
    {
        cargandoPantalla.gameObject.SetActive(true);
        StartCoroutine(cargando());
    }
    IEnumerator cargando()
    {
        yield return new WaitForSeconds(1);
        cargandoPantalla.DOAnchorPosY(2000, 0.5f);
        yield break;
    }

    public void BotonSkinsPresionado()
    {
        skinsBoton.interactable = false;
        tiendaBoton.interactable = false;
        PanelConSkins.DOAnchorPosX(0, 0.5f);
    }
    public void BotonTiendaPresionado()
    {
        skinsBoton.interactable = false;
        tiendaBoton.interactable = false;
        panelTienda.DOAnchorPosX(0, 0.5f);
    }
    public void BotonVolverPresionado()
    {
        skinsBoton.interactable = true;
        tiendaBoton.interactable = true;
        PanelConSkins.DOAnchorPosX(-2000, 0.5f);
        panelTienda.DOAnchorPosX(2000, 0.5f);
    }
   

}
