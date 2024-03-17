using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] barang;
    public GameObject[] pisang;
    public float xBounds, yBounds;
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }
    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randombarang = Random.Range(0, barang.Length);

        if (Random.value <= .6f)
            Instantiate(barang[randombarang],
                new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        else
            Instantiate(pisang[0],
                 new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        StartCoroutine(SpawnRandomGameObject());

    }

}
