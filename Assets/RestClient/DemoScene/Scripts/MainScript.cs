using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;

public class MainScript : MonoBehaviour {

	private readonly string basePath = "http://10.0.0.187:8888/relays/3";
	private RequestHelper currentRequest;

	private void LogMessage(string state, string message) {
#if UNITY_EDITOR
		EditorUtility.DisplayDialog (state, message, "Ok");
#else
		Debug.Log(message);
#endif
	}

	

	public void Post(){
		RestClient.Post<ServerResponse>("http://10.0.0.187:8888/relays/3", new Post
		{
			state = true,
		
		}).Then(response => {
			EditorUtility.DisplayDialog("ID: ", response.id, "Ok");
			EditorUtility.DisplayDialog("Date: ", response.date, "Ok");
		});
	}

	
}