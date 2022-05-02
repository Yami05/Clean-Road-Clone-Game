using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MusicScript : MonoBehaviour
{
    public GameObject soundManager;

    public static MusicScript instance;
    
    void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(soundManager);
            return;
        }

        DontDestroyOnLoad(soundManager);
    }

  
   
}
