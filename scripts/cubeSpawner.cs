using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] cubes; // Lista de cubos a instanciar.

    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true)
        {
            
            int randomIndex1 = Random.Range(1, cubes.Length+1);
            GameObject cube1 =cubesPool.Instance.RequestCube(randomIndex1);
            Vector3 spawningPoint1 = GetSpawningPoint();
            cube1.transform.position = spawningPoint1;
        
            
            
            yield return new WaitForSeconds(Random.Range(1, 2));
        }
    }

    Vector3 GetSpawningPoint()
    {
        return new Vector3(
            Random.Range(-5f, 9.5f), // Rango de la posición X.
            0,                       // Altura fija (Y).
            Random.Range(-5f, 5f)    // Rango de la posición Z.
        );
    }
}
