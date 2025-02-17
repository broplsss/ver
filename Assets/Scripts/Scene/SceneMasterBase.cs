﻿/******************************************************************************
*  @file       SceneMasterBase.cs
*  @brief      Abstract base class for SceneMaster classes
*  @author     
*  @date       July 20, 2015
*      
*  @par [explanation]
*		> 
******************************************************************************/

#region Namespaces

using UnityEngine;
using System.Collections;

#endregion // Namespaces

public abstract class SceneMasterBase : MonoBehaviour
{
	#region Public Interface

	/// <summary>
	/// Loads resources for this scene master's scene.
	/// </summary>
	public abstract bool Load();

	/// <summary>
	/// Unloads resources.
	/// </summary>
	public abstract bool Unload();

	/// <summary>
	/// Starts the scene.
	/// </summary>
	public abstract void StartScene();

	/// <summary>
	/// Notifies of scene pause.
	/// </summary>
	public virtual void NotifyPause() {}

	/// <summary>
	/// Notifies of scene unpause.
	/// </summary>
	public virtual void NotifyUnpause() {}

	/// <summary>
	/// Notifies of scene quit.
	/// </summary>
	public virtual void NotifyQuit() {}

	/// <summary>
	/// Gets whether this instance has finished initialization.
	/// </summary>
	/// <value><c>true</c> if this instance is initialized; otherwise, <c>false</c>.</value>
	public bool IsInitialized
	{
		get { return m_isInitialized; }
	}

	// References to transforms in the base scene hierarchy
	public Transform TouchDebugger
	{
		get { return m_containerReferences.TouchDebugger; }
	}
	public Transform Gameplay
	{
		get { return m_containerReferences.Gameplay; }
	}
	public Transform DynamicObjects
	{
		get { return m_containerReferences.DynamicObjects; }
	}
	public Transform World
	{
		get { return m_containerReferences.World; }
	}
	public Transform UI
	{
		get { return m_containerReferences.UI; }
	}
	public Transform Sound
	{
		get { return m_containerReferences.Sound; }
	}
	public UICamera UICamera
	{
		get { return m_containerReferences.UICamera; }
	}

	#endregion // Public Interface

	#region Variables

	protected bool m_isInitialized = false;

	protected ContainerReferences m_containerReferences = null;

	#endregion // Variables

	#region MonoBehaviour

	/// <summary>
	/// Awake this instance.
	/// </summary>
	protected virtual void Awake()
	{
		m_containerReferences = this.GetComponent<ContainerReferences>();
	}

	/// <summary>
	/// Start this instance.
	/// </summary>
	protected virtual void Start()
	{

	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	protected virtual void Update()
	{
		
	}

	/// <summary>
	/// Raises the destroy event.
	/// </summary>
	protected virtual void OnDestroy()
	{
		
	}

	#endregion // MonoBehaviour
}
