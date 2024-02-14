using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxManager : MonoBehaviour
{
	private string _correctGemOrder = "BlueRedGreen";
	private string _enteredGemOrder = "";

	[SerializeField] private Animator boxAnimator;
	
	

	private int _amountOfGems = 3;
	private int _currentGem = 0;

	[SerializeField] private Gem[] _gemsInScene;

	[SerializeField] private UnityEvent _gameIsWon;



	public void GemSelect(Gem currentSelectedGem)
	{
		//add the color of the gem to the enteredGemOrder
		_enteredGemOrder += currentSelectedGem.gemColor;

		//increment our currentGem
		_currentGem++;

		currentSelectedGem.ChangeEmission(true);

		//if currentGem == amountOfGems, compare enteredOrder to correctOrder
		if (_currentGem == _amountOfGems)
		{
			CompareGemOrder();
		}
	}

	void CompareGemOrder()
	{
		if (_enteredGemOrder == _correctGemOrder)
		{
			CompleteGame();
			
				
		}
		else
		{
			ResetGame();
		}
	}
	void CompleteGame()
	{
		_gameIsWon.Invoke();
	}

	void ResetGame()
	{
		_currentGem = 0;
		_enteredGemOrder = "";
		
		foreach(var Gem in _gemsInScene)
		{
			Gem.ChangeEmission(false);
		}
	}

}

