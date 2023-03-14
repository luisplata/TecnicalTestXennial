using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterOfSteps : MonoBehaviour
{
    [SerializeField] private Image imageStep;
    [SerializeField] private TextMeshProUGUI textStep;
    
    private ILogicMediator _logicMediator;

    public void ShowData(Step step)
    {
        imageStep.sprite = step.GetImage();
        textStep.text = step.GetText();
    }

    public void Configurate(ILogicMediator logicMediator)
    {
        _logicMediator = logicMediator;
    }
}