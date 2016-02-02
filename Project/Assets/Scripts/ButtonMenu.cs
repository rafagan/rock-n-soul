using UnityEngine;
using System.Collections;

public class ButtonMenu : MonoBehaviour {

    public Animator animator;
    public bool goAbout;
    public bool goMenu;
    // Use this for initialization
    void OnClick()
    {
        animator.SetBool("GoAbout", goAbout);
        animator.SetBool("GoMenu", goMenu);
    }
}
