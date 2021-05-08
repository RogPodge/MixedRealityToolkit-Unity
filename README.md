# The docs have moved!

**Starting from MRTK 2.6, we are publishing both conceptual docs and API references on docs.microsoft.com. For conceptual docs, please visit <a href="https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/">our new landing page</a>. For API references, please visit <a href="https://docs.microsoft.com/dotnet/api/microsoft.mixedreality.toolkit">the MRTK-Unity section of the dot net API explorer</a>. All links on this page have been updated.** 

**Existing content will remain here but will not be updated further.**

![Mixed Reality Toolkit](Documentation/Images/Logo_MRTK_Unity_Banner.png)

# What is the Mixed Reality Toolkit

MRTK-Unity is a Microsoft-driven project that provides a set of components and features, used to accelerate cross-platform MR app development in Unity. Here are some of its functions:

* Provides the **cross-platform input system and building blocks for spatial interactions and UI**.
* Enables **rapid prototyping** via in-editor simulation that allows you to see changes immediately.
* Operates as an **extensible framework** that provides developers the ability to swap out core components.
* **Supports a wide range of platforms**, including
  * OpenXR (Unity 2020.2 or newer)
    * Microsoft HoloLens 2
    * Windows Mixed Reality headsets
  * Windows Mixed Reality
    * Microsoft HoloLens
    * Microsoft HoloLens 2
    * Windows Mixed Reality headsets
  * Oculus (Unity 2019.3 or newer)
    * Oculus Quest
  * OpenVR
    * Windows Mixed Reality headsets
    * HTC Vive
    * Oculus Rift
  * Ultraleap Hand Tracking
  * Mobile devices such as iOS and Android

# Getting started with MRTK

If you're new to MRTK or Mixed Reality development in Unity, **we recommend you start at the beginning of our** [Unity development journey](https://docs.microsoft.com/windows/mixed-reality/unity-development-overview?tabs=mrtk%2Chl2) in the Microsoft Docs. The Unity development journey is specifically tailored to walk new developers through the installation, core concepts, and usage of MRTK.

| IMPORTANT: The Unity development journey currently uses **MRTK version 2.4.0** and **Unity 2019.4**. |
| --- |

If you're an experienced Mixed Reality or MRTK developer, check the links in the next section for the newest packages and release notes.

# Documentation

