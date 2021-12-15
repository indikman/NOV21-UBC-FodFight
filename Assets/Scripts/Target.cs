using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float movementAmplitude;
    public float spinAmount;
    public float speed;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;

        newPosition.x = startPosition.x + Mathf.Sin(Time.time * speed) * movementAmplitude;
        newPosition.y = startPosition.x + Mathf.Sin(Time.time * speed) * spinAmount;

        transform.position = newPosition;

    }
}
