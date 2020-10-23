﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.XR;
using System;
using UnityEngine.XR.WSA.Input;

#if HP_CONTROLLER_ENABLED
using Microsoft.MixedReality.Input;
using MotionControllerHandedness = Microsoft.MixedReality.Input.Handedness;
using Handedness = Microsoft.MixedReality.Toolkit.Utilities.Handedness;
#endif

namespace Microsoft.MixedReality.Toolkit.WindowsMixedReality.Input
{
#if HP_CONTROLLER_ENABLED
    [MixedRealityController(
        SupportedControllerType.HPMotionController,
        new[] { Handedness.Left, Handedness.Right },
        flags: MixedRealityControllerConfigurationFlags.UseCustomInteractionMappings)]
    public class HPMotionController : WindowsMixedRealityController
    {
        internal HPMotionControllerInputHandler inputHandler;
        internal MotionControllerState MotionControllerState;

        public HPMotionController(TrackingState trackingState, Handedness controllerHandedness, IMixedRealityInputSource inputSource = null, MixedRealityInteractionMapping[] interactions = null)
            : base(trackingState, controllerHandedness, inputSource, interactions)
        {
            inputHandler = new HPMotionControllerInputHandler(controllerHandedness, inputSource, Interactions);
        }

        /// <inheritdoc />
        public override MixedRealityInteractionMapping[] DefaultLeftHandedInteractions => new[]
        {
            new MixedRealityInteractionMapping(0, "Spatial Pointer", AxisType.SixDof, DeviceInputType.SpatialPointer),
            new MixedRealityInteractionMapping(1, "Spatial Grip", AxisType.SixDof, DeviceInputType.SpatialGrip),
            new MixedRealityInteractionMapping(2, "Grip Position", AxisType.SingleAxis, DeviceInputType.Grip),
            new MixedRealityInteractionMapping(3, "Grip Touch", AxisType.Digital, DeviceInputType.GripTouch),
            new MixedRealityInteractionMapping(4, "Grip Press", AxisType.Digital, DeviceInputType.GripPress),
            new MixedRealityInteractionMapping(5, "Trigger Position", AxisType.SingleAxis, DeviceInputType.Trigger),
            new MixedRealityInteractionMapping(6, "Trigger Touch", AxisType.Digital, DeviceInputType.TriggerTouch),
            new MixedRealityInteractionMapping(7, "Trigger Press", AxisType.Digital, DeviceInputType.TriggerPress),
            new MixedRealityInteractionMapping(8, "Trigger Press (Select)", AxisType.Digital, DeviceInputType.Select),
            new MixedRealityInteractionMapping(9, "Button.X Press", AxisType.Digital, DeviceInputType.PrimaryButtonPress),
            new MixedRealityInteractionMapping(10, "Button.Y Press", AxisType.Digital, DeviceInputType.SecondaryButtonPress),
            new MixedRealityInteractionMapping(11, "Menu Press", AxisType.Digital, DeviceInputType.Menu),
            new MixedRealityInteractionMapping(12, "Thumbstick Position", AxisType.DualAxis, DeviceInputType.ThumbStick),
            new MixedRealityInteractionMapping(13, "Thumbstick Press", AxisType.Digital, DeviceInputType.ThumbStickPress)
        };

        /// <inheritdoc />
        public override MixedRealityInteractionMapping[] DefaultRightHandedInteractions => new[]
        {
            new MixedRealityInteractionMapping(0, "Spatial Pointer", AxisType.SixDof, DeviceInputType.SpatialPointer),
            new MixedRealityInteractionMapping(1, "Spatial Grip", AxisType.SixDof, DeviceInputType.SpatialGrip),
            new MixedRealityInteractionMapping(2, "Grip Position", AxisType.SingleAxis, DeviceInputType.Grip),
            new MixedRealityInteractionMapping(3, "Grip Touch", AxisType.Digital, DeviceInputType.GripTouch),
            new MixedRealityInteractionMapping(4, "Grip Press", AxisType.Digital, DeviceInputType.GripPress),
            new MixedRealityInteractionMapping(5, "Trigger Position", AxisType.SingleAxis, DeviceInputType.Trigger),
            new MixedRealityInteractionMapping(6, "Trigger Touch", AxisType.Digital, DeviceInputType.TriggerTouch),
            new MixedRealityInteractionMapping(7, "Trigger Press", AxisType.Digital, DeviceInputType.TriggerPress),
            new MixedRealityInteractionMapping(8, "Trigger Press (Select)", AxisType.Digital, DeviceInputType.Select),
            new MixedRealityInteractionMapping(9, "Button.A Press", AxisType.Digital, DeviceInputType.PrimaryButtonPress),
            new MixedRealityInteractionMapping(10, "Button.B Press", AxisType.Digital, DeviceInputType.SecondaryButtonPress),
            new MixedRealityInteractionMapping(11, "Menu Press", AxisType.Digital, DeviceInputType.Menu),
            new MixedRealityInteractionMapping(12, "Thumbstick Position", AxisType.DualAxis, DeviceInputType.ThumbStick),
            new MixedRealityInteractionMapping(13, "Thumbstick Press", AxisType.Digital, DeviceInputType.ThumbStickPress)
        };

        private static readonly ProfilerMarker UpdateControllerPerfMarker = new ProfilerMarker("[MRTK] HPMotionController.UpdateController");

        public override void UpdateController(InteractionSourceState interactionSourceState)
        {
            using (UpdateControllerPerfMarker.Auto())
            {
                if (MotionControllerState != null)
                {
                    if (!Enabled) { return; }

                    // If the Motion controller state is instantiated and tracked, use it to update the interaction bool data and the interaction source to update the 6-dof data
                    inputHandler.UpdateController(MotionControllerState);
                    UpdateSixDofData(interactionSourceState);
                }
                else
                {
                    // Otherwise, update normally
                    base.UpdateController(interactionSourceState);
                }
            }
        }
    }
#endif
}