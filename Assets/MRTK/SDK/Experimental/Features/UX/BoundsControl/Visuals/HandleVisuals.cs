// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Experimental.UI.BoundsControl;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Input
{
    public class HandleVisuals : MonoBehaviour, IMixedRealityProximityHandler
    {
        public HandlesBase handlesBase;
        private int pointersInProximity = 0;
        public bool inProximity => pointersInProximity > 0;

        public void OnProximityEnter(ProximityEventData eventData)
        {
            pointersInProximity++;
        }

        public void OnProximityExit(ProximityEventData eventData)
        {
            pointersInProximity--;
        }
    }
}