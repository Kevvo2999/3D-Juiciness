using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    public int obstacleCount = 20;

    public float mapSizeX = 20f;
    public float mapSizeZ = 20f;

    void Start()
    {
        for (int i = 0; i < obstacleCount; i++)
        {
            // Elegir prefab aleatorio
            GameObject randomPrefab =
                obstaclePrefabs[
                    Random.Range(0, obstaclePrefabs.Length)
                ];

            // Posición aleatoria dentro del mapa
            Vector3 randomPosition = new Vector3(
                Random.Range(-mapSizeX, mapSizeX),
                0,
                Random.Range(-mapSizeZ, mapSizeZ)
            );

            // Rotación aleatoria
            Quaternion randomRotation =
                Quaternion.Euler(
                    0,
                    Random.Range(0, 360),
                    0
                );

            Instantiate(
                randomPrefab,
                randomPosition,
                randomRotation
            );
        }
    }
}