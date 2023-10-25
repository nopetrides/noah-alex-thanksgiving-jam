﻿using Bang.Contexts;
using Bang.Systems;
using HelloMurder.Components;
using Murder.Components;
using Bang.Entities;
using Murder.Core.Geometry;
using Murder.Core.Physics;
using Murder.Core.Graphics;
using Murder.Core;
using Murder.Utilities;
using System.Numerics;

namespace HelloMurder.Systems.Player
{
    [Filter(typeof(FlakComponent))]
    [Filter(ContextAccessorFilter.NoneOf, typeof(DestroyOnAnimationCompleteComponent))]
    public class FlakExplosionSystem : IUpdateSystem
    {
        public void Update(Context context)
        {
            if (!context.HasAnyEntity)
                return;
            var player = context.World.GetUniqueEntity<PlayerComponent>();
            if (player == null)
                return;

            foreach (var e in context.Entities)
            {
                var sprite = e.GetSprite();
                if (sprite.CurrentAnimation == "damage" && !e.HasCollider())
                {
                    IShape shape = new CircleShape(8, new Point(0, 0));
                    var layer = CollisionLayersBase.TRIGGER & CollisionLayersBase.ACTOR & CollisionLayersBase.HITBOX;
                    ColliderComponent col = new ColliderComponent(shape, layer, Color.Blue);
                    e.SetCollider(col);

                    // shake based on distance to player
                    var distanceFromPlayer = Vector2.Distance(e.GetGlobalTransform().Vector2, player.GetGlobalTransform().Vector2);
                    var shake = float.Lerp(0f, 2f, (2f/MathF.Max(distanceFromPlayer, 1f)));
                    var world = (MonoWorld)context.World;

                    world.Camera.Shake(shake, .2f);
                }
                else if (sprite.CurrentAnimation == "smoke_fading" && e.HasCollider())
                {
                    e.RemoveCollider();
                    e.SetDestroyOnAnimationComplete(false);
                }
            }
        }
    }
}