using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaifaShift : MonoBehaviour
{
    [SerializeField] Toggle Switch;

    public void OnClickSaifaShiftButton()
    {
        if (Switch.isOn)
        {
            SceneManager.LoadScene("Saifa mirror");
        }
        else
        {
            SceneManager.LoadScene("Saifa");
        }
    }
}
