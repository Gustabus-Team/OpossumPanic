using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public RectTransform cargandoPantalla;
    public RectTransform PanelConSkins;
    public RectTransform panelTienda;
    public Button skinsBoton;
    public Button tiendaBoton;
    public GameObject Tutorial;
    public GameObject botonTutorial;

    public GameObject zariPlayer;

    private void Awake()
    {
       // PlayerPrefs.DeleteAll();
        if(PlayerPrefs.GetInt("PrimerInicio") == 0)
        {
            zariPlayer.gameObject.SetActive(false);
            botonTutorial.SetActive(false); 
            Tutorial.SetActive(true);
            StartCoroutine(BotontTutorial());
            PlayerPrefs.SetInt("PrimerInicio", 1);
        }
        cargandoPantalla.gameObject.SetActive(true);
        StartCoroutine(cargando());
    }
    IEnumerator BotontTutorial()
    {
        yield return new WaitForSeconds(3);
        botonTutorial.SetActive(true);
        yield break;
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
        zarimedio.transform.DOMoveY(-800, 0.5f);

    }
    public void BotonTiendaPresionado()
    {
        skinsBoton.interactable = false;
        tiendaBoton.interactable = false;
        panelTienda.DOAnchorPosX(0, 0.5f);
        zarimedio.transform.DOMoveY(-800, 0.5f);

    }
    public void BotonVolverPresionado()
    {
        skinsBoton.interactable = true;
        tiendaBoton.interactable = true;
        PanelConSkins.DOAnchorPosX(-2000, 0.5f);
        panelTienda.DOAnchorPosX(2000, 0.5f);
        zarimedio.transform.DOLocalMoveY(0, 0.5f);
        
    }
    public GameObject zarimedio;

    public RectTransform conjuntoDeBotones;
    public void empezarJuego()
    {
        cargandoPantalla.DOAnchorPosY(0, 0.5f).OnComplete(()=> SceneManager.LoadScene(1));
       
    }
   

}
