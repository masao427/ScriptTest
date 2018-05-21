using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public class Boss
    {
        private int hp = 100;   // 体力
        private int power = 25; // 攻撃力
        private int mp = 53;    // マジックポイント

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");

            // 残りhpを減らす
            this.hp -= damage;
        }

        // 魔法用の関数
        public void Magic()
        {
            if (mp >= 5)
            {
                // 残りmpを減らす
                this.mp -= 5;

                Debug.Log("魔法攻撃をした。残りMPは " + this.mp + " 。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    void Start()
    {
        // 課題: 配列を宣言して出力しましょう
        int[] points = new int[5];

        // 各配列要素に値を代入
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        Debug.Log("課題: 配列を宣言して出力しましょう");

        // 配列の要素をすべて表示する
        Debug.Log("配列を順番に表示");
        for (int i = 0; i < 5; i++)
        {
            // 配列の各要素の値を順番に表示
            Debug.Log(points[i]);
        }

        // 配列の要素をすべて表示する
        Debug.Log("配列を逆順に表示");
        for (int i = 4; i >= 0; i--)
        {
            // 配列の各要素の値を逆順に表示
            Debug.Log(points[i]);
        }


        // 発展課題: Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();

        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        Debug.Log("発展課題: Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう");
        for (int j = 0; j <= 10; j++)
        {
            Debug.Log("魔法発動 " + (j + 1) + " 回目。");
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
