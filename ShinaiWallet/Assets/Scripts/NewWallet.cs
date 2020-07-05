using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using NBitcoin;
using UnityEngine.SceneManagement;

public class NewWallet : MonoBehaviour
{
	// Start is called before the first frame update

	public static NBitcoin.Network network = NBitcoin.Network.TestNet;
	void Start()
	{
		// Bitcoin.
		string[] wordsArray = BIP39.GetWordListArray();
		Wordlist wordList = new Wordlist(wordsArray, ' ', "m1");
		Mnemonic m1 = new Mnemonic(wordList);
	}

	public void OnButtonClick()
	{
		SceneManager.LoadScene("Wordscene");
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}

