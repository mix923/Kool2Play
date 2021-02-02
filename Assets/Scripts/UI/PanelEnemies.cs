using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelEnemies : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI enemyRed;
    [SerializeField] private TextMeshProUGUI enemyBlue;
    [SerializeField] private TextMeshProUGUI enemyGreen;
    [SerializeField] private TextMeshProUGUI enemyYellow;

    private int currentEnemyRed;
    private int currentEnemyBlue;
    private int currentEnemyGreen;
    private int currentEnemyYellow;


    public void Start()
    {
        currentEnemyRed = 0;
        currentEnemyBlue = 0;
        currentEnemyGreen = 0;
        currentEnemyYellow = 0;
    }

    public void IncreseEnemyOnBoard(Enemy enemy)
    {
        if(enemy.GetTeam() == Team.Blue)
        {
            if (enemyBlue.gameObject.active == false)
                enemyBlue.gameObject.SetActive(true);

            enemyBlue.text = string.Format("Enemy {0}/{1}", currentEnemyBlue, 20);
        }
        else if(enemy.GetTeam() == Team.Red)
        {
            if (enemyRed.gameObject.active == false)
                enemyRed.gameObject.SetActive(true);

            enemyRed.text = string.Format("Enemy {0}/{1}", currentEnemyRed, 20);
        }
        else if (enemy.GetTeam() == Team.Green)
        {
            if (enemyGreen.gameObject.active == false)
                enemyGreen.gameObject.SetActive(true);

            enemyGreen.text = string.Format("Enemy {0}/{1}", currentEnemyGreen, 20);
        }
        else
        {
            if (enemyYellow.gameObject.active == false)
                enemyYellow.gameObject.SetActive(true);

            enemyYellow.text = string.Format("Enemy {0}/{1}", currentEnemyYellow, 20);
        }
    }


    public void DecreaseEnemyOnBoard(Enemy enemy)
    {
        if (enemy.GetTeam() == Team.Blue)
        {
            currentEnemyBlue += 1;
            enemyBlue.text = string.Format("Enemy {0}/{1}", currentEnemyBlue, 20);
        }
        else if (enemy.GetTeam() == Team.Red)
        {
            currentEnemyRed += 1;
            enemyRed.text = string.Format("Enemy {0}/{1}", currentEnemyRed, 20);
        }
        else if (enemy.GetTeam() == Team.Green)
        {
            currentEnemyGreen += 1;
            enemyGreen.text = string.Format("Enemy {0}/{1}", currentEnemyGreen, 20);
        }
        else
        {
            currentEnemyYellow += 1;
            enemyYellow.text = string.Format("Enemy {0}/{1}", currentEnemyYellow, 20);
        }
    }
}
