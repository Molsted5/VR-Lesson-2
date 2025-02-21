using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;

    private bool shouldRunSpawnBallCoroutine;

    IEnumerator currentSpawnBallCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shouldRunSpawnBallCoroutine = true;
        currentSpawnBallCoroutine = SpawnBall();
        StartCoroutine(currentSpawnBallCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBall() {
        while (shouldRunSpawnBallCoroutine) {
            yield return new WaitForSeconds(Random.Range(0.5f, 2f));
            Vector3 randomSpawnPositionOffset = new Vector3(Random.Range(-6f, 6f), Random.Range(-1f, 3f), 0);
            GameObject newBall = Instantiate(ballPrefab, transform.position + randomSpawnPositionOffset, Quaternion.identity);
        }
    }

}
