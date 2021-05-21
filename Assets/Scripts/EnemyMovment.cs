using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] private Transform _way;

    private int _courrentWayPoint;
    private float _speed = 4;
    private Transform[] _wayPoints;
    
    private void Start()
    {
        _wayPoints=new Transform[_way.childCount];
    }

    private void Update()
    {
        Transform target = _wayPoints[_courrentWayPoint];
        
        for (int i = 0; i < _way.childCount; i++)
        {
            _wayPoints[i] = _way.GetChild(i);
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position==target.position)
        {
            _courrentWayPoint++;

            if (_courrentWayPoint>=_wayPoints.Length)
            {
                _courrentWayPoint = 0;
            }
        }
    }
}
