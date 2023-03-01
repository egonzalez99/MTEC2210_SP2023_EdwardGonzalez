using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public GameObject coinPrefab;

    public float minX = -1.0f;
    public float maxX = 1.0f;
    public bool checkState = false;
    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(minX, maxX);

        GameObject newCoin = Instantiate(coinPrefab, Vector3.zero, Quaternion.identity);

        Vector3 newpos = transform.position;

        newpos.x = randomX;

        newCoin.transform.position = newpos;

        checkState = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
