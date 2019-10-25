using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public Slider slider;
    public GameObject player;
    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
    }

    void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.CompareTag("enemyShoulder"))
        {
            Debug.Log("Player hit!");
            health -= 10f;
            if(health <= 0)
            {
                StartCoroutine(die());

                gameover.SetActive(true);
            }
        }
    }
    IEnumerator die()
    {
        player.GetComponent<Shoot>().playerDie();
        yield return new WaitForSeconds(1.5f);
        Destroy(player);
    }
}
