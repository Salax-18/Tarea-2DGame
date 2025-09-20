using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScene1 : MonoBehaviour
{
    public Timer tiempoEscena;

    public void NextScene()
    {
        tiempoEscena.TimerStop();

       
        float tiempo = tiempoEscena.ObtenerTiempo();

        
        if (GameManager.instance != null)
        {
            GameManager.instance.SumaTimeGlobal(tiempo);
            Debug.Log("Tiempo escena 1: " + tiempo +
                      " | Tiempo global acumulado: " + GameManager.instance.GlobalTime1);
        }
  
        SceneManager.LoadScene("Scene2");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
