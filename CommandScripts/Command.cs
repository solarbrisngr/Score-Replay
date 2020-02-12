using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public Rigidbody _player;
    public float timestamp; // for logging purposes
    public abstract void Execute();
}