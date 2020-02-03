using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void Play(){
        
    }

    public void Quit(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Credits(){
        
    }

    public void Continue(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
