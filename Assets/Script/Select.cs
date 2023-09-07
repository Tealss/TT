using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject[] characterPrefabs; //  Prefabs �迭
    private GameObject currentCharacter;   // ���� ĳ��
    private Vector3 previousPosition;

    private void Start()
    {
        // ĳ���� ����
        SpawnCharacter(0);
    }

    private void SpawnCharacter(int characterIndex)
    {
        // ���ο� ĳ���� ������ ���� ĳ�� ����
        if (currentCharacter != null)
        {
            previousPosition = currentCharacter.transform.position;
            Destroy(currentCharacter);
        }

        // ���� ĳ������ ��ġ�� ��Ƽ�, �� ��(previousPosition)���� ������
        currentCharacter = Instantiate(characterPrefabs[characterIndex], previousPosition, Quaternion.identity);
    }

    public void ChangeCharacter(int characterIndex)
    {

        // ĳ�� ����
        SpawnCharacter(characterIndex);
    }
}
