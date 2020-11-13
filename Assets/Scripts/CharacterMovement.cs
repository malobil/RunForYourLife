using System.Collections;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody m_rbComp = null;

    [SerializeField] private float m_horizontalWalkMoveSpeed = 3f;
    [SerializeField] private float m_verticalWalkMoveSpeed = 3f;
    [SerializeField] private float m_horizontalSprintMoveSpeed = 5f;
    [SerializeField] private float m_verticalSprintMoveSpeed = 5f;

    [SerializeField] private float m_jumpForce = 3f; 
    [SerializeField] private float m_jumpDetection = 5f;
    [SerializeField] private LayerMask m_jumpLayersDetection = 0;

    [SerializeField] private float m_dashForce = 5f;
    [SerializeField] private float m_dashDuration = 0.5f;
    

    [SerializeField] private Transform m_characterBody = null;
    [SerializeField] private Transform m_camera = null;
    [SerializeField] private float m_horizontalSensibility = 1f;
    [SerializeField] private float m_verticalSensibility = 1f;

    private bool m_canMove = true ;
    private bool m_canJump = true ;
    private bool m_canDash = true;
    private bool m_canResetDash = false;

    private float m_currentHorizontalMoveSpeed;
    private float m_currentVerticalMoveSpeed;
    private float xRotation = 0f;
    private CharacterControls m_inputs;

    private void Awake()
    {
        SetupInputs();
    }

    // Start is called before the first frame update
    void Start()
    {
        Walk();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        UpdateCamera();

        if(m_canResetDash && CheckJump())
        {
            m_canDash = true;
            m_canResetDash = false;
        }
    }

    private void Move()
    {
        if (!m_canMove)
            return;

        float horizontalInput = -m_inputs.StandardInputs.Move.ReadValue<Vector2>().x;
        float verticalInput = m_inputs.StandardInputs.Move.ReadValue<Vector2>().y;

        Vector3 forwardMovement = m_characterBody.forward * verticalInput * m_currentHorizontalMoveSpeed;
        Vector3 horizontalMovement = m_characterBody.right * horizontalInput * m_currentVerticalMoveSpeed;
        Vector3 verticalMovement = new Vector3(0, m_rbComp.velocity.y, 0);

        m_rbComp.velocity = forwardMovement + horizontalMovement + verticalMovement;
    }

    private void UpdateCamera()
    {
        float mouseX = m_inputs.StandardInputs.MouseDelta.ReadValue<Vector2>().x * m_horizontalSensibility;
        float mouseY = m_inputs.StandardInputs.MouseDelta.ReadValue<Vector2>().y * m_verticalSensibility;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        m_characterBody.Rotate(Vector3.up * mouseX);
        m_camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }

    private void Sprint()
    {
        m_currentHorizontalMoveSpeed = m_horizontalSprintMoveSpeed;
        m_currentVerticalMoveSpeed = m_verticalSprintMoveSpeed;
    }

    private void Walk()
    {
        m_currentHorizontalMoveSpeed = m_horizontalWalkMoveSpeed;
        m_currentVerticalMoveSpeed = m_verticalWalkMoveSpeed;
    }

    private void Jump()
    {
        if(CheckJump() && m_canJump)
        {
            ResetYVelocity();
            m_rbComp.AddForce(m_characterBody.up * m_jumpForce, ForceMode.Impulse);
        }
    }

    private void Dash()
    {
        if (!m_canDash)
            return;

        m_canMove = false;
        m_canJump = false;
        m_canDash = false;
        m_rbComp.AddForce(m_camera.forward * m_dashForce, ForceMode.VelocityChange);
        StartCoroutine(UpdateDashCoolDown());
    }

    IEnumerator UpdateDashCoolDown()
    {
        yield return new WaitForSeconds(m_dashDuration);
        m_canJump = true;
        m_canMove = true;
        m_canResetDash = true;
    }

    private bool CheckJump()
    {
        //Debug.DrawRay(m_characterBody.position, -m_characterBody.up * m_jumpDetection, Color.red,1000f) ;
        return Physics.Raycast(m_characterBody.position, -m_characterBody.up, m_jumpDetection, m_jumpLayersDetection); 
    }

    private void ResetYVelocity()
    {
        m_rbComp.velocity = new Vector3(m_rbComp.velocity.x, 0, m_rbComp.velocity.z);
    }

    private void SetupInputs()
    {
        m_inputs = new CharacterControls();
        m_inputs.Enable();
        m_inputs.StandardInputs.Sprint.performed += ctx => Sprint() ;
        m_inputs.StandardInputs.Sprint.canceled += ctx => Walk() ;
        m_inputs.StandardInputs.Jump.performed += ctx => Jump() ;
        m_inputs.StandardInputs.Dash.performed += ctx => Dash() ;
    }
}
