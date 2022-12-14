using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explotion : MonoBehaviour
{
    public GameObject explosion;
    public GameObject completeUI;
    public Text completeText;
    public GameObject rocketUI;
    public GameObject homeUI;
    public GameObject pauseBtn;

    AudioSource explosionSound;

    private void Start()
    {
        explosionSound = gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter()
    {
        explosionSound.Play();
        GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject,3);
        Destroy(expl, 7);
        rocketUI.SetActive(false);
        homeUI.SetActive(false);
        pauseBtn.SetActive(false);
        completeText.text = "Görev Başarılı!";
        Invoke("pauseGame", 2);
    }

    void pauseGame()
    {
        Time.timeScale = 0f;
        completeUI.SetActive(true);
    }


}