| [![Release notes](Documentation/Images/MRTK_Icon_ReleaseNotes.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/release-notes/mrtk-26-release-notes)<br/>[Release Notes](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/release-notes/mrtk-26-release-notes)| [![MRTK Overview](Documentation/Images/MRTK_Icon_ArchitectureOverview.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/architecture/overview)<br/>[MRTK Overview](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/architecture/overview)| [![Feature Guides](Documentation/Images/MRTK_Icon_FeatureGuides.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/button)<br/>[Feature Guides](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/button)| [![API Reference](Documentation/Images/MRTK_Icon_APIReference.png)](https://docs.microsoft.com/dotnet/api/Microsoft.MixedReality.Toolkit?view=mixed-reality-toolkit-unity-2020-dotnet-2.6.0)<br/>[API Reference](https://docs.microsoft.com/dotnet/api/Microsoft.MixedReality.Toolkit?view=mixed-reality-toolkit-unity-2020-dotnet-2.6.0)|
|:---|:---|:---|:---|

# Build status

| Branch | CI Status | Docs Status |
|---|---|---|
| `main` |[![CI Status](https://dev.azure.com/aipmr/MixedRealityToolkit-Unity-CI/_apis/build/status/public/mrtk_CI?branchName=main)](https://dev.azure.com/aipmr/MixedRealityToolkit-Unity-CI/_build/latest?definitionId=15)|[![Docs Status](https://dev.azure.com/aipmr/MixedRealityToolkit-Unity-CI/_apis/build/status/public/mrtk_docs?branchName=main)](https://dev.azure.com/aipmr/MixedRealityToolkit-Unity-CI/_build/latest?definitionId=7)

# Required software

 | [![Windows SDK 18362+](Documentation/Images/MRTK170802_Short_17.png)](https://developer.microsoft.com/windows/downloads/windows-10-sdk) [Windows SDK 18362+](https://developer.microsoft.com/windows/downloads/windows-10-sdk)| [![Unity](Documentation/Images/MRTK170802_Short_18.png)](https://unity3d.com/get-unity/download/archive) [Unity 2018.4.x](https://unity3d.com/get-unity/download/archive)| [![Visual Studio 2019](Documentation/Images/MRTK170802_Short_19.png)](http://dev.windows.com/downloads) [Visual Studio 2019](http://dev.windows.com/downloads)| [![Emulators (optional)](Documentation/Images/MRTK170802_Short_20.png)](https://docs.microsoft.com/windows/mixed-reality/using-the-hololens-emulator) [Emulators (optional)](https://docs.microsoft.com/windows/mixed-reality/using-the-hololens-emulator)|
| :--- | :--- | :--- | :--- |
| To build apps with MRTK v2, you need the Windows 10 May 2019 Update SDK. <br> To run apps for immersive headsets, you need the Windows 10 Fall Creators Update. | The Unity 3D engine provides support for building mixed reality projects in Windows 10 | Visual Studio is used for code editing, deploying and building UWP app packages | The Emulators allow you to test your app without the device in a simulated environment |

# Feature areas

| ![Input System](Documentation/Images/MRTK_Icon_InputSystem.png) [Input System](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/overview)<br/>&nbsp;  | ![Hand Tracking<br/> (HoloLens 2)](Documentation/Images/MRTK_Icon_HandTracking.png) [Hand Tracking<br/> (HoloLens 2)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/hand-tracking) | ![Eye Tracking<br/> (HoloLens 2)](Documentation/Images/MRTK_Icon_EyeTracking.png) [Eye Tracking<br/> (HoloLens 2)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/eye-tracking/eye-tracking-main) | ![Profiles](Documentation/Images/MRTK_Icon_Profiles.png) [Profiles](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/configuration/mixed-reality-configuration-guide)<br/>&nbsp; | ![Hand Tracking<br/> (Ultraleap)](Documentation/Images/MRTK_Icon_HandTracking.png) [Hand Tracking (Ultraleap)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/cross-platform/leap-motion-mrtk)|
| :--- | :--- | :--- | :--- | :--- |
| ![UI Controls](Documentation/Images/MRTK_Icon_UIControls.png) [UI Controls](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/#ux-building-blocks)<br/>&nbsp; | ![Solvers](Documentation/Images/MRTK_Icon_Solver.png) [Solvers](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/solvers/solver)<br/>&nbsp; | ![Multi-Scene<br/> Manager](Documentation/Images/MRTK_Icon_SceneSystem.png) [Multi-Scene<br/> Manager](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/scene-system/scene-system-getting-started) | ![Spatial<br/> Awareness](Documentation/Images/MRTK_Icon_SpatialUnderstanding.png) [Spatial<br/> Awareness](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/spatial-awareness/spatial-awareness-getting-started) | ![Diagnostic<br/> Tool](Documentation/Images/MRTK_Icon_Diagnostics.png) [Diagnostic<br/> Tool](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/diagnostics/diagnostics-system-getting-started) |
| ![MRTK Standard Shader](Documentation/Images/MRTK_Icon_StandardShader.png) [MRTK Standard Shader](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/rendering/mrtk-standard-shader) | ![Speech & Dictation](Documentation/Images/MRTK_Icon_VoiceCommand.png) [Speech](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/speech)<br/> & [Dictation](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/dictation) | ![Boundary<br/>System](Documentation/Images/MRTK_Icon_Boundary.png) [Boundary<br/>System](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/boundary/boundary-system-getting-started)| ![In-Editor<br/>Simulation](Documentation/Images/MRTK_Icon_InputSystem.png) [In-Editor<br/>Simulation](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input-simulation/input-simulation-service) | ![Experimental<br/>Features](Documentation/Images/MRTK_Icon_Experimental.png) [Experimental<br/>Features](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/contributing/experimental-features)|

# UX building blocks

|  [![Button](Documentation/Images/Button/MRTK_Button_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/button) [Button](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/button) | [![Bounds Control](Documentation/Images/BoundsControl/MRTK_BoundsControl_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/bounds-control) [Bounds Control](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/bounds-control) | [![Object Manipulator](Documentation/Images/ManipulationHandler/MRTK_Manipulation_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/object-manipulator) [Object Manipulator](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/object-manipulator) |
|:--- | :--- | :--- |
| A button control which supports various input methods, including HoloLens 2's articulated hand | Standard UI for manipulating objects in 3D space | Script for manipulating objects with one or two hands |
|  [![Slate](Documentation/Images/Slate/MRTK_Slate_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/slate) [Slate](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/slate) | [![System Keyboard](Documentation/Images/SystemKeyboard/MRTK_SystemKeyboard_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/system-keyboard) [System Keyboard](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/system-keyboard) | [![Interactable](Documentation/Images/Interactable/InteractableExamples.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/interactable) [Interactable](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/interactable) |
| 2D style plane which supports scrolling with articulated hand input | Example script of using the system keyboard in Unity  | A script for making objects interactable with visual states and theme support |
|  [![Solver](Documentation/Images/Solver/MRTK_Solver_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/solvers/solver) [Solver](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/solvers/solver) | [![Object Collection](Documentation/Images/ObjectCollection/MRTK_ObjectCollection_Main.jpg)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/object-collection) [Object Collection](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/object-collection) | [![Tooltip](Documentation/Images/Tooltip/MRTK_Tooltip_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/tooltip) [Tooltip](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/tooltip) |
| Various object positioning behaviors such as tag-along, body-lock, constant view size and surface magnetism | Script for laying out an array of objects in a three-dimensional shape | Annotation UI with a flexible anchor/pivot system, which can be used for labeling motion controllers and objects |
|  [![Slider](Documentation/Images/Slider/MRTK_UX_Slider_Main.jpg)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/sliders) [Slider](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/sliders) | [![MRTK Standard Shader](Documentation/Images/MRTKStandardShader/MRTK_StandardShader.jpg)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/rendering/mrtk-standard-shader) [MRTK Standard Shader](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/rendering/mrtk-standard-shader) | [![Hand Menu](Documentation/Images/Solver/MRTK_UX_HandMenu.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/hand-menu) [Hand Menu](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/hand-menu) |
| Slider UI for adjusting values supporting direct hand tracking interaction | MRTK's Standard shader supports various Fluent design elements with performance | Hand-locked UI for quick access, using the Hand Constraint Solver |
|  [![App Bar](Documentation/Images/AppBar/MRTK_AppBar_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/app-bar) [App Bar](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/app-bar) | [![Pointers](Documentation/Images/Pointers/MRTK_Pointer_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/pointers) [Pointers](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/pointers) | [![Fingertip Visualization](Documentation/Images/Fingertip/MRTK_FingertipVisualization_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/fingertip-visualization) [Fingertip Visualization](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/fingertip-visualization) |
| UI for Bounds Control's manual activation | Learn about various types of pointers | Visual affordance on the fingertip which improves the confidence for the direct interaction |
|  [![Near Menu](Documentation/Images/NearMenu/MRTK_UX_NearMenu.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/near-menu) [Near Menu](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/near-menu) | [![Spatial Awareness](Documentation/Images/SpatialAwareness/MRTK_SpatialAwareness_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/spatial-awareness/spatial-awareness-getting-started) [Spatial Awareness](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/spatial-awareness/spatial-awareness-getting-started) | [![Voice Command](Documentation/Images/Input/MRTK_Input_Speech.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/speech) [Voice Command](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/speech) / [Dictation](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/dictation) |
| Floating menu UI for the near interactions | Make your holographic objects interact with the physical environments | Scripts and examples for integrating speech input |
|  [![Progress Indicator](Documentation/Images/ProgressIndicator/MRTK_ProgressIndicator_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/progress-indicator) [Progress Indicator](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/progress-indicator) | [![Dialog](Documentation/Images/Dialog/MRTK_UX_Dialog_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/dialog) [Dialog [Experimental]](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/dialog) | [![Hand Coach](Documentation/Images/HandCoach/MRTK_UX_HandCoach_Main.jpg)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/hand-coach) [Hand Coach](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/hand-coach) |
| Visual indicator for communicating data process or operation | UI for asking for user's confirmation or acknowledgement  | Component that helps guide the user when the gesture has not been taught |
|  [![Hand Physics Service](Documentation/Images/HandPhysics/MRTK_UX_HandPhysics_Main.jpg)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/experimental/hand-physics-service) [Hand Physics Service [Experimental]](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/experimental/hand-physics-service) | [![Scrolling Collection](Documentation/Images/ScrollingCollection/ScrollingCollection_Main.jpg)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/scrolling-object-collection) [Scrolling Collection](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/ux-building-blocks/scrolling-object-collection) | [![Dock](Documentation/Images/Dock/MRTK_UX_Dock_Main.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/experimental/dock) [Dock [Experimental]](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/experimental/dock) |
| The hand physics service enables rigid body collision events and interactions with articulated hands | An Object Collection that natively scrolls 3D objects | The Dock allows objects to be moved in and out of predetermined positions |
|  [![Eye Tracking: Target Selection](Documentation/Images/EyeTracking/mrtk_et_targetselect.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/eye-tracking/eye-tracking-target-selection) [Eye Tracking: Target Selection](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/eye-tracking/eye-tracking-target-selection) | [![Eye Tracking: Navigation](Documentation/Images/EyeTracking/mrtk_et_navigation.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/eye-tracking/eye-tracking-navigation) [Eye Tracking: Navigation](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input/eye-tracking/eye-tracking-navigation) | [![Eye Tracking: Heat Map](Documentation/Images/EyeTracking/mrtk_et_heatmaps.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/example-scenes/eye-tracking-examples-overview#visualization-of-visual-attention) [Eye Tracking: Heat Map](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/example-scenes/eye-tracking-examples-overview#visualization-of-visual-attention) |
| Combine eyes, voice and hand input to quickly and effortlessly select holograms across your scene | Learn how to auto-scroll text or fluently zoom into focused content based on what you are looking at | Examples for logging, loading and visualizing what users have been looking at in your app |

# Tools

|  [![Optimize Window](Documentation/Images/MRTK_Icon_OptimizeWindow.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/tools/optimize-window) [Optimize Window](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/tools/optimize-window) | [![Dependency Window](Documentation/Images/MRTK_Icon_DependencyWindow.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/tools/dependency-window) [Dependency Window](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/tools/dependency-window) | ![Build Window](Documentation/Images/MRTK_Icon_BuildWindow.png) Build Window | [![Input recording](Documentation/Images/MRTK_Icon_InputRecording.png)](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input-simulation/input-animation-recording) [Input recording](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/input-simulation/input-animation-recording) |
|:--- | :--- | :--- | :--- |
| Automate configuration of Mixed Reality projects for performance optimizations | Analyze dependencies between assets and identify unused assets |  Configure and execute an end-to-end build process for Mixed Reality applications | Record and playback head movement and hand tracking data in editor |

# Example scenes

Explore MRTK's various types of interactions and UI controls through the example scenes. You can find example scenes under [**Assets/MRTK/Examples/Demos**](/Assets/MixedRealityToolkit.Examples/Demos) folder.

[![Example Scene](Documentation/Images/MRTK_Examples.png)](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/example-scenes/hand-interaction-examples)

# MRTK examples hub

With the MRTK Examples Hub, you can try various example scenes in MRTK. On HoloLens 2, you can download and install [MRTK Examples Hub through the Microsoft Store app](https://www.microsoft.com/p/mrtk-examples-hub/9mv8c39l2sj4).

See [Examples Hub README page](https://docs.microsoft.com/windows/mixed-reality/mrtk-unity/features/example-scenes/example-hub) to learn about the details on creating a multi-scene hub with MRTK's scene system and scene transition service.

[![Example Scene](Documentation/Images/MRTK_ExamplesHub.png)](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/features/example-scenes/hand-interaction-examples)

# Sample apps made with MRTK

| [![Periodic Table of the Elements](Documentation/Images/MRDL_PeriodicTable.jpg)](https://medium.com/@dongyoonpark/bringing-the-periodic-table-of-the-elements-app-to-hololens-2-with-mrtk-v2-a6e3d8362158)| [![Galaxy Explorer](Documentation/Images/MRTK_GalaxyExplorer.jpg)](https://docs.microsoft.com/windows/mixed-reality/galaxy-explorer-update)| [![Galaxy Explorer](Documentation/Images/MRDL_Surfaces.jpg)](https://docs.microsoft.com/windows/mixed-reality/galaxy-explorer-update)|
|:--- | :--- | :--- |
| [Periodic Table of the Elements](https://github.com/Microsoft/MRDL_Unity_PeriodicTable) is an open-source sample app which demonstrates how to use MRTK's input system and building blocks to create an app experience for HoloLens and Immersive headsets. Read the porting story: [Bringing the Periodic Table of the Elements app to HoloLens 2 with MRTK v2](https://medium.com/@dongyoonpark/bringing-the-periodic-table-of-the-elements-app-to-hololens-2-with-mrtk-v2-a6e3d8362158) |[Galaxy Explorer](https://github.com/Microsoft/GalaxyExplorer) is an open-source sample app that was originally developed in March 2016 as part of the HoloLens 'Share Your Idea' campaign. Galaxy Explorer has been updated with new features for HoloLens 2, using MRTK v2. Read the story: [The Making of Galaxy Explorer for HoloLens 2](https://docs.microsoft.com/windows/mixed-reality/galaxy-explorer-update) |[Surfaces](https://github.com/Microsoft/GalaxyExplorer) is an open-source sample app for HoloLens 2 which explores how we can create a tactile sensation with visual, audio, and fully articulated hand-tracking. Check out Microsoft MR Dev Days session [Learnings from the Surfaces app](https://channel9.msdn.com/Shows/Docs-Mixed-Reality/Learnings-from-the-MR-Surfaces-App) for the detailed design and development story. |

# Session videos from Mixed Reality Dev Days 2020

| [![MRDevDays](Documentation/Images/MRDevDays_Session1.png)](https://channel9.msdn.com/Shows/Docs-Mixed-Reality/Intro-to-MRTK-Unity)| [![MRDevDays](Documentation/Images/MRDevDays_Session2.png)](https://channel9.msdn.com/Shows/Docs-Mixed-Reality/MRTKs-UX-Building-Blocks)| [![MRDevDays](Documentation/Images/MRDevDays_Session3.png)](https://channel9.msdn.com/Shows/Docs-Mixed-Reality/MRTK-Performance-and-Shaders)|
|:--- | :--- | :--- |
| Tutorial on how to create a simple MRTK app from start to finish. Learn about interaction concepts and MRTK’s multi-platform capabilities. | Deep dive on the MRTK’s UX building blocks that help you build beautiful mixed reality experiences. | An introduction to performance tools, both in MRTK and external, as well as an overview of the MRTK Standard Shader.	 |

See [Mixed Reality Dev Days](https://docs.microsoft.com/windows/mixed-reality/mr-dev-days-sessions) to explore more session videos.

# Engage with the community

- Join the conversation around MRTK on [Slack](https://holodevelopers.slack.com/). You can join the Slack community via the [automatic invitation sender](https://holodevelopersslack.azurewebsites.net/).

- Ask questions about using MRTK on [Stack Overflow](https://stackoverflow.com/questions/tagged/mrtk) using the **MRTK** tag.

- Search for [known issues](https://github.com/Microsoft/MixedRealityToolkit-Unity/issues) or file a [new issue](https://github.com/Microsoft/MixedRealityToolkit-Unity/issues) if you find something broken in MRTK code.

- For questions about contributing to MRTK, go to the [mixed-reality-toolkit](https://holodevelopers.slack.com/messages/C2H4HT858) channel on slack.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

# Useful resources on the Mixed Reality Dev Center

| ![Discover](Documentation/Images/mrdevcenter/icon-discover.png) [Discover](https://docs.microsoft.com/windows/mixed-reality/)| ![Design](Documentation/Images/mrdevcenter/icon-design.png) [Design](https://docs.microsoft.com/windows/mixed-reality/design)| ![Develop](Documentation/Images/mrdevcenter/icon-develop.png) [Develop](https://docs.microsoft.com/windows/mixed-reality/development)| ![Distribute)](Documentation/Images/mrdevcenter/icon-distribute.png) [Distribute](https://docs.microsoft.com/windows/mixed-reality/implementing-3d-app-launchers)|
| :--------------------- | :----------------- | :------------------ | :------------------------ |
| Learn to build mixed reality experiences for HoloLens and immersive headsets (VR).          | Get design guides. Build user interface. Learn interactions and input.     | Get development guides. Learn the technology. Understand the science.       | Get your app ready for others and consider creating a 3D launcher. |

# Useful resources on Azure

| ![Spatial Anchors](Documentation/Images/mrdevcenter/icon-azurespatialanchors.png)<br> [Spatial Anchors](https://docs.microsoft.com/azure/spatial-anchors/)| ![Speech Services](Documentation/Images/mrdevcenter/icon-azurespeechservices.png) [Speech Services](https://docs.microsoft.com/azure/cognitive-services/speech-service/)| ![Vision Services](Documentation/Images/mrdevcenter/icon-azurevisionservices.png) [Vision Services](https://docs.microsoft.com/azure/cognitive-services/computer-vision/)|
| :------------------------| :--------------------- | :---------------------- |
| Spatial Anchors is a cross-platform service that allows you to create Mixed Reality experiences using objects that persist their location across devices over time.| Discover and integrate Azure powered speech capabilities like speech to text, speaker recognition or speech translation into your application.| Identify and analyze your image or video content using Vision Services like computer vision, face detection, emotion recognition or video indexer. |

# Learn more about the MRTK project

You can find our planning material on [our wiki](https://github.com/Microsoft/MixedRealityToolkit-Unity/wiki) under the Project Management Section. You can always see the items the team is actively working on in the Iteration Plan issue.

# How to contribute

Learn how you can contribute to MRTK at [Contributing](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/contributing/contributing).

**For details on the different branches used in the Mixed Reality Toolkit repositories, check this [Branch Guide here](https://github.com/Microsoft/MixedRealityToolkit-Unity/wiki/Branch-Guide).**
