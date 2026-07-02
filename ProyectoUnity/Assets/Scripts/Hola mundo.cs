using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class Holamundo : MonoBehaviour
{
    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;
        print("algo paso");
        Debug.LogWarning("algo salio medianamente mal");
        Debug.LogError("algo salio muy mal");

    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log(x);

        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.Log("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido deshabilitado");
    }
}