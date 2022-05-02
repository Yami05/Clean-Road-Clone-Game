using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    bool timerActive;
    float start;
    float currentTime;

    public AudioSource saveCar;
    public AudioSource[] Collision;
    public CameraManager cameraShake;
    private void Start()
    {
        start = 1;
        currentTime = start * 5;
    }
    private void Update()
    { 
       
        if (timerActive==true)
        {
            currentTime = currentTime - Time.deltaTime;
            Debug.Log(currentTime);
        }
    }
    private void OnTriggerEnter(Collider cell)
    {
        if (cell.gameObject.tag == ("CellPart"))
        {
            Destroy(cell.gameObject, 0);
        }
        if (cell.gameObject.tag == ("Obstacle"))
        {
            Destroy(cell.gameObject);
            saveCar.Play();
        }
      


    }
    public void OnCollisionEnter(Collision col)
    {
      
        if (col.gameObject.tag == ("object"))
        {
            Collision[Random.Range(0, Collision.Length)].Play();
             StartCoroutine(cameraShake.Shake(.10f,5f));
           
        }


    }

    
     

}
    

   
