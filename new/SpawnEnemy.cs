using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject ememy;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(ememy, new Vector3(Random.Range(-57.32f, -45.61f), 47.55f, 77.4f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
