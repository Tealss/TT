using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.UI;

public class ItemOption : MonoBehaviour
{

    [Header ("#Popup")]
    public GameObject popupWindow;
    private bool isPopupActive = false;

    private void Start()
    {
        popupWindow.SetActive(false);
    }

    public void OnPointerEnter()
    {
        int currentLayer = gameObject.layer;

        if (currentLayer == LayerMask.NameToLayer("Click"))
        {
            popupWindow.SetActive(true);
            isPopupActive = true;
        }
        else if (currentLayer == LayerMask.NameToLayer("Click2"))
        {
            popupWindow.SetActive(true);
            isPopupActive = true;
        }
    }

    public void OnPointerExit()
    {
        if (isPopupActive)
        {
            popupWindow.SetActive(false);
            isPopupActive = false;
        }
    }
}