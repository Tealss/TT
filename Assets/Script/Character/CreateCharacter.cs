using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class CreateCharacter : MonoBehaviour
{
 

    [Header("#InputField")]
    public InputField inputField;
    public static Text characterNameText;
    public Text GuideText;
    public GameObject Popup;
    public TextFadeOut textFadeOut;
    [Header("\n#Delegate")]
    public CanvasGroup popupPanel;
    public Text popupText;

    public delegate void PopupDelegate(string enteredName);
    public static event PopupDelegate OnPopup;
    private void Start()
    {
        characterNameText = gameObject.AddComponent<Text>();
    }
    //void Start()
    //{
    //    OnPopup += ShowPopup;
    //}
    //public void ShowPopup(string enteredName)
    //{
    //    popupText.text = enteredName + "ĳ���� �̸� : ";
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
        if (!string.IsNullOrEmpty(enteredName) && !enteredName.Contains(" ") && enteredName.Length <= 6)
        {
            characterNameText.text = enteredName;

            // ����Ƽ���� ��������� = �ؽ����̺�
            // PlayerPrefs.SetString("Name", enteredName);

            popupText.text = enteredName+ " (��)�� ���̵� �����Ͻðڽ��ϱ�? ";
            Popup.SetActive(true);
            DontDestroyOnLoad(characterNameText);
        }
        else if (!string.IsNullOrEmpty(enteredName) && enteredName.Contains(" "))
        {
            GuideText.text = "����� �Ұ����մϴ�!";
            textFadeOut.DisplayErrorMessage("����� �Ұ����մϴ�!");
        }
        else if (!string.IsNullOrEmpty(enteredName) && enteredName.Length >= 6)
        {
            GuideText.text = "�ִ� 7���� ���ϸ� �����մϴ�.";
            textFadeOut.DisplayErrorMessage("�ִ� 7���� ���ϸ� �����մϴ�.");

        }
        else 
        {
            GuideText.text = "ĳ���� �̸��� �Է��ϼ���";
            textFadeOut.DisplayErrorMessage("ĳ���� �̸��� �Է��ϼ���");

        }
    }
}
