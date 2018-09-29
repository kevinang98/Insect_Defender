using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class WaveSpawner : MonoBehaviour {

    public Transform capungPrefab;

    public Transform kepikPrefab;

    public Transform semutPrefab;

    public Transform kelabangPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 8f;
    private float countdown = 3f;

    public Text waveCountdownText;

    private int waveIndex = 0;
    public int boss = 0;
    public int x = 0;
    
    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            //SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = string.Format("{0:00.00}", countdown);
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        PlayerStats.Rounds++;

        for (int i = 0; i < waveIndex; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                SpawnKepik();
                yield return new WaitForSeconds(0.3f);
            }
        }

        for (int i = 0; i < waveIndex; i++)
        {
                SpawnCapung();
                yield return new WaitForSeconds(0.5f);           
        }

        if (waveIndex % 2 == 0)
        {
            x++;
            for (int i = 0; i < x; i++)
            {
                SpawnSemut();
                yield return new WaitForSeconds(0.7f);
            }
        }

        if (waveIndex % 5 == 0)
        {
            boss++;
            for (int i = 0; i < boss; i++) {
                SpawnKelabang();
                yield return new WaitForSeconds(1f);
            }
        }
    }     

    void SpawnCapung()
    {
        Instantiate(capungPrefab);
    }

    void SpawnKepik()
    {
        Instantiate(kepikPrefab);
    }

    void SpawnSemut()
    {
        Instantiate(semutPrefab);
    }

    void SpawnKelabang()
    {
        Instantiate(kelabangPrefab);
    }
}
