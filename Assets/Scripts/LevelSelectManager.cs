using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelectManager : MonoBehaviour
{
    public TMP_Text levelNumberText;
    public GameObject levelNumberBox;
    public GameObject startButtonBox;

    public void Update()
    {
        Vector3 screenMousePosition = Input.mousePosition;
        screenMousePosition.z = Camera.main.WorldToScreenPoint(startButtonBox.transform.position).z;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);
        Debug.Log(mousePosition);

        if (mousePosition.x > 0)
        {
            startButtonBox.transform.Rotate(new Vector3(0.5f, 0, 0));
        }
        else
        {
            startButtonBox.transform.Rotate(new Vector3(-0.5f, 0, 0));
        }

        if (mousePosition.y > 0)
        {
            startButtonBox.transform.Rotate(new Vector3(0f, 0.5f, 0));
        }
        else
        {
            startButtonBox.transform.Rotate(new Vector3(0f, -0.5f, 0));
        }
    }
}