using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetPrefab;

    public static GameManager instance;

    private void Awake()
    {
        if(instance!=null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void TargetHit()
    {
        Debug.Log("HIT!");

        //Instantiate another new target in the scene
    }
}
