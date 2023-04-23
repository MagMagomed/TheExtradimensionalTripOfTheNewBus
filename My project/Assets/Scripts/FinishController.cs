using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
        {
            return;
        }
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}
