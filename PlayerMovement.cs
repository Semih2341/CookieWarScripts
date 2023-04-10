using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{   public float runSpeed;
    float horizontalMove=0f;
    bool jump = false;
    bool crouch = false;
    public CharacterController2D controller;
    public Animator animator;
    public int can = 100;
    public GameObject efekt;
    public int maxHealth = 100;
    public int currentHealth;
    public Joystick joystick;
    public Text ScoreText;
    public GameObject pausemenu;
    int puan = 0;
    public GameObject DeathMenu;
    public GameObject OptionsMenu;
    private void Start()
    {
        maxHealth = can;
        currentHealth = maxHealth;
    }
    void Update()
    {
        if (transform.position.y <= -8)
        {
            death();
        }
        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
        }
        else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0;
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (joystick.Vertical>.5f && joystick.Vertical<8.9){
            jump = true;
            Debug.Log("zıpladı");
            animator.SetBool("Isjumping", true);
            
        }
        if (joystick.Vertical<=-.9f)
        {
            crouch = true;
            Debug.Log("bastı");
        }
         else
            {
            crouch = false;
            Debug.Log("çekti");
            }


    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    public void isjumping()
    {
        animator.SetBool("Isjumping", false);
    }
    public void egilme(bool isCrouching)
    {
        animator.SetBool("Crouch", isCrouching);
    }
    public void takeDamage(int damage)
    {
        can -= damage;
        currentHealth = can;
        FindObjectOfType<healhBarScript>().canbarı(can);
            if (can <= 0)
        {
            death();
        }
    }
    public void death()
    {   
        Instantiate(efekt, transform.position , Quaternion.identity);
        Destroy(gameObject);
        CinemachineShake.Instance.ShakeCamera(50f, .5f);

        FindObjectOfType<öldürme>().öldür();
        FindObjectOfType<öldürme>().öldü(puan);
    }
    public void score()
    {
        puan+=10;
        ScoreText.text = puan.ToString();

    }
    public void pause()
    {   
        pausemenu.SetActive(true);
        Time.timeScale = 0f;

    }
    public void Options()
    {
        pausemenu.SetActive(false);
        OptionsMenu.SetActive(true);
        Debug.Log("OLdu12");
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
    


}
