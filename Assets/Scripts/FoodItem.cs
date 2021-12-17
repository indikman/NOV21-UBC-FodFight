using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : ThrowableObject
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
            GameManager.instance.TargetHit();

            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
