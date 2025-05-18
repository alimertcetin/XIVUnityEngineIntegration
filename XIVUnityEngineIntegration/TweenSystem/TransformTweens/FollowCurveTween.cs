﻿using UnityEngine;
using XIV.Core.TweenSystem.Drivers;
using XIV.Core.XIVMath;

namespace XIV.Core.TweenSystem.TransformTweens
{
    internal sealed class FollowCurveTween : CurveTweenDriver<Vector3, Transform>
    {
        protected override void OnUpdate(float easedTime)
        {
            var point = BezierMath.GetPoint(startValue[0], startValue[1], startValue[2], startValue[3], easedTime);
            component.position = point;
        }
    }
}