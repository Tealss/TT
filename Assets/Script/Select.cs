using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject[] characterPrefabs; // ĳ���� ������ �迭
    private GameObject currentCharacter;   // ���� ĳ����
    private Vector3 previousPosition;

    private void Start()
    {
        // ó�� ������ �� ù ��° ĳ���͸� �����մϴ�.
        SpawnCharacter(0);
    }

    // ĳ���͸� �����ϴ� �Լ�
    private void SpawnCharacter(int characterIndex)
    {
        // ���� ĳ���͸� �����մϴ�.
        if (currentCharacter != null)
        {
            previousPosition = currentCharacter.transform.position;
            Destroy(currentCharacter);
        }

        // ������ �ε����� �ش��ϴ� ĳ���͸� �����մϴ�.
        currentCharacter = Instantiate(characterPrefabs[characterIndex], previousPosition, Quaternion.identity);
    }

    // ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void ChangeCharacter(int characterIndex)
    {
        // ������ ĳ���ͷ� �����մϴ�.
        SpawnCharacter(characterIndex);
    }
}
