using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject[] characterPrefabs; // 캐릭터 프리팹 배열
    private GameObject currentCharacter;   // 현재 캐릭터
    private Vector3 previousPosition;

    private void Start()
    {
        // 처음 시작할 때 첫 번째 캐릭터를 생성합니다.
        SpawnCharacter(0);
    }

    // 캐릭터를 생성하는 함수
    private void SpawnCharacter(int characterIndex)
    {
        // 현재 캐릭터를 삭제합니다.
        if (currentCharacter != null)
        {
            previousPosition = currentCharacter.transform.position;
            Destroy(currentCharacter);
        }

        // 선택한 인덱스에 해당하는 캐릭터를 생성합니다.
        currentCharacter = Instantiate(characterPrefabs[characterIndex], previousPosition, Quaternion.identity);
    }

    // 버튼 클릭 시 호출되는 함수
    public void ChangeCharacter(int characterIndex)
    {
        // 선택한 캐릭터로 변경합니다.
        SpawnCharacter(characterIndex);
    }
}
