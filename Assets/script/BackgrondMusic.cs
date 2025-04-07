using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrondMusic : MonoBehaviour
{
    private static BackgrondMusic backgroundMusic;

    void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    
}
