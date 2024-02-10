using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    private string _correctGemOrder = "BlueRedGreen";
    private string _enteredGemOrder = "";

    [SerializeField] private Animator boxAnimator;

    private int _amountOfGems = 3;
    private int _currentGem = 0;

    [SerializeField] private Gem[] _gemsInScene;


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
            OpenBox();
        }
        else
        {
            ResetGame();
        }
    }
    void OpenBox()
    {
        boxAnimator.SetTrigger("Open");
    }

    void ResetGame()
    {
        _currentGem = 0;
        _enteredGemOrder = "";
    }

}

