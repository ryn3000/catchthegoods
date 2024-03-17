using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class scoregame : MonoBehaviour
{
    public Text scoreText;
    private int score;
    void Start()
    {
        
    }
    void Update()
    {
        scoreText.text = score.ToString();
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "pisang")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Destroy(target.gameObject);
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "barang")
        {
            Destroy(target.gameObject);
            score++;
        }
    }

}
