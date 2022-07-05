using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private InputController _inputs;
    [SerializeField] private HitHandler _hit;


    private void Awake()
    {
        _inputs.OnTap += OnTapHandler;
    }

    private void OnTapHandler(Vector2 position)
    {
        if (_hit.TryHit(position))
        {

        }
    }
}
