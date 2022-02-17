using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using uAdventure.Runner;
public class HideInventory : MonoBehaviour {

	// Use this for initialization
	void Update () {
        if (Game.Instance.GameState.CurrentTarget == "Menu" || Game.Instance.GameState.CurrentTarget == "NotasFinales") InventoryManager.Instance.Show = false;
	}
	
}
