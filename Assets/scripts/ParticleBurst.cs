using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{

    // Start is called before the first frame update
    // variables
    public ParticleSystem collisionParticleSystem; // checks for the particlesystem
    public SpriteRenderer sr;               // references the sprite renderer(can be used to destroy wich i didnt use)
    public bool once = true;                // to acctivate the emmision via the code and not via unity it self(its toggled off in unity)
    public void OnTriggerEnter2D(Collider2D other)
    {
        // collision detection
        if (other.gameObject.CompareTag("Horizontalwall") && once)
        {
            // used to toggle emission on
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;
            //enables the whole emmision/makes it actualy happen
            em.enabled = true;
            collisionParticleSystem.Play();

   


        }
        // collision detection
        if (other.gameObject.CompareTag("Player") && once)
        {
            // used to toggle emission on
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;
            //enables the whole emmision/makes it actualy happen
            em.enabled = true;
            collisionParticleSystem.Play();
           

        }


    }
}