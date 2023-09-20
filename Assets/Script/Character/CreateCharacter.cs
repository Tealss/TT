using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class CreateCharacter : MonoBehaviour
{
    [Header("#InputField")]
    public InputField inputField;
    public Text characterNameText;
    public Text GuideText;
    public GameObject Popup;
    [Header("\n#Delegate")]
    public CanvasGroup popupPanel;
    public Text popupText;

    public delegate void PopupDelegate(string enteredName);
    public static event PopupDelegate OnPopup;
    //void Start()
    //{
    //    OnPopup += ShowPopup;
    //}
    //public void ShowPopup(string enteredName)
    //{
    //    popupText.text = enteredName + "캐릭터 이름 : ";
    //    popupPanel.alpha = 1;
    //    popupPanel.blocksRaycasts = true;
    //}

    //public void ClosePopup()
    //{
    //    popupPanel.alpha = 0;
    //    popupPanel.blocksRaycasts = false;
    //}

    //public void RaisePopupEvent(string enteredName)
    //{
    //    OnPopup?.Invoke(enteredName);
    //}
    public void GenerateCharacterName()
    {
        string enteredName = inputField.text;
        if (!string.IsNullOrEmpty(enteredName) && !enteredName.Contains(" ") && enteredName.Length <= 7)
        {
            characterNameText.text = enteredName;
            popupText.text = enteredName+ " (으)로 아이디를 생성하시겠습니까? ";
            Popup.SetActive(true);

        }
        else if (!string.IsNullOrEmpty(enteredName) && enteredName.Contains(" "))
        {
            GuideText.text = "띄어쓰기는 불가능합니다!";

        }
        else if (!string.IsNullOrEmpty(enteredName) && enteredName.Length >= 7)
        {
            GuideText.text = "최대 7글자 이하만 가능합니다.";

        }
        else 
        {
            GuideText.text = "캐릭터 이름을 입력하세요";

        }
    }
}
