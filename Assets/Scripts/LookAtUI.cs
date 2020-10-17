using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtUI : MonoBehaviour
{
    Transform m_centerEyeAnchor;

    private void Start()
    {
        m_centerEyeAnchor = GameObject.Find("CenterEyeAnchor").transform;
    }

    private void Update()
    {
        transform.LookAt(m_centerEyeAnchor);
    }
}
