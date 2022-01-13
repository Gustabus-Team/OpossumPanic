using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZariIdleAnim : MonoBehaviour
{

    Animator idleAnimator;
    public bool IsInGame = false; 

    void Start()
    {
        idleAnimator = GetComponent<Animator>();
        if(IsInGame)
        {
            
           StartCoroutine(saludando());
        }
    }
    public string[] animations;
    public bool activado = true;
    IEnumerator saludando()
    {
        idleAnimator.SetBool("saludo", true);
        idleAnimator.SetBool("normal_idle", false);
        yield return new WaitForSeconds(3);
        idleAnimator.SetBool("saludo", false);
        idleAnimator.SetBool("normal_idle", true);
        yield return new WaitForSeconds(2);
        StartCoroutine(ActivateNewIdle());


        yield break;
    }
    public IEnumerator ActivateNewIdle()
    {
        while (activado)
        {

            string animToActivate = animations[Random.Range(0, 7)];
            print(animToActivate);
            //float randNum = Random.Range(min, max);

            idleAnimator.SetBool(animToActivate, true);
            idleAnimator.SetBool("normal_idle", false);
            yield return new WaitForSeconds(3);
            idleAnimator.SetBool(animToActivate, false);
            idleAnimator.SetBool("normal_idle", true);
            yield return new WaitForSeconds(2);

        }
        yield break;
    }

    public void ActivarMirarRopa()
    {
        StartCoroutine(MiraSuRopa());
    }


    public IEnumerator MiraSuRopa()
    {

        idleAnimator.SetBool("mirar_ropa", true);
        idleAnimator.SetBool("normal_idle", false);
        yield return new WaitForSeconds(2);
        idleAnimator.SetBool("mirar_ropa", false);
        idleAnimator.SetBool("normal_idle", true);

        yield break;
    }

}



