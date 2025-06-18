using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneTrigger : MonoBehaviour
{
    public Color zoneColor = Color.blue;
    [SerializeField] Canvas zoneUI;      // UI world-space “¿Ir?”
    bool inside;

    void Start()
    {
        // pinta el mesh con el color propio
        GetComponent<MeshRenderer>().material.color = zoneColor;
        zoneUI.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if (!inside && col.CompareTag("MainCamera"))
        {
            inside = true;
            zoneUI.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (inside && col.CompareTag("MainCamera"))
        {
            inside = false;
            zoneUI.gameObject.SetActive(false);
        }
    }

    // botón “IR”
    public void LoadPlaneScene()
    {
        GameSettingsAR.selectedColor = zoneColor;   // guarda color
        SceneManager.LoadScene("DeteccionPlanos");
    }
}

