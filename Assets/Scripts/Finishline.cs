using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishline : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    float levelLoadTime = 0.8f;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",levelLoadTime);            
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
