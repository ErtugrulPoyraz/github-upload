using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject endGameUI;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "log")
        {
            Time.timeScale = 0f;
            endGameUI.SetActive(true);

        }
    }
}
