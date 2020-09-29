using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float delayRestart = 1f;
    public GameObject levelCompleteUI;


    public void completeLevel()
    {
        levelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", delayRestart);

        }
    }

    void Restart()
    {
        //What is inside load scene function is the name of our current scene. We can replace that with a string of a scene we want to load
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

    }



}
