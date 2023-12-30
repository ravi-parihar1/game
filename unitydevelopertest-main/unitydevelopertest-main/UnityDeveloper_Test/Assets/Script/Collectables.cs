using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    public int Goal = 1; 

    private int score = 0;

    public TextMeshProUGUI scoreText;

    void Start() { 
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectable")
        {
            score++;
            scoreText.text = "Score:" + score.ToString();
            Debug.Log("Triggered");
            Destroy(other.gameObject);
        }
        
        //scorescript.scorevalue += 3;
    }
    // Update is called once per frame
    void Update()
    {
        if(score == Goal)
        {
            FindObjectOfType<GameManager>().LevelCleared();
        }
    }
}