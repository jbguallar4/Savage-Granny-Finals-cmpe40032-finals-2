using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject granny;
    private float x;
    private int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(grannySpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator grannySpawn()
    {
        while(enemyCount != 5)
        {
            x = Random.Range(498, 502);
            Instantiate(granny, new Vector3(x, 4, 507), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            enemyCount += 1;
        }
    }
}
