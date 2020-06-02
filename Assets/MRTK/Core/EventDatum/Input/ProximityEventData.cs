// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Microsoft.MixedReality.Toolkit.Input
{
    /// <summary>
    /// Describes an Input Event associated with a specific pointer's focus state change.
    /// </summary>
    public class ProximityEventData : BaseEventData
    {
        /// <summary>
        /// The pointer associated with this event.
        /// </summary>
        public IMixedRealityPointer Pointer { get; private set; }

        /// <summary>
        /// The old focused object.
        /// </summary>
        public GameObject EnterProximityObject  { get; private set; }

        /// <summary>
        /// The new focused object.
        /// </summary>
        public GameObject ExitProximityObject { get; private set; }

        /// <inheritdoc />
        public ProximityEventData(EventSystem eventSystem) : base(eventSystem) { }

        /// <summary>
        /// Used to initialize/reset the event and populate the data.
        /// </summary>
        public void Initialize(IMixedRealityPointer pointer)
        {
            Reset();
            Pointer = pointer;
        }

        /// <summary>
        /// Used to initialize/reset the event and populate the data.
        /// </summary>
        public void Initialize(IMixedRealityPointer pointer, GameObject enterProximityObject, GameObject exitProximityObject)
        {
            Reset();
            Pointer = pointer;
            EnterProximityObject = enterProximityObject;
            ExitProximityObject = exitProximityObject;
        }
    }
}

