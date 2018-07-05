using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool GameHasEnded = false;
    public float RestartDelay = 1f;
    public GameObject CompleteLevelUI;

	public void EndGame()
    {
        if (!GameHasEnded)
        {
            GameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", RestartDelay);
        }
    }

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
