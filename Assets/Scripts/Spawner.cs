using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] heavyOnes;
    private bool inst = false;
    private void Start()
    {
        EventManager.OnTrigger += TriggerIt;
    }
   
    private void TriggerIt()
    {
        Instantiate(heavyOnes[Random.Range(0,heavyOnes.Length)], transform.position, Quaternion.identity);
    }
    private void OnDisable()
    {
        EventManager.OnTrigger -= TriggerIt;
    }

}
