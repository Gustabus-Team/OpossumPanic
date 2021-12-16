using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZariIdleAnim : MonoBehaviour
{

    Animator idleAnimator;

    void Start()
    {
        idleAnimator = GetComponent<Animator>();
    }

    public IEnumerator ActivateNewIdle(float min, float max)
    {
        float randNum = Random.Range(min, max);

        idleAnimator.SetBool("head_Idle", true);
        yield return new WaitForSeconds(randNum);
        idleAnimator.SetBool("head_Idle", false);

        yield break;
    }
}
