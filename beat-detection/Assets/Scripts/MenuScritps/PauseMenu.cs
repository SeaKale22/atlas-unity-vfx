using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;

    public CameraController CameraController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (PauseCanvas.activeSelf)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Debug.Log("Curser visable is False.");
                Resume();
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Debug.Log("Curser visable is True.");
                Pause();
            }
        }   
    }

    void Pause()
    {
        Time.timeScale = 0;
        Debug.Log("timeScale set to 0.");
        CameraController.moveCam = false;
        PauseCanvas.SetActive(true);
        Debug.Log("PauseCanvas setActive is True.");
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Debug.Log("timeScale set to 1.");
        CameraController.moveCam = true;
        PauseCanvas.SetActive(false);
        Debug.Log("PauseCanvas setActive is False.");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneTracker.Instance.SetPreviousScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneTracker.Instance.SetPreviousScene();
        SceneManager.LoadScene(0);
    }
    
    public void Options()
    {
        Time.timeScale = 1;
        SceneTracker.Instance.SetPreviousScene();
        SceneManager.LoadScene(4);
    }
}
