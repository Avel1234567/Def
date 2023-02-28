using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void OnMouseUp() //������� ����� �����
    {
        anim.SetTrigger("srart_buttonUp");
    }
}
