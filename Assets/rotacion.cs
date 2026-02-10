using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField] private Vector3 velocidadRotacion = new Vector3(0, 50, 0);

    void Update()
    {
        // Multiplicamos por Time.deltaTime para que la rotación sea fluida
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}