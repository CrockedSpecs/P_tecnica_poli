using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SpawnCubes());
    }

    IEnumerator SpawnCubes()
    {
        while (true)
        {
            Vector3 spawningPoint = GetSpawningPoint();
            int randomIndex = Random.Range(1, 4);
            GameObject cube =cubesPool.Instance.RequestCube(randomIndex);
            if (cube != null)
            {
                cube.transform.position = spawningPoint;
            }



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
