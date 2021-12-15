using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Edificios : MonoBehaviour
{ 
    public int numeroNecesarioParaRomperse;
    public Transform zarigueyita;
    public bool seActivo = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(GameManager._gameManager.NumeroDeZarigueyasEncima >= numeroNecesarioParaRomperse && seActivo == false)
            {
                print("Se rompe");
                zarigueyita.parent = other.transform;
                zarigueyita.transform.DOLocalJump(new Vector3(other.transform.localPosition.x, GameManager._gameManager.alturaTorreZaris, other.transform.localPosition.z), 5, 1, 0.5f);
                GameManager._gameManager.alturaTorreZaris += 1.2f;
                zarigueyita.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                seActivo = true;
            //    jumpFallOpossum += 0.8f;
            }
        }

    }

}
