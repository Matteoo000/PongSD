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
    // variables
    public AudioClip BallHitSound; // references the sound that needs to be played
    private AudioSource audioSource; // iddentifies what the audiosource is 
    public TMP_Text Scoreboard;      // used for the score board
    // used for scoreboard. LEFT player
    private int leftscore = 0;
    // used for scoreboard. RIGHT player
    private int rightscore = 0;
    // start pos horizontal
    public float Xposition = 0f;
    //start pos verticall 
    public float Yposition = 0f;
    // Just a variable to make Xspeed work in code/ variable just references(IDENTIFICATION)
    public float Xspeed;
    // Just a variable to make Yspeed work in code/ variable just references(IDENTIFICATION)
    public float Yspeed;
  


    // Start is called before the first frame update
    void Start()
    {
        //transforms Xpos and Ypos (vector3= X,Y,Z)
        //it also sets the speed
        transform.position = new Vector3(Xposition, Yposition, 0);
        Xspeed = 3f;
        Yspeed = 3f;

        // Audio
        //making audio work
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = BallHitSound;
        
    }



    // Update is called once per frame
    void Update()
    {
        //Makes scoreboard work on both sides inside of unity/ also makes it look like score-score
        Scoreboard.text = leftscore + " - " + rightscore;
        //references movement and timedeltatime makes the movement be the same for evryone FPS cant alter speed
        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        //  recognition of NEW pos because when ball colides it will get NEW positions this is how it gets recognized
        transform.position = new Vector3(Xposition, Yposition, 0);
    }


    //method
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // identifies wall horizontal 
        if (collision.gameObject.CompareTag("Horizontalwall"))



        {
            // when collision it inverts the speed/the way its traveling 
            Yspeed = Yspeed * -1;
           
            audioSource.Play();
        }


        // identifies wall LEFT/verticall used for adding score and resetting ball when collision
        if (collision.gameObject.CompareTag("Leftwall"))
        {
            // makes score get added by one if left wall hit/score adding
            rightscore++;
            //resets pos when score
            Xposition = 0;
            Yposition = 0;
            Yspeed = 3f;
            Xspeed = 3f;
            //when collision it plays the sound 
            audioSource.Play();
        }




        // identifies wall RIGHT/verticall wall used for adding score and resetting when score is added/when colides 
        if (collision.gameObject.CompareTag("Rightwall"))
        {
            // makes score get added by one if Right wall hit/score adding
            leftscore++;
            //resets pos when score
            Xposition = 0;
            Yposition = 0;
            Yspeed = 0;
            Xspeed = 0;
            Yspeed = 3f;
            Xspeed = -3f;
            // when collision it plays the sound
            audioSource.Play();
        }


        // makes the score get added onto the score before 0 becomes 1 . And if score is higher then start it will recognize it and add one ontop of the score
        Scoreboard.text = leftscore.ToString() + " - " + rightscore.ToString();


        // when max score is hit it loads winner scene
        if (leftscore >= 5)
        {
            SceneManager.LoadScene(2);
        }


        // when max score is hit it loads winner scene
        if (rightscore >= 5)
        {
            SceneManager.LoadScene(3);
        }


        // makes the paddles work when ball colides with them
        if (collision.gameObject.CompareTag("Player"))
        {
            // inverts speed/movement way when collision
            Xspeed = Xspeed * -1.1f;
            //plays the sound when collision
            audioSource.Play();
        }
        // makes the score get added onto the score before 0 becomes 1 . And if score is higher then start it will recognize it and add one ontop of the score
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