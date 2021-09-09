using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int bps = 3;

    public int firePower = 100;

    public static GameManager Instance;

    public float maxShootSpeed = .1f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("Multiple GameManager's instantiated.Component removed from" + gameObject);
            Destroy(this.gameObject);
        }
        
    }


}
