using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "LevelGate")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
