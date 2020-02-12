using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class TurnLeft : Command
{
    private float _force;

    public TurnLeft(Rigidbody player, float force)
    {
        _player = player;
        _force = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        _player.AddForce(-_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
