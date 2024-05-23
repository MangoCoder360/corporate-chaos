using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DropCameraToScene(string sceneName)
    {
        GameObject camera = Camera.main.gameObject;
        Rigidbody rb = camera.AddComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, -500, 0), ForceMode.VelocityChange);
        StartCoroutine(LoadSceneAfterDelay(sceneName, 2f));
    }

    private IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
