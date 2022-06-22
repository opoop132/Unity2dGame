using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetoriteSpawner : MonoBehaviour
{
	[SerializeField]
	private StageData stageData;
	[SerializeField]
	private GameObject alertLinePrefab;
	[SerializeField]
	private GameObject meteoritePrefab;
	[SerializeField]
	private float minSpawnTime = 1.0f;
	[SerializeField]
	private float maxSpawnTime = 4.0f;

	private void Awake()
	{
		StartCoroutine("SpawnMeteorite");
	}
	
	private IEnumerator SpawnMeteorite()
	{
		while(true)
		{
			float positionX = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);
			GameObject alertLineClone = Instantiate(alertLinePrefab, new Vector3(positionX, 0, 0), Quaternion.identity);

			yield return new WaitForSeconds(1.0f);

			Destroy(alertLineClone);

			Vector3 meteoritePostion = new Vector3(positionX, stageData.LimitMax.y + 1.0f, 0);
			Instantiate(meteoritePrefab, meteoritePostion, Quaternion.identity);

			float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
			yield return new WaitForSeconds(spawnTime);
		}
	}
}
