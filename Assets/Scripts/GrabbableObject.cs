using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    public MeshRenderer rend;
    public Color hoveredColor;

    private Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHoverStart()
    {
        rend.material.color = hoveredColor;
    }

    public void OnHoverEnd()
    {
        rend.material.color = defaultColor;
    }

    public void OnGrabStart(XRHand hand)
    {
        transform.SetParent(hand.transform);
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    public void OnGrabEnd()
    {
        transform.SetParent(null);
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
