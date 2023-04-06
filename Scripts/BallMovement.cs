using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public float jumpSpeed;
    Rigidbody rb;
    
    private bool ignorenextcollision;
    public GameObject finishPointUI;
    public GameObject GameOverText;

    AudioSource audioSource;
    public AudioClip Jump;
    public AudioClip Death;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        finishPointUI.SetActive(false);
        GameOverText.SetActive(false);
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "JumpPanel")
        {
            if (ignorenextcollision)
            return;
            audioSource.PlayOneShot(Jump);
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
           
            ignorenextcollision = true;
            Invoke("AllowCollision",.2f);
        }

        if(collision.gameObject.tag == "Obsticle")
        {
            GameOverText.SetActive(true);
            Invoke("Restart", 3f );
            GetComponent<SphereCollider>().enabled = false;
            audioSource.PlayOneShot(Death);
        }      
    }


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "FinishPanel")
        {
            finishPointUI.SetActive(true);

            if (GameObject.Find("GetToTheEndGuide") != null)
            {
                GameObject.Find("GetToTheEndGuide").SetActive(false);
            }
            else
            {

            }
        }
    }

    private void AllowCollision()
    {
        ignorenextcollision = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextlevelunlocked()
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;

        if(currentlevel >= PlayerPrefs.GetInt("levelsunlocked"))
        {
            PlayerPrefs.SetInt("levelsunlocked", currentlevel + 1);
        }
    }
}
