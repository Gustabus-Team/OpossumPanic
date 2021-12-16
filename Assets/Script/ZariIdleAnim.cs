using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZariIdleAnim : MonoBehaviour
{

    Animator idleAnimator;

    void Start()
    {
        idleAnimator = GetComponent<Animator>();
        StartCoroutine(ActivateNewIdle(3,5, "mirar_atras"));
    }

    public IEnumerator ActivateNewIdle(float min, float max, string animToActivate)
    {
        float randNum = Random.Range(min, max);

        idleAnimator.SetBool(animToActivate, true);
        idleAnimator.SetBool("normal_idle", false);
        yield return new WaitForSeconds(randNum);
        idleAnimator.SetBool(animToActivate, false);
        idleAnimator.SetBool("normal_idle", true);

        yield break;
    }



}
