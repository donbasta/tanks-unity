using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coinObject;
    public float spawnTime;
    public float spawnDelay;
    [HideInInspector] public GameObject cloneCoin;

    void Start() {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    void SpawnObject() {
        Destroy(cloneCoin);
        cloneCoin = Instantiate(coinObject, transform.position, transform.rotation);
    }
}