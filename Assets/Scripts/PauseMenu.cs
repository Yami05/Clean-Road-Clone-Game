using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public Animator transition;


    public AudioSource ButtonSound;
    public void retry()
    {
        ButtonSound.Play();
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
        
    }
    public void Home()
    {
        ButtonSound.Play();
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex-1));
        
    }
    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelIndex);
    }
}
