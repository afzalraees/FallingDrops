using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManager : MonoBehaviour
{
    public int dropsPerSpawn;
    public int timePerSpawn;
    public List<GameObject> drops = new List<GameObject>();

    public GameObject pink, blue;

    public bool isSpawnning;

    private void Start()
    {
        SpawnDrop();
    }
    public void Resetdrops()
    {
        foreach (var drop in drops) 
        {
            GameObject temp = drop.gameObject;
            Destroy(temp); 
        }
        isSpawnning = false;
        drops.Clear();

        SpawnDrop();
    }

    public void SpawnDrop()
    {
        if(!isSpawnning)
        {
            StartCoroutine(Spawnrandom());
        }
        
    }

    IEnumerator Spawnrandom()
    {
        isSpawnning = true;
        drops.Clear();
        for(int i = 0; i < dropsPerSpawn; i++)
        {
            int drop = Random.Range(0, 2);
            int randX = Random.Range(9, -10);
            Vector3 pos = new Vector3(randX, 25, 0);
            if (drop == 0)
            {
                GameObject pinkDrop = Instantiate(pink, pos, Quaternion.identity, transform);

                drops.Add(pinkDrop);
            }
            else
            {
                GameObject blueDrop = Instantiate(blue, pos, Quaternion.identity, transform);

                drops.Add(blueDrop);
            }
            yield return new WaitForSeconds(timePerSpawn);
        }
        isSpawnning = false;
    }
}