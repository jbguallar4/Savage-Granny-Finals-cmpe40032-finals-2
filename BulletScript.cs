using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BulletScript : MonoBehaviour
{
    //public int scoreValue;
    //public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = "Score: " + scoreValue.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            KeepingScore.Score += 100;
            //scoreValue += 10;
            Destroy(collision.gameObject);

            gameObject.SetActive(false);
        }
    }
}
