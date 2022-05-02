using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action OnTrigger ;

   
    public static void StartInstanEvent()
    {
        OnTrigger?.Invoke();
    }

    public static void Win()
    {
        OnTrigger?.Invoke();
    }

}
