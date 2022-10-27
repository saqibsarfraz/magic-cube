using UnityEngine;

public enum Direction
{
    X,
    Y,
    Z
}

public class InteractionPoint : MonoBehaviour
{
    [SerializeField]
    Transform parent;
    [SerializeField]
    Transform oppositeParent;
    [SerializeField]
    Direction direction;
    [SerializeField]
    float scaleFactor = 0.2f;

    Transform cube;
    private void Start()
    {
        cube = transform.parent;
    }
    private void OnMouseDown()
    {
        cube.SetParent(parent);
        oppositeParent.SetParent(cube);

        switch (direction)
        {
            case Direction.X:
                parent.transform.localScale = new Vector3(parent.transform.localScale.x + scaleFactor, parent.transform.localScale.y, parent.transform.localScale.z);
                break;
            case Direction.Y:
                parent.transform.localScale = new Vector3(parent.transform.localScale.x, parent.transform.localScale.y + scaleFactor, parent.transform.localScale.z);

                break;
            case Direction.Z:
                parent.transform.localScale = new Vector3(parent.transform.localScale.x, parent.transform.localScale.y, parent.transform.localScale.z + scaleFactor);

                break;
        }

    }
    private void OnMouseUp()
    {
        oppositeParent.SetParent(null);
    }
}