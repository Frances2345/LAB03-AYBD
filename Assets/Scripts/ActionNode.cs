public class ActionNode
{
    public enum Actions
    {
        Atacar,
        Defender,
        Rebelarse,
        Engañar,
        Mover
    }

    public Actions currentAction;
    public ActionNode next;

    public ActionNode(Actions action)
    {
        currentAction = action;
        next = null;
    }
}


