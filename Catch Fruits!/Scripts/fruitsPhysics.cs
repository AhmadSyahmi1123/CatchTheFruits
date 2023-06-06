using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitsPhysics : MonoBehaviour
{
    public GameObject[] fruitprefab;
    public float spawnInterval = 5f;
    public float minTrans;
    public float maxTrans;

    private float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= spawnInterval)
        {
            SpawnFruit();
            elapsedTime = 0f; // Reset the timer
        }
    }

    void SpawnFruit()
    {
        var wanted = Random.Range(minTrans, maxTrans);
        var position = new Vector3(wanted, transform.position.y);
        GameObject fruit = Instantiate(fruitprefab[Random.Range(0, fruitprefab.Length)], position, Quaternion.identity);
        Destroy(fruit, 5f);
    }
}
