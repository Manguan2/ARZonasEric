using UnityEngine;
using UnityEngine.SceneManagement;

/// Spawnea dos zonas a 2 m delante de la cámara.
/// Al entrar en la zona aparece UI con botón “IR”.
public class ZoneSpawner : MonoBehaviour
{
    [SerializeField] GameObject zonePrefab;  // asignaremos un prefab base
    [SerializeField] Color colorA = Color.blue, colorB = Color.green;
    [SerializeField] float distance = 2f;

    void Start()
    {
        // cámara del AR Session Origin
        Transform cam = Camera.main.transform;

        // posiciones ligeramente separadas derecha / izquierda
        Vector3 basePos = cam.position + cam.forward * distance;
        Vector3 left = basePos + cam.right * -0.8f;
        Vector3 right = basePos + cam.right * 0.8f;

        CreateZone(left, colorA, "ZonaAzul");
        CreateZone(right, colorB, "ZonaVerde");
    }

    void CreateZone(Vector3 pos, Color col, string name)
    {
        var zone = Instantiate(zonePrefab, pos, Quaternion.identity);
        zone.name = name;
        var zr = zone.GetComponent<ZoneTrigger>();
        zr.zoneColor = col;
    }
}

