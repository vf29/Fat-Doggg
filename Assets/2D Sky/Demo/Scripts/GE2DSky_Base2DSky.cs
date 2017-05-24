﻿// 2D Sky
// Version: 1.1.5
// Compatible: Unity 5.5.1 or higher, see more info in Readme.txt file.
//

// Developer:			Gold Experience Team (https://www.assetstore.unity3d.com/en/#!/search/page=1/sortby=popularity/query=publisher:4162)
// Unity Asset Store:	https://www.assetstore.unity3d.com/en/#!/content/21555
//
// Please direct any bugs/comments/suggestions to geteamdev@gmail.com

#region Namespaces

using UnityEngine;
using System.Collections;

#endregion // Namespaces

// ######################################################################
// GE2DSky_Base2DSky keeps screen resolutions information and find orthographic camera in the scene.
// This class is base class of GE2DSky_CloudFlow and GE2DSky_SkyBG classes.
// ######################################################################

public class GE2DSky_Base2DSky : MonoBehaviour
{

	// ########################################
	// Variables
	// ########################################

	#region Variables

	public Camera m_Camera = null;				// Orthographic Camera

	[HideInInspector]
	public int m_PreviousScreenWidth;  			// Previous screen width
	[HideInInspector]
	public int m_PreviousScreenHeight; 			// Previous screen height

	#endregion // Variables

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html
	void Start()
	{
		KeepCurrentScreenSizeInfo();

		// Make sure we have Orthographic Camera
		FindOrthographicCamera();
	}

	// Update is called every frame, if the MonoBehaviour is enabled.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
	void Update()
	{

	}

	// ########################################
	// Utility functions
	// ########################################

	#region Utility Functions

	// Keep current screen width and height
	public void KeepCurrentScreenSizeInfo()
	{
		// Keep current screen width and height
		m_PreviousScreenWidth = Screen.width;
		m_PreviousScreenHeight = Screen.height;
	}

	// Find orthographic camera in the scene
	public void FindOrthographicCamera()
	{
		if (m_Camera == null)
		{
			Camera[] CameraList = FindObjectsOfType<Camera>();
			foreach (Camera child in CameraList)
			{
				if (child.orthographic == true)
				{
					// Keep only first Orthographic Camera
					m_Camera = child;
					break;
				}
			}
		}
	}

	#endregion // Utility Functions
}
