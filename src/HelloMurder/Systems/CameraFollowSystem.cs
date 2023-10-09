﻿using Bang.Contexts;
using Bang.Entities;
using Bang.Systems;
using HelloMurder.Components;
using Murder.Utilities;
using Murder.Core.Graphics;
using Murder.Core;
using System.Numerics;
using Murder;
using Murder.Components;

namespace HelloMurder.Systems;

// Filtering the entities to only have the "PlayerComponent"
[Filter(typeof(PlayerComponent))]
internal class CameraFollowSystem : IFixedUpdateSystem
{
    public void FixedUpdate(Context context)
    {
        // Making sure you have a player
        if (!context.HasAnyEntity)
            return;

        // Get current world, and grab that camera
        Camera2D camera = ((MonoWorld)context.World).Camera;

        // Get the context.Entity (we expect our player, since we filtered it!)
        // Get it's GlobalTransform and set our camera position
        var player = context.Entity;
        var position = player.GetGlobalTransform().Vector2;

        if (player.HasVelocity()) position += player.GetVelocity().Velocity * Game.FixedDeltaTime;

        position -= new Vector2(camera.Width / 2.0f, camera.Height / 2.0f);

        camera.Position = Vector2.Lerp(camera.Position, position, 0.2f);
    }
}