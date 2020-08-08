using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    private GeneralInput controls;
    private void Awake()
    {
        controls = new GeneralInput();
    }

    private void Start()
    {
        controls.DefenderArea.DefenderSpawn.performed += _ => Spawn();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    public void Spawn()
    {
        Debug.Log("I was spawned");
    }
}
