using UnityEngine;
using System.Collections;

public class CoinCollision : MonoBehaviour 
{
    [HideInInspector] public int value = 1;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Tank")) {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collision player) {
        TankInventory tank = player.gameObject.GetComponent<TankInventory>();
        tank.m_CoinCount = tank.m_CoinCount + value;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}