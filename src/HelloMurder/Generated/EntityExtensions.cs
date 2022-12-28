/*             |￣￣￣￣￣￣\                                                                  *
 *             |    STOP   |                                                                 *
 *             |   EDITING |                                                                 *
 *             |    THIS   |                                                                 *
 *             |    FILE   |                                                                 *
 *             | ＿＿＿＿＿ /                                                                 *
 *             (\__/)  ||                                                                    *
 *             (•ㅅ•)  ||                                                                    *
 *             / 　 づ                                                                       *
 *             ￣￣￣                                                                         *
 * This code was generated by our own generator! In order to modify this, please run the     *
 * generator with whatever settings you want.                                                *
 *                                                                                           */

using Murder.Components;
using Murder.Components.Agents;
using Murder.Components.Cutscenes;
using Bang.Interactions;
using Murder.Components.Graphics;
using Bang.StateMachines;
using Bang.Components;
using Murder.StateMachines;
using Murder.Interactions;
using Murder.Messages;
using Road.Messages;
using System.Collections.Immutable;

namespace Bang.Entities
{
    public enum HelloMurderComponentType
    {
        
    }

    public enum HelloMurderMessageType
    {
        
    }

    public static class HelloMurderEntityExtensions
    {
        #region Component "Get" methods!
        
        #endregion
        
        #region Component "Has" checkers!
        
        #endregion
        
        #region Component "TryGet" methods!
        
        #endregion
        
        #region Component "Set" methods!
        
        #endregion
        
        #region Component "Remove" methods!
        
        #endregion

        #region Message "Has" checkers!
        
        #endregion
    }

    public class HelloMurderLookupImplementation : MurderLookupImplementation
    {
        private static readonly ImmutableHashSet<int> _relativeComponents = new HashSet<int>()
        {
            56,
            75,
            75
        }.ToImmutableHashSet();

        public override ImmutableHashSet<int> RelativeComponents => _relativeComponents;

