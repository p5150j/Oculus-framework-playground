using System;

namespace Models
{
	[Serializable]
	public class Post
	{
		

		public bool state;



		public override string ToString(){
			return UnityEngine.JsonUtility.ToJson (this, true);
		}
	}



	[Serializable]
	public class ServerResponse
	{
		public string id;
		public string date; //DateTime is not supported by JsonUtility
	}
}

