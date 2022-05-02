using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject player;
    SwipeManagerAndCarMovement movement;

    private void Start()
    {
        movement = player.GetComponent<SwipeManagerAndCarMovement>();
    }
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag ==("Player") )
        {
            gameManager.CompleteLevel();
            movement.enabled = false;
        }
    }
}
