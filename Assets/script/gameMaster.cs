using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public Transform spawnPos;
	private GameObject playerInScene;
	public GameObject myPlayer;
	public static bool isWon=false;
	public static int mySpeed=3;
	// Use this for initialization
	void Start () {
		playerInScene = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInScene==null){
			GameObject go;
			Vector2 spawnPos2D;
			spawnPos2D = new Vector2(spawnPos.transform.position.x,spawnPos.transform.position.y);
			go = Instantiate(myPlayer,spawnPos2D, Quaternion.identity)as GameObject;
			playerInScene = GameObject.FindWithTag("Player");
			print ("create player");
		}
		if(isWon){
			levelSelect();
			isWon=false;
		}
		if(Input.GetKeyUp(KeyCode.Escape)){
			
			SceneManager.LoadScene("menu");
		}
	}
	void levelSelect(){
		//SceneManager.LoadScene("002");
		string thisLevel;
		thisLevel = SceneManager.GetActiveScene().name; 
		switch(thisLevel){			
			case "01":
				SceneManager.LoadScene("02");
				break;
			case "02":
				SceneManager.LoadScene("03");
				break;
			case "03":
				SceneManager.LoadScene("04");
				break;
			case "04":
				SceneManager.LoadScene("05");
				break;
			case "05":
				SceneManager.LoadScene("06");
				break;
			case "06":
				SceneManager.LoadScene("07");
				break;
			case "07":
				SceneManager.LoadScene("08");
				break;
			case "08":
				SceneManager.LoadScene("09");
				break;
			case "09":
				SceneManager.LoadScene("10");
				break;
			case "10":
				SceneManager.LoadScene("11");
				break;
			case "11":
				SceneManager.LoadScene("12");
				break;
			case "12":
				SceneManager.LoadScene("13");
				break;
			case "13":
				SceneManager.LoadScene("14");
				break;
            case "14":
                SceneManager.LoadScene("15");
                break;
            case "15":
				SceneManager.LoadScene("00home");
				break;			

			default:
				break;
		}
	}
}
