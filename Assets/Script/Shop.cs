using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int numeroADesbloquear;
   // public Button compra;
    public Button[] botonADesbloquear;
    public Button[] botonYaUsado;


    public void Awake()
    {
        if(PlayerPrefs.GetInt("boton1") == 1)
        {
            botonADesbloquear[1].interactable = true;
            botonYaUsado[1].interactable = false;
        }
        if (PlayerPrefs.GetInt("boton2") == 1)
        {
            botonADesbloquear[2].interactable = true;
            botonYaUsado[2].interactable = false;
        }
        if (PlayerPrefs.GetInt("boton3") == 1)
        {
            botonADesbloquear[3].interactable = true;
            botonYaUsado[3].interactable = false;

        }
        if (PlayerPrefs.GetInt("boton4") == 1)
        {
            botonADesbloquear[4].interactable = true;
            botonYaUsado[4].interactable = false;
        }
        if (PlayerPrefs.GetInt("boton5") == 1)
        {

            botonADesbloquear[5].interactable = true;
            botonYaUsado[5].interactable = false;
        }
        if (PlayerPrefs.GetInt("boton6") == 1)
        {
            botonADesbloquear[6].interactable = true;
            botonYaUsado[6].interactable = false;
        }
    }

    public void SkinADesbloquear(int numeroDesbloqueado)
    {
        numeroADesbloquear = numeroDesbloqueado;
    }
    public void ComprandoSkin(int precio)
    {
        if(GameManager._gameManager.dineroActual >= precio)
        {
            GameManager._gameManager.dineroActual -= precio;
            botonADesbloquear[numeroADesbloquear].interactable = true;
            botonYaUsado[numeroADesbloquear].interactable = false;
            if(numeroADesbloquear ==1)
            {
                PlayerPrefs.SetInt("boton1", 1);
            }
            else if(numeroADesbloquear == 2)
            {
                PlayerPrefs.SetInt("boton2", 1);

            }
            else if (numeroADesbloquear == 3)
            {
                PlayerPrefs.SetInt("boton3", 1);

            }
            else if (numeroADesbloquear == 4)
            {
                PlayerPrefs.SetInt("boton4", 1);

            }
            else if (numeroADesbloquear == 5)
            {
                PlayerPrefs.SetInt("boton5", 1);

            }
            else if (numeroADesbloquear == 6)
            {
                PlayerPrefs.SetInt("boton6", 1);

            }






        }




    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
