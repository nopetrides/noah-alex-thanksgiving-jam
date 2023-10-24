﻿using Bang.Contexts;
using Bang.Systems;
using HelloMurder.Components;
using Bang.Entities;
using Murder.Components;
using Murder.Core.Physics;
using Murder.Core.Geometry;
using Murder.Core.Graphics;
using Murder.Core;
using Murder.Utilities;
using System.Numerics;
using Murder;

namespace HelloMurder.Systems.Player
{
    [Filter(typeof(BombComponent))]
    [Filter(ContextAccessorFilter.NoneOf, typeof(DestroyOnAnimationCompleteComponent))]
    public class BombExplosionSystem : IUpdateSystem
    {
        public void Update(Context context)
        {
            foreach(var e in context.Entities)
            {
                var mover = e.GetMoveTo();
                var pos = e.GetGlobalTransform().Vector2;
                pos = Vector2.Lerp(pos, mover.Target, Game.DeltaTime);
                e.SetGlobalPosition(pos);

                var sprite = e.GetSprite();
                if (sprite.CurrentAnimation == "damage" && !e.HasCollider())
                {
                    IShape shape = new CircleShape(10, new Point(0, 0));
                    var layer = CollisionLayersBase.TRIGGER & CollisionLayersBase.ACTOR & CollisionLayersBase.HITBOX;
                    ColliderComponent col = new ColliderComponent(shape, layer, Color.Blue);
                    e.SetCollider(col);
                }
                else if (sprite.CurrentAnimation == "miss" && e.HasCollider())
                {
                    e.RemoveCollider();
                    e.SetDestroyOnAnimationComplete(false);
                    var world = (MonoWorld)context.World;
                    world.Camera.Shake(1f, .2f);
                }
            }
        }
    }
}