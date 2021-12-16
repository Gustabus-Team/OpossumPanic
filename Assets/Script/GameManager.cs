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

    
    private void Awake()
    {
        _gameManager = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }






}
