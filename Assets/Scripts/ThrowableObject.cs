using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : GrabbableObject
{
    public float shootForce;

    private Transform handTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnHoverStart()
    {
       base.OnHoverStart();
    }

    public override void OnHoverEnd()
    {
        base.OnHoverEnd();
    }

    public override void OnGrabStart(XRHand hand)
    {
         base.OnGrabStart(hand);

         handTransform = hand.transform;
    }

    public override void OnGrabEnd()
    {
        base.OnGrabEnd();

        // Shoot the object
        GetComponent<Rigidbody>().AddForce(shootForce * handTransform.forward);
    }
}
