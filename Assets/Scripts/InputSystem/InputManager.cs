using UnityEngine;

public class InputManager : MonoBehaviour
{
    private GameControls gameControls;

    public Vector3 moveDirection { get; private set; }

    private void Awake()
    {
        gameControls = new GameControls();

        gameControls.Enable();
    }

}
