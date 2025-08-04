using System.Collections;
using UnityEngine;

public class UnitySpawner : MonoBehaviour
{
    public GameObject unitPrefab; //유닛 프리팹

    public Transform spawnPoint; // 생성 위치

    public float interval = 5.0f; // 유닛 생성 간격

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            //유닛을 생성합니다.
            //생성 위치는 spawnPoint로부터 받습니다.
           Instantiate(unitPrefab, spawnPoint.position,Quaternion.identity);

            //생성 간격만큼 대기합니다.
            yield return new WaitForSeconds(interval);



            Debug.Log($"{spawnPoint.name} + 에서 {unitPrefab.name}이 생성됩니다."); // 공통 스폰이니까 문자열 보간법을 사용함. {unitPrefab.name}은 필드의 게임 오브젝트를 말한다. 예를 들어 큐브
        }
    }
}
