using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class InputManager 
{

    private static Gamecontrols _gameControls;

    public static void Init(player myplayer)
    {
        _gameControls = new Gamecontrols();

        _gameControls.Permenant.Enable();

        _gameControls.ingame.movement.performed += ctx =>
        {
            myplayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };

        _gameControls.ingame.jump.performed += jeff =>
        {
            myplayer.jump();
        };

        _gameControls.ingame.look.performed += ctx =>
        {
            myplayer.setLookRotation(ctx.ReadValue<Vector2>());
            myplayer.setLookRotation(ctx.ReadValue<Vector2>());
        };

        _gameControls.ingame.Shoot.started += ctx =>
        {
            myplayer.Shoot();
        };


        _gameControls.Permenant.Enable();
    }

    public static void setgamecontrols()
    {
        _gameControls.ingame.Enable();
        _gameControls.UI.Disable();
    }

    public static void setUIcontrols()
    {
        _gameControls.ingame.Enable();
        _gameControls.UI.Disable();
    }
}
