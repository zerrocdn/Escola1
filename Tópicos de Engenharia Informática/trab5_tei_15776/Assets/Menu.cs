using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    
   public void Casa(int SceneIndex)
    {
      SceneManager.LoadScene("Casas", LoadSceneMode.Single);
    }

    public void Jardim(int SceneIndex)
    {
      SceneManager.LoadScene("Jardim", LoadSceneMode.Single);
    }

    public void Back(int SceneIndex)
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
