using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [System.Serializable]
    public class EnemyStats
    {
        public int Health = 100;
    }

    public EnemyStats enemyStats = new EnemyStats();
    // Start is called before the first frame update

    public void DamageEnemy(int dmg)
    {
        enemyStats.Health -= dmg;
        if (enemyStats.Health <= 0)
        {
            Debug.Log("KILL ENEMY");
            GameMaster.KillEnemy(this);

        }
    }
}