        private static readonly ImmutableDictionary<Type, int> _componentsIndex = new Dictionary<Type, int>()
        {
            { typeof(AdvancedCollisionComponent), 0 },
            { typeof(AgentComponent), 1 },
            { typeof(AgentImpulseComponent), 2 },
            { typeof(AgentSpeedMultiplier), 3 },
            { typeof(AgentSpeedOverride), 4 },
            { typeof(AgentSpriteComponent), 5 },
            { typeof(AlphaComponent), 6 },
            { typeof(AnimationCompleteComponent), 7 },
            { typeof(AnimationOverloadComponent), 8 },
            { typeof(AnimationSpeedOverload), 9 },
            { typeof(AsepriteComponent), 10 },
            { typeof(CameraFollowComponent), 11 },
            { typeof(CarveComponent), 12 },
            { typeof(ColliderComponent), 13 },
            { typeof(CustomDrawComponent), 14 },
            { typeof(CutsceneAnchorsComponent), 15 },
            { typeof(DestroyAtTimeComponent), 16 },
            { typeof(DestroyOnAnimationCompleteComponent), 17 },
            { typeof(DestroyOnCollisionComponent), 18 },
            { typeof(DisableAgentComponent), 19 },
            { typeof(DoNotPauseComponent), 20 },
            { typeof(DrawRectangleComponent), 21 },
            { typeof(EntityTrackerComponent), 22 },
            { typeof(FacingComponent), 23 },
            { typeof(FadeScreenComponent), 24 },
            { typeof(FadeTransitionComponent), 25 },
            { typeof(FadeWhenInAreaComponent), 26 },
            { typeof(FlashSpriteComponent), 27 },
            { typeof(FrictionComponent), 28 },
            { typeof(GlobalShaderComponent), 29 },
            { typeof(GuidToIdTargetCollectionComponent), 30 },
            { typeof(GuidToIdTargetComponent), 31 },
            { typeof(HAAStarPathfindComponent), 32 },
            { typeof(HasVisionComponent), 33 },
            { typeof(HighlightSpriteComponent), 34 },
            { typeof(IdTargetCollectionComponent), 35 },
            { typeof(IdTargetComponent), 36 },
            { typeof(IndestructibleComponent), 37 },
            { typeof(InstanceToEntityLookupComponent), 38 },
            { typeof(InteractOnButtonPressComponent), 39 },
            { typeof(InteractOnCollisionComponent), 40 },
            { typeof(InteractOnRuleMatchComponent), 41 },
            { typeof(InteractOnStartComponent), 42 },
            { typeof(InteractorComponent), 43 },
            { typeof(IsCollidingComponent), 44 },
            { typeof(LineComponent), 45 },
            { typeof(MapComponent), 46 },
            { typeof(MoveToComponent), 47 },
            { typeof(MusicComponent), 48 },
            { typeof(ParallaxComponent), 49 },
            { typeof(PathfindComponent), 50 },
            { typeof(PauseAnimationComponent), 51 },
            { typeof(PrefabRefComponent), 52 },
            { typeof(PushAwayComponent), 53 },
            { typeof(QuadtreeComponent), 54 },
            { typeof(RandomizeAsepriteComponent), 55 },
            { typeof(RectPositionComponent), 56 },
            { typeof(RemoveColliderWhenStoppedComponent), 57 },
            { typeof(RequiresVisionComponent), 58 },
            { typeof(RoomComponent), 59 },
            { typeof(RotateComponent), 60 },
            { typeof(RouteComponent), 61 },
            { typeof(RuleWatcherComponent), 62 },
            { typeof(SituationComponent), 63 },
            { typeof(SoundComponent), 64 },
            { typeof(SpeakerComponent), 65 },
            { typeof(TextBoxComponent), 66 },
            { typeof(TextureComponent), 67 },
            { typeof(TileGridComponent), 68 },
            { typeof(TilesetComponent), 69 },
            { typeof(VelocityComponent), 70 },
            { typeof(VerticalPositionComponent), 71 },
            { typeof(WaitForVacancyComponent), 72 },
            { typeof(IStateMachineComponent), 73 },
            { typeof(IInteractiveComponent), 74 },
            { typeof(IMurderTransformComponent), 75 },
            { typeof(ITransformComponent), 75 },
            { typeof(StateMachineComponent<Coroutine>), 73 },
            { typeof(StateMachineComponent<DialogStateMachine>), 73 },
            { typeof(InteractiveComponent<AddComponentOnInteraction>), 74 },
            { typeof(InteractiveComponent<AddEntityOnInteraction>), 74 },
            { typeof(InteractiveComponent<BlackboardActionInteraction>), 74 },
            { typeof(InteractiveComponent<InteractionCollection>), 74 },
            { typeof(InteractiveComponent<RemoveEntityOnInteraction>), 74 },
            { typeof(InteractiveComponent<TalkToInteraction>), 74 },
            { typeof(PositionComponent), 75 },
            { typeof(PositionRotationComponent), 75 }
        }.ToImmutableDictionary();

        protected override ImmutableDictionary<Type, int> ComponentsIndex => _componentsIndex;

        private static readonly ImmutableDictionary<Type, int> _messagesIndex = new Dictionary<Type, int>()
        {
            { typeof(AnimationCompleteMessage), 76 },
            { typeof(CollidedWithMessage), 77 },
            { typeof(FatalDamageMessage), 78 },
            { typeof(HighlightMessage), 79 },
            { typeof(InteractMessage), 80 },
            { typeof(InteractorMessage), 81 },
            { typeof(NextDialogMessage), 82 },
            { typeof(PathNotPossibleMessage), 83 },
            { typeof(TouchedGroundMessage), 84 }
        }.ToImmutableDictionary();

        protected override ImmutableDictionary<Type, int> MessagesIndex => _messagesIndex;
    }
}