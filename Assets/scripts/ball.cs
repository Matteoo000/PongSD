using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class ball : MonoBehaviour



{   
    public AudioClip BallHitSound;
    private AudioSource audioSource;
    public TMP_Text Scoreboard;
    
    private int leftscore = 0;
    private int rightscore = 0;
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float Xspeed;
    public float Yspeed;
  


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);
        Xspeed = 3f;
        Yspeed = 3f;

        // Audio
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = BallHitSound;
        
    }



    // Update is called once per frame
    void Update()
    {
        Scoreboard.text = leftscore + " - " + rightscore;
        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Horizontalwall"))



        {
            Yspeed = Yspeed * -1;
           
            audioSource.Play();
        }



        if (collision.gameObject.CompareTag("Leftwall"))
        {
            rightscore++;
            Xposition = 0;
            Yposition = 0;
            Yspeed = 3f;
            Xspeed = 3f;
            audioSource.Play();
        }





        if (collision.gameObject.CompareTag("Rightwall"))
        {
            leftscore++;
            Xposition = 0;
            Yposition = 0;
            Yspeed = 0;
            Xspeed = 0;
            Yspeed = 3f;
            Xspeed = -3f;
            audioSource.Play();
        }



        Scoreboard.text = leftscore.ToString() + " - " + rightscore.ToString();



        if (leftscore >= 5)
        {
            SceneManager.LoadScene(2);
        }



        if (rightscore >= 5)
        {
            SceneManager.LoadScene(3);
        }



        if (collision.gameObject.CompareTag("Player"))
        {
            Xspeed = Xspeed * -1.1f;
            audioSource.Play();
        }
        Scoreboard.text = leftscore.ToString() + " - " + rightscore.ToString();

        if (leftscore >= 5)
        {
            SceneManager.LoadScene(4);
        }

        if (rightscore >= 5)
        {
            SceneManager.LoadScene(5);
        }
    




}





}