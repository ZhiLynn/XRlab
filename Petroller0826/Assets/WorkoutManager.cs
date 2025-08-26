using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkoutManager : MonoBehaviour
{
    public Animator animator;               // 角色 Animator
    public TextMeshProUGUI textMeshPro;     // 顯示倒數文字

    private float currentTime;
    private bool isCounting = false;        // 是否正在運動倒數
    private bool isResting = false;         // 是否正在休息
    private string currentAnimation = "";   // 紀錄現在是哪個動作

    void Update()
    {
        // 按下 S 開始 Squat
        if (Input.GetKeyDown(KeyCode.S) && !isCounting && !isResting)
        {
            StartWorkout("isSquating");
        }

        // 按下 P 開始 Plank
        if (Input.GetKeyDown(KeyCode.P) && !isCounting && !isResting)
        {
            StartWorkout("isPlanking");
        }

        // 按下 U 開始 Uping
        if (Input.GetKeyDown(KeyCode.U) && !isCounting && !isResting)
        {
            StartWorkout("isUping");
        }

        // 運動倒數中
        if (isCounting)
        {
            currentTime -= Time.deltaTime;
            textMeshPro.text = Mathf.Ceil(currentTime).ToString();

            if (currentTime <= 0)
            {
                // 運動結束 → 關閉動畫，進入休息
                animator.SetBool(currentAnimation, false);
                isCounting = false;

                currentTime = 10f; // 休息時間
                isResting = true;
            }
        }

        // 休息倒數中
        if (isResting)
        {
            currentTime -= Time.deltaTime;
            textMeshPro.text = "Rest: " + Mathf.Ceil(currentTime).ToString();

            if (currentTime <= 0)
            {
                isResting = false;
                textMeshPro.text = "Ready!";
            }
        }
    }

    // 開始一個運動
    void StartWorkout(string animationBool)
    {
        currentTime = 20f; // 運動 20 秒
        isCounting = true;
        currentAnimation = animationBool;
        animator.SetBool(animationBool, true);
    }
}
