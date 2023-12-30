using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject LoseOverlay;
    public GameObject WinOverlay;
    bool gameHasEnded = false;
    public void Start()
    {
        LoseOverlay.SetActive(false);
        WinOverlay.SetActive(false);
    }
    public void EndGame()
    {
        
        if(gameHasEnded == false)
        {
            LoseOverlay.SetActive(false);
            Debug.Log("Game over");
            gameHasEnded = true;

            StartCoroutine(GameOver());
        }

    }

    IEnumerator GameOver()
    {
        LoseOverlay.SetActive(true);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

      
    }
    public void LevelCleared()
    {
        StartCoroutine(QuitApplication());
    }

    IEnumerator QuitApplication()
    {
        WinOverlay.SetActive(true);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        Application.Quit();


    }


}
