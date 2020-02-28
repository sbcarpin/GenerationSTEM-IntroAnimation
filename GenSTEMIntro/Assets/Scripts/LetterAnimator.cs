using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterAnimator : MonoBehaviour
{

    public float WaitBetween = 0.50f;
    public float WaitEnd = 1f;
    List<Animator> _animators;


    // Start is called before the first frame update
    void Start()
    {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());

        StartCoroutine(DoAnimation());
    }


    IEnumerator DoAnimation()
    {
        while (true)
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger("DoAnimation");
                yield return new WaitForSeconds(WaitBetween);
            }

            yield return new WaitForSeconds(WaitEnd);
        }
    }

}
