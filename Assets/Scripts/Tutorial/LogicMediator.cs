using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicMediator : MonoBehaviour, ILogicMediator
{
    [SerializeField] private GameObject panelToWelcome, buttonNext, buttonPrevious;
    [SerializeField] private TextMeshProUGUI textOfButtonNext;
    [SerializeField] private CounterOfSteps counter;
    [SerializeField] private Steps steps;

    private int _indexOfStep;

    private void Start()
    {
        panelToWelcome.SetActive(true);
        buttonPrevious.SetActive(false);
        buttonNext.SetActive(true);
        counter.Configurate(this);
        _indexOfStep = -1;
    }

    public void HidePanelToWelcome()
    {
        panelToWelcome.SetActive(false);
    }

    public void NextStep()
    {
        _indexOfStep++;
        if (_indexOfStep >= 0)
        {
            //hide welcome panel
            panelToWelcome.SetActive(false);
        }
        
        if (_indexOfStep > 0)
        {
            //show previous button
            buttonPrevious.SetActive(true);
        }

        if (_indexOfStep > steps.GetCount() - 2)
        {
            //when show the last panel
            textOfButtonNext.text = "Play";
        }
        
        if (_indexOfStep > steps.GetCount()-1)
        {
            //Launch Game!
            Debug.Log("Launch Game!");
            SceneManager.LoadScene(1);
            return;
        }
        ShowData();
    }

    private void ShowData()
    {
        var step = steps.GetStep(_indexOfStep);
        counter.ShowData(step);
    }

    public void PreviousStep()
    {
        _indexOfStep--;
        if (_indexOfStep <= 0)
        {
            //hide previous button
            buttonPrevious.SetActive(false);
        }
        textOfButtonNext.text = ">";
        ShowData();
    }

}