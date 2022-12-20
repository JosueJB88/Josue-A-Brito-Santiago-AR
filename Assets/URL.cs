using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
	public string Url;
	 
	public	void Open(string Url)
	{
		Application.OpenURL(Url);	
	}
 
}
