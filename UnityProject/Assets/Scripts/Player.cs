using UnityEngine;
using UnityEditor.UI;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float HP = 100;
    [Header("攻擊力")]
    public float attack ;
    public Zombie zombie;
    public AudioSource aud;
    public AudioClip soundAttack;
    private void Update()
    {
       Attack();
        
        if (Input.GetKeyDown(KeyCode.A) && zombie.HP <= 0)
        {
            print("殺死殭屍");
        }
       
    }

    private void Attack()
    {
        if (zombie.HP <= 0 || HP <= 0) return;

        if (Input.GetKeyDown(KeyCode.A))
        {
            attack = Random.Range(10.9f, 25.6f);
            zombie.HP = zombie.HP - attack;
            print("殭屍受到傷害" + attack);
            print("殭屍生下血量" + zombie.HP);
            aud.PlayOneShot(soundAttack);
        }

    }

}
