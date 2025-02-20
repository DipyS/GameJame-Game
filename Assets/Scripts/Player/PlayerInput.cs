using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private SwitchPlayer _switchPlayer;
    [SerializeField] protected bool _isSwitch = true;

    private const string AxisHorizontal = "Horizontal";
    private const KeyCode KeyJump = KeyCode.Space;
    private const KeyCode KeyWorldChanges = KeyCode.F;

    private float _horizontalDirection;
    private PlayerMovement _playerMovement;

    public SwitchPlayer SwitchPlayer => _switchPlayer;
    public float HorizontalDirection => _horizontalDirection;

    private void Awake() => _playerMovement = GetComponent<PlayerMovement>();

    private void Update()
    {
        _horizontalDirection = Input.GetAxisRaw(AxisHorizontal);

        if (Input.GetKeyDown(KeyJump))
        {
            _playerMovement.TryJump();
        }
        else if (Input.GetKeyDown(KeyWorldChanges))
        {
            _switchPlayer.Switch();
        }
    }
}
