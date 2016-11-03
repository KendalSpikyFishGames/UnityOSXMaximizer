using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections;

public class OpenMaximized : MonoBehaviour {

	#if UNITY_STANDALONE_OSX || UNITY_EDITOR_OSX
	/// <summary>
	/// Inits the plugin. Plugin will only do one thing so this is ok
	/// </summary>
	/// <returns>Unity Maximizer</returns>
	/// <param name="inwidth">In Width.</param>
	/// <param name="inHeight">In Height.</param>
	[DllImport ("UnityMaximize")]
	public static extern int InitPlugin(float inwidth, float inHeight);
	#endif

	void Awake () 
	{
		InitPlugin(Display.displays[0].renderingWidth,Display.displays[0].renderingHeight);
	}
	


}
