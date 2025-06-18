using UnityEngine.SceneManagement;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void Volver() => SceneManager.LoadScene("ZonaInicio");
}

