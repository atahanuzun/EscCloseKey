using UnityEngine;
using UnityEngine.UI;

public class KeyboardButton : MonoBehaviour
{
    public Button button;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            button.onClick.Invoke();
        }
    }
}
