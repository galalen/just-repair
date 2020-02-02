using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
  
    public GameObject[] enemiesPrefab;
    public float repeatEvery = 3.0f;

    public AudioSource audioSource;

    void Start()
    {
        if (!GameManager.instance.gameOver)
        {
            InvokeRepeating("StartSpwaning", 1.0f, repeatEvery);
        }
        audioSource.PlayDelayed(2);
    }

    void Update()
    {
        if (GameManager.instance.gameOver)
        {
            StopSpwaning();
        }
    }

    public void StopSpwaning()
    {
        CancelInvoke("StartSpwaning");
        audioSource.Pause();
    }

    public void StartSpwaning() 
    {
        int index  = Random.Range(0, enemiesPrefab.Length);
        float randomY = Random.Range(-5.5f, 4.5f);

        Instantiate(enemiesPrefab[index], new Vector3(9.0F, randomY, 0), Quaternion.identity);
    }

}
