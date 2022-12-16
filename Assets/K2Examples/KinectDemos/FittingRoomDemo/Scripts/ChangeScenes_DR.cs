using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes_DR : MonoBehaviour
{
    public void goToModelView()
    {
        Debug.Log("Direccionando a vista de Modelo");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void goToDesignView()
    {
        Debug.Log("Direccionando a vista de Modelo");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
