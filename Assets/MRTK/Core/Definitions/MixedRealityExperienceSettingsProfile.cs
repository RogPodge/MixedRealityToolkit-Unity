﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Utilities;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: InternalsVisibleTo("Microsoft.MixedReality.Toolkit.Tests.EditModeTests")]
[assembly: InternalsVisibleTo("Microsoft.MixedReality.Toolkit.Tests.PlayModeTests")]
namespace Microsoft.MixedReality.Toolkit
{
    /// <summary>
    /// Experience settings profile for the Mixed Reality Toolkit.
    /// </summary>
    [CreateAssetMenu(menuName = "Mixed Reality Toolkit/Profiles/Mixed Reality Toolkit Experience Settings Profile", fileName = "MixedRealityToolkitExperienceSettingsProfile", order = (int)CreateProfileMenuItemIndices.Configuration)]
    [HelpURL("https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/configuration/mixed-reality-configuration-guide")]
    public class MixedRealityExperienceSettingsProfile : BaseMixedRealityProfile
    {
        [SerializeField]
        [Tooltip("The scale of the Mixed Reality experience.")]
        private ExperienceScale targetExperienceScale = ExperienceScale.Room;

        /// <summary>
        /// The desired the scale of the experience.
        /// </summary>
        public ExperienceScale TargetExperienceScale
        {
            get { return targetExperienceScale; }
            set { targetExperienceScale = value; }
        }

        [SerializeField]
        [Tooltip("The height above the floor for the Mixed Reality Experience. 1 unit = 1 meter")]
        private float floorHeight = 0.0f;

        /// <summary>
        /// The height above the floor for the Mixed Reality Experience. 1 unit = 1 meter
        /// </summary>
        public float FloorHeight
        {
            get { return floorHeight; }
            set { floorHeight = value; }
        }

        [SerializeField]
        [Tooltip("If this setting is enabled, MRTK will position the camera Floor Height Units above the world origin to facilitate navigation. Set this to true only if the platform does not provide it's own floor height (WMR, Oculus etc.)")]
        private bool alignCameraToFloorHeight = false;

        /// <summary>
        /// If this setting is enabled, MRTK will position the camera Floor Height Units above the world origin to facilitate navigation. Set this to true only if the platform does not provide it's own floor height (WMR, Oculus etc.)
        /// </summary>
        public bool AlignCameraToFloorHeight
        {
            get { return alignCameraToFloorHeight; }
            set { alignCameraToFloorHeight = value; }
        }
    }
}