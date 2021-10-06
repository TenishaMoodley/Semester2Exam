using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollect : MonoBehaviour
{
    public GameObject Prefab_Spawn;
    private GameObject NewCollect;
    public GameObject[] Spawn;

    private void Start()
    {
        StartCoroutine(Spawn_Collect(1f));
    }
    IEnumerator Spawn_Collect(float Spawn_time)
    {
        
        int spawnNum = Spawn.Length;

        for (int i = 0; i < spawnNum; i++)
        {
            NewCollect = Instantiate(Prefab_Spawn, Spawn[i].transform.position, Quaternion.identity);
            NewCollect.name = "NewCollect";
            NewCollect.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            yield return new WaitForSeconds(Spawn_time);
        }

    }


}
