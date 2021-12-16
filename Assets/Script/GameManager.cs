using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    /// Salto de Zarigueya
    public float alturaTorreZaris = 1.2f;   
    //2.3f;// 1.2f;
    /// </summary>
    public static GameManager _gameManager;
    public int dineroActual = 1000;
    public static int dineroTotal;
    public int NumeroDeZarigueyasEncima;

    public TextMeshProUGUI actualDinero;
    private void Awake()
    {
        _gameManager = this;
    }
    public void finalizaNivel()
    {

    }
    private void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        actualDinero.text = dineroTotal.ToString();
        //timer
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }

    float currentTime = 0f;
    float startingTime = 30;

    public TextMeshProUGUI countdownText;

   
    
}






