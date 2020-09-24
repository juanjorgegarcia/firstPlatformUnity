using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStats
    {
        public int Health = 100;
    }

    public PlayerStats playerStats = new PlayerStats();
    // Start is called before the first frame update
    public int fallBoundary = -20;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= fallBoundary)
        {
            DamagePlayer(999999);
        }
    }

    public void DamagePlayer(int dmg)
    {
        playerStats.Health -= dmg;
        if (playerStats.Health <= 0)
        {
            Debug.Log("KILL PLAYER");
            GameMaster.KillPlayer(this);

        }
    }
}
