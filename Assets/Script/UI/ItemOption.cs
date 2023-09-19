using UnityEngine;
using UnityEngine.UI;

public class ItemOption : MonoBehaviour
{
    [Header ("#Popup")]
    public GameObject popupWindow;
    private bool popupset = false;

    private void Start()
    {
        popupWindow.SetActive(false);
    }

    public void OnPointerEnter()
    {
        popupWindow.SetActive(true);
        if (popupWindow.activeSelf == true)
        {
            popupset = true;
        }

    }

    public void OnPointerExit()
    {
        popupWindow.SetActive(false);
        popupset = false;
    }
}