using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{

    // Start is called before the first frame update
    public ParticleSystem collisionParticleSystem;
    public SpriteRenderer sr;
    public bool once = true;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Horizontalwall") && once)
        {
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

   


        }
        
        if (other.gameObject.CompareTag("Player") && once)
        {
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();
       
     
  

        }


    }




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}