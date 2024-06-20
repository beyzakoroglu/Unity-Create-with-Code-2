using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Skoru artır
        GameManager.Instance.IncreaseScore(1);

        // Objeleri yok et
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
