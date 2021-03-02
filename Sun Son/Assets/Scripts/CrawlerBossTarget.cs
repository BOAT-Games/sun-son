﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerBossTarget : MonoBehaviour
{
    [SerializeField] CrawlerBossController _boss;
    [SerializeField] GameObject _player;
    [SerializeField] PlayerMelee _sword;

    // Start is called before the first frame update
    void Start()
    {
        _boss = GameObject.Find("CrawlerBoss").GetComponent<CrawlerBossController>();
        _player = FindObjectOfType<PlayerResources>().gameObject;

        _sword = _player.GetComponent<PlayerMelee>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            if (other.GetComponent<SunBulletController>() != null)
            {
                _boss.TakeDamage(5);
            }
            else
            {
                if (_sword._hit)
                {
                    _boss.TakeDamage(10);
                }
            }
        }
    }
}
