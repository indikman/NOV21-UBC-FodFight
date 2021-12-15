using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : ThrowableObject
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
            Destroy(gameObject);

            Debug.Log("Hit!!!");
        }
    }
}
