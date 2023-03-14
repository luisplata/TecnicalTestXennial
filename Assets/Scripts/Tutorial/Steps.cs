using UnityEngine;

public class Steps : MonoBehaviour
{
    [SerializeField] private Step[] steps;

    public Step GetStep(int index)
    {
        if (index >= steps.Length)
        {
            return steps[^1];
        }

        if (index < 0)
        {
            return steps[0];
        }

        return steps[index];
    }

    public int GetCount()
    {
        return steps.Length;
    }
}