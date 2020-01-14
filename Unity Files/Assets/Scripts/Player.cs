using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public float rotate = 3;
    public string horizontalAxis, verticalAxis;
    public GameObject deadCanvas;
    public float health;
    public Text healthTxt;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
        deadCanvas.SetActive(false);
        healthTxt.text = string.Format("Health: {0}", health);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(verticalAxis);
        float y = Input.GetAxis(horizontalAxis);
        transform.Translate(0, speed * x, 0);
        transform.Rotate(0, 0, -y * rotate); //^^^ All Control the Movement of the Player
        if (health == 0)
        {
            deadCanvas.SetActive(true);
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Finish")
        {
            speed = 0.1f;
            GameObject.FindGameObjectWithTag("Finish").GetComponent<AudioSource>().Play();
            SceneManager.LoadSceneAsync(nextLevel);
        }
        else if (collider.tag == "Enemy")
        {
            GameObject.FindGameObjectWithTag("Enemy").GetComponent<AudioSource>().Play();
            deadCanvas.SetActive(true);
            Debug.Log("ENEMY");
        }
        else if (collider.tag == "Wall")
        {
            health--;
            healthTxt.text = string.Format("Health: {0}", health);
        }
        else if (collider.tag == "Pickup")
        {
            health = 10f;
            healthTxt.text = string.Format("Health: {0}", health.ToString());
            Destroy(collider.gameObject);
        }
    }
}
