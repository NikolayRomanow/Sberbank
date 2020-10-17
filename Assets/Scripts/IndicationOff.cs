using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicationOff : MonoBehaviour
{
    public Animator IndicationLeft, IndicationRight;
    public GameObject LocalAvatar, LeftHand, RightHand;

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Any) && LocalAvatar.activeSelf)
        {
            StartCoroutine(StopIndication());
            StartCoroutine(ReplacementHand());
        }
    }

    IEnumerator StopIndication()
    {
        yield return new WaitForSeconds(1f);
        IndicationLeft.SetTrigger("Off");
        IndicationRight.SetTrigger("Off");
    }

    IEnumerator ReplacementHand()
    {
        yield return new WaitForSeconds(2f);
        LocalAvatar.SetActive(false);
        LeftHand.SetActive(true);
        RightHand.SetActive(true);
    }

}
