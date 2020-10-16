using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class ReturnCoinScript : MonoBehaviour
{
    private Vector3 OriginTransformPosition;
    private Quaternion OriginTransformRotation;

    private DistanceGrabbable distanceGrabbable;
    private GrabbableCrosshair grabbableCrosshair;
    private Rigidbody rb;

    private void Start()
    {
        OriginTransformPosition = this.transform.position;
        OriginTransformRotation = this.transform.rotation;
        distanceGrabbable = this.gameObject.GetComponent<DistanceGrabbable>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!distanceGrabbable.isGrabbed && !distanceGrabbable.onShowCase)
        {
            distanceGrabbable.onShowCase = true;
            rb.isKinematic = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            this.transform.position = OriginTransformPosition;
            this.transform.rotation = OriginTransformRotation;
        }
    }
}
