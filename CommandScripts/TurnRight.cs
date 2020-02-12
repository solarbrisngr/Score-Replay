using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class TurnRight : Command
{
    private float _force;

    public TurnRight(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        _player.AddForce(_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}