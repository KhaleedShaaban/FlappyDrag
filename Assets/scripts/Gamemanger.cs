using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanger : MonoBehaviour
{
    // Start is called before the first frame update


    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;
    private float leftEdge;
    private Vector3 SpawnPoint = new Vector3(-47, 9, -3);




    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {

        Pause();

    }

    public void Pause()
    {
        Time.timeScale = 0f;

    }

    public void Play()
    { 
        score = 0;
        scoreText.text = score.ToString();

      

        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;

        




        if (gameOver)
        { 
            var clones = GameObject.FindGameObjectsWithTag("obstacle");
             foreach (var clone in clones)
            {
                Destroy(clone);
            }

            var player = GameObject.FindWithTag("Player");
            player.transform.position = SpawnPoint;//reset location
            

            
            


        }  
    }
    public void GameOver()

    {
            
            playButton.SetActive(true);
            gameOver.SetActive(true);

            Pause();
     }

    public void IncreaseScore()
    {
            score++;
            scoreText.text = score.ToString();
    }

    
}

