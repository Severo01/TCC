using UnityEngine;

public class DestroiBloco : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Colisor")) // Substitua pelo nome correto da tag
        {
            Destroy(gameObject); // Destroi este objeto
        }
    }
}
