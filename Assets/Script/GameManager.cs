using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    /// Salto de Zarigueya
    public float alturaTorreZaris = 1.2f;   
    //2.3f;// 1.2f;
    /// </summary>
    public static GameManager _gameManager;
    public int dineroActual = 1000;
    public static int dineroTotal = 1000;
    public int NumeroDeZarigueyasEncima;

    public TextMeshProUGUI actualDinero;
    public TextMeshProUGUI actualDineroTienda;

    private void Awake()
    {
        _gameManager = this;
        dineroActual = dineroTotal;
    }
    public RectTransform loading;
   
    public void finalizaNivel()
    {
        dineroTotal = dineroActual;
        loading.DOAnchorPosY(0, 0.5f).OnComplete(() => SceneManager.LoadScene(0));

    }

    private void Start()
    {
        currentTime = startingTime;
        loading.DOAnchorPosY(2000, 0.5f);


    }
    public CinemachineVirtualCamera virturi;
    public int camerPost = 41;
    public void cameraMove()
    {
    
        CinemachineComponentBase componentBase = virturi.GetCinemachineComponent(CinemachineCore.Stage.Body);
        if (componentBase is CinemachineFramingTransposer)
        {
            (componentBase as CinemachineFramingTransposer).m_CameraDistance = camerPost; // your value
            camerPost++;
        }
    }

    public bool playingGame;
    void Update()
    {
        actualDinero.text = dineroActual.ToString();
        actualDineroTienda.text = dineroActual.ToString();

        //timer
        if (playingGame)
        {


            currentTime -= 1 * Time.deltaTime;
            countdownText.text = "00:" + currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                finalizaNivel();
            }
        }
    }

    float currentTime = 0f;
    float startingTime = 30;

    public TextMeshProUGUI countdownText;

   
    
}






