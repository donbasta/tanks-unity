using UnityEngine;
using System.Collections;

public class CoinCollision : MonoBehaviour 
{
    [HideInInspector] public int value = 1;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Tank")) {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player) {
        TankInventory tank = player.GetComponent<TankInventory>();
        tank.m_CoinCount = tank.m_CoinCount + value;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}