using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
   [SerializeField] private GameObject _enemy;
   
   private float _timeBetweenSpawn = 2f;
   private float _time;

   private void Update()
   {
      _time += Time.deltaTime;

      if (_time>=_timeBetweenSpawn)
      {
        Instantiate(_enemy,transform.position,Quaternion.identity);
        _time = 0;
      }
   }
}
