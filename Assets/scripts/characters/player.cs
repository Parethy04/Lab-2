using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;




public class player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpforce;

    [Header("camera")]
    [SerializeField, Range(1, 20)] private float mouseSensX;
    [SerializeField, Range(1, 20)] private float mouseSensY;

    [SerializeField, Range(-90, 0)] private float minViewAngle;
    [SerializeField, Range(0, 90)] private float maxViewAngle;

    [SerializeField] private Transform followTarget;

    [Header("shooting")]
    [SerializeField] private Rigidbody bulletPrefab;
    [SerializeField] private float projectileForce;

    [Header("Player UI")]
    [SerializeField] private Image healthBar;
    [SerializeField] private TextMeshProUGUI shotsFired;

    [SerializeField] private float maxHealth;

    [SerializeField] private int maxAmmo = 10;
    [SerializeField] private TextMeshProUGUI ammoText;

    private int currentAmmo;
    private bool isReloading = false;

    private int shotsFiredCounter;
    private float _health;

    private float Health 
    {
        get => _health;
        set
        {
            _health = value;
            healthBar.fillAmount = _health / maxHealth;
        }
    
    }



    private Vector2 currentAngle;

    private bool isGrounded;
    private Vector3 _MoveDirection;
    private Rigidbody rb;

    private int coinCount = 0;

    public void collection()
    {
        coinCount++;
        Debug.Log("Coins Collected: " + coinCount);

    }

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(myplayer: this);
        InputManager.setgamecontrols();

        rb = GetComponent<Rigidbody>();

        Health = maxHealth;

        currentAmmo = maxAmmo;
        UpdateAmmoText(); // Call this function to display the initial ammo count.
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation * (speed * Time.deltaTime * _MoveDirection);
        checkGround();

        if (Input.GetKeyDown(KeyCode.R) && !isReloading)
        {
            StartCoroutine(ReloadAmmo());
        }
    }

    IEnumerator ReloadAmmo()
    {
        isReloading = true;
        // Implement any reloading animation or delay here.
        yield return new WaitForSeconds(1.5f); // Adjust the time as needed.

        currentAmmo = maxAmmo;
        UpdateAmmoText(); // Update the UI to reflect the reloaded ammo.

        isReloading = false;
    }

    void UpdateAmmoText()
    {
        // Assuming you have TextMeshProUGUI elements named "shotsFired" and "ammoText."
        shotsFired.text = "Shots Fired: " + shotsFiredCounter;
        ammoText.text = "Ammo: " + currentAmmo + " / " + maxAmmo;
    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _MoveDirection = currentDirection;

        Health -= Time.deltaTime * 200;
    }

    public void jump()
    {
        Debug.Log("jump called");
        if (isGrounded)
        {
            Debug.Log("I jumped");
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }

    private void checkGround()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position, Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green, duration: 0, depthTest: false);
    }

    //for camera view and rotation
    public void setLookRotation(Vector2 readvalue)
    {

        currentAngle.x += readvalue.x * Time.deltaTime * mouseSensX;
        currentAngle.y += readvalue.y * Time.deltaTime * mouseSensY;

        currentAngle.y = Mathf.Clamp(currentAngle.y, minViewAngle, maxViewAngle);


        transform.rotation = Quaternion.AngleAxis(currentAngle.x, Vector3.up);
        followTarget.localRotation = Quaternion.AngleAxis(currentAngle.y, Vector3.right);
    }

    public void Shoot()
    {
        if (currentAmmo > 0 && !isReloading)
        {
            Rigidbody currentProjectile = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            currentProjectile.AddForce(followTarget.forward * projectileForce, ForceMode.Impulse);

            ++shotsFiredCounter;
            UpdateAmmoText(); // Update the ammo count after shooting.

            Destroy(currentProjectile.gameObject, t: 4);

            // Decrease the ammo count.
            currentAmmo--;
            UpdateAmmoText();
        }
    }

    public void GainAmmo(int amount)
    {
        currentAmmo += amount;
        currentAmmo = Mathf.Clamp(currentAmmo, 0, maxAmmo); // makes sure not to exceed ammo count
        UpdateAmmoText();
    }
}
