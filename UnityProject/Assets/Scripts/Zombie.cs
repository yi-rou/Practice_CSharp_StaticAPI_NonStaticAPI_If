using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float HP = 100;
    [Header("攻擊力")]
    public float attack;
    public Player player;
    public AudioSource aud;
    public AudioClip soundAttack;
    private void Update()
    {
        Attack();
        if (Input.GetKeyDown(KeyCode.B) && player.HP <= 0)
        {
            print("玩家死亡");
        }
    }

    private void Attack()
    {
        if (player.HP <=0 || HP <= 0) return;

        if (Input.GetKeyDown(KeyCode.B))
        {
            attack = Random.Range(9.9f,23.5f);
            print("玩家受到傷害" + attack);
            player.HP = player.HP - attack;
            print("玩家剩下血量" + player.HP);
            aud.PlayOneShot(soundAttack);
        }
    }

}
