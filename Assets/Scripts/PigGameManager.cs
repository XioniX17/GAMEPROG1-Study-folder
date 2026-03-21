using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PigGameManager : MonoBehaviour
{
    private bool isGameOver = false;

    public PigEnemy pigPrefab;
    private float spawnerTimer = 0.0f;
    private float rateOfSpawn = 2.0f;
    public float spawnPosX = 10;
    public float[] spawnPosYArray;

    public TMP_Text timerText;
    private float startTime = 60.0f;
    private float timer;


    public bool hasPhases = false;
    private int phaseNumber = 0;

    private float phase1EndTime = 30;


    public TMP_Text gameOverText;
    public GameObject gameOverBtn;

    private void Start()
    {
        timer = startTime;
        timerText.text = timer.ToString("f0");
    }

    private void Update()
    {
        if (isGameOver)
        {
            return;
        }

        spawnerTimer += Time.deltaTime;
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("f0");

        if(hasPhases)
        {
            if(phaseNumber == 0)
            {
                if (timer <= phase1EndTime)
                {
                    spawnPosX = -spawnPosX;
                    phaseNumber++;
                }
            }
        }

        if (timer <= 0)
        {
            EnableGameOver("You Win!");
        }


        if (spawnerTimer >= rateOfSpawn)
        {
            SpawnPig();
            spawnerTimer = 0;
        }
    }


    private void SpawnPig()
    {
        int randomPosIdx = Random.Range(0, spawnPosYArray.Length);
        PigEnemy newPig = Instantiate(pigPrefab,(Vector2.right * spawnPosX) +(Vector2.up * spawnPosYArray[randomPosIdx]), Quaternion.identity);
        if(phaseNumber >= 1)
        {
            newPig.ReverseDirection();
        }
    }

    public void EnableGameOver(string msg)
    {
        if (isGameOver)
        {
            return;
        }
        gameOverBtn.SetActive(true);
        gameOverText.text = msg;
        gameOverText.gameObject.SetActive(true);
        isGameOver = true;
    }
}
