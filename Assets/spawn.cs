using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    bool isSpawning = false;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawning) StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        isSpawning = true;
        transform.position = new Vector3(Random.Range(-9f, 9f), 6);
        Instantiate(enemy, transform);
        yield return new WaitForSeconds(1);
        isSpawning = false;
    }
}
