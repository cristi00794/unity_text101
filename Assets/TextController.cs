using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	
	public Text text;
	private enum States{cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.cell){
			state_cell();
		} else if(myState == States.sheets_0){
			state_sheets_0();
		} else if(myState == States.lock_0){
			state_lock_0();
		} else if(myState == States.lock_1){
			state_lock_1();
		} else if(myState == States.sheets_1){
			state_sheets_1();
		} else if(myState == States.mirror){
			state_mirror();
		} else if(myState == States.cell_mirror){
			state_cell_mirror();
		} else if(myState == States.freedom){
			state_freedom();
		}
	}
	
	void state_lock_0(){
		text.text = "Aceasta e una dintre incuietorile alea cu taste. Habar nu ai care este combinatia corecta " +
					"Ti-ai dori sa vezi pe ce taste s-a apasat inainte, asta sigur te-ar ajuta \n\n" +
					"Apasa R ca sa interci la cotrobaitul prin celula";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_freedom(){
		text.text = "Esti LIBER!!!!" +
				"Apasa P sa joci din nou!\n\n\n " +
				"Credits: Cristache Georgian Cristian";
		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.cell;
		}
	}
	
	void state_mirror(){
		text.text = "Oglinda murdara de pe perete pare subreda\n\n" +
					"Apasa T sa Iei oglinda sau apasa R ca sa interci la cotrobaitul prin celula";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		} else if(Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	
	void state_cell_mirror(){
		text.text = "Inca esti in celula ta jegoasa si INCA vrei sa scapi. Pe pat se afla niste cearsafuri murdare pe pat, " +
					"iar pe perete este o urma unde era inainte oglinda. Usa este tot acolo si la fel de incuiata! \n\n" + 
					"Apasa S sa te uiti la cearceafuri sau L sa vezi incuietoarea.";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_1;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		}
	}
	
	void state_lock_1(){
		text.text = "Cu grija iei oglinda si o introduci printre bare, intorcand-o astfel incat sa poti vedea incuietoarea " +
					"Cu greu iti dai seama ce butoane au fost apasate. Apesi pe butoanele alea murdare si auzi un CLICK \n\n" +
					"Apasa O sa Deschizi, sau R sa te intorci la celula";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		} else if(Input.GetKeyDown(KeyCode.O)){
			myState = States.freedom;
		}
	}
	
	void state_sheets_0(){
		text.text = "Nu poti sa crezi ca ai ajuns sa dormi in mizeriile astea. Ar fi timpul ca cineva sa le schimbe! " +
					"Banuiesc ca astea sunt placerile vietii de inchisoare.. \n\n" +
					"Apasa R ca sa interci la cotrobaitul prin celula";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	
	void state_sheets_1(){
		text.text = "Degeaba stai cu oglinda in mana, ca tot murdare sunt. \n\n" +
					"Apasa R ca sa intorci la cotrobaitul prin celula";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}
	
	void state_cell(){
		text.text = "Esti intr-o celula de inchisoare si vrei sa te eliberezi. Sunt " + 
			"niste sosete murdare pe pat, o oglinda pe perete, iar usa " +
				"incuiata\n\n " + 
				"Apasa S sa te uiti la Cearceafuri, M sa te uiti la Oglinda, L sa te uiti la Incuietoare";
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		} else if(Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}		
	}
}
