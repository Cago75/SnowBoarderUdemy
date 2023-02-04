using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticles : MonoBehaviour
{
    bool isInContact;
    [SerializeField] ParticleSystem dustEffect;
    // Update is called once per frame

    void Update()
    {
        //Debug.Log(isInContact);
        //DoDustEffect();
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dustEffect.Play();
            //isInContact = true; 
            //Debug.Log("touchdown");
        }
           
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
             dustEffect.Stop();
            //isInContact = false; 
            //Debug.Log("untouch");
        }
             
    }
    void DoDustEffect()
    {
        if(isInContact && dustEffect.isPaused)
        {
            dustEffect.Play();
        }
        else if (dustEffect.isPlaying)
        {
            dustEffect.Pause();
        }
    }

}
