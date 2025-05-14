using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCargarEscena : MonoBehaviour
{
    public void CargarEscena(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }
}
