using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public Player player;
    private int scroe;

    private int score = 0;
    public void IncreaseScore(){
        score++;
        Debug.Log(score);
        scoreText.text = score.ToString();        
    }
    public void GameOver(){
        Debug.Log("Game Over");
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Puase();

    }

    private void Awake(){
        Application.targetFrameRate = 60;
        Puase();
    }
    public void Play(){
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i<pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }
    }
    public void Puase(){
        Time.timeScale = 0f;
        player.enabled = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
