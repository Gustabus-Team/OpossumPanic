using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : MonoBehaviour
{ 
    public int numeroNecesarioParaRomperse;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(GameManager._gameManager.NumeroDeZarigueyasEncima >= numeroNecesarioParaRomperse)
            {
                print("Se rompe");
            }
        }
    }

}
