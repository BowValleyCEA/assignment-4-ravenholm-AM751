using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShooter : MonoBehaviour
{

    [SerializeField] private NavMeshAgent enemy;
    [SerializeField] private Transform player;
    [SerializeField] private float timer = 5;
    private float shootTime;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnRegion;
    [SerializeField] private float _enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        shootingThePlayer();
        
    }

    void shootingThePlayer()
    {
        shootTime -= Time.deltaTime;

        if (shootTime > 0) return;

        shootTime = timer; //The private Float timer which was mentioned in the starting.

        GameObject enemyBullet = Instantiate(bullet,spawnRegion.transform.position, spawnRegion.transform.rotation) as GameObject;
        Rigidbody bulletRB = enemyBullet.GetComponent<Rigidbody>();
        bulletRB.AddForce (bulletRB.transform.forward * _enemySpeed);
        Destroy(bulletRB, 3f);
        
    }
}

