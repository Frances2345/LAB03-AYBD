using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections;
using TMPro;

public class PlayerActions : MonoBehaviour
{
    public TextMeshProUGUI UIText;

    private ActionNode head;
    private ActionNode tail;

    [Button]
    public void AddAction(ActionNode.Actions type)
    {
        ActionNode newNode = new ActionNode(type);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        UIText.text = "Accion en cola: " + type.ToString();
        Debug.Log("Accion Puesta: " + type.ToString());
    }

    [Button]
    public void RunSequence()
    {
        if (head != null)
        {
            StartCoroutine(ExecuteRoutine());
        }
        else
        {
            Debug.Log("La lista está vacía.");
        }
    }

    IEnumerator ExecuteRoutine()
    {
        ActionNode temp = head;
        while (temp != null)
        {
            UIText.text = "Ejecutando: " + temp.currentAction.ToString().ToUpper();
            yield return new WaitForSeconds(1.0f);
            temp = temp.next;
        }
        Debug.Log("Fin del turno automático.");
    }

    [Button]
    public void ClearList()
    {
        head = null;
        tail = null;
        Debug.Log("Lista reiniciada.");
    }
}
