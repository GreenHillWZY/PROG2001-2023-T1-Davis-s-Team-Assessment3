using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BirdSpeak : MonoBehaviour
{
    public float radius = 1.5f;

    // 可交互对象的 tag
    public string interactableTag = "Interactable";

    // 按键交互的按键
    public KeyCode interactionKey = KeyCode.E;

    // 弹窗 Prefab，用于创建对话框
    public GameObject dialogPrefab;

    // 弹窗文本框，用于显示对话框内容
    public TextMeshProUGUI dialogText;

    private bool isInRange;
    private GameObject interactableObject;

    void Update()
    {
        // 监听键盘事件，当用户按下指定的按键时，检查是否在触发器范围内，如果是则弹出对话框
        if (Input.GetKeyDown(interactionKey) && isInRange)
        {
            ShowDialog("Hello, world!");
        }
    }

    // 检测对象是否进入触发器范围内
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(interactableTag))
        {
            interactableObject = other.gameObject;
            isInRange = true;
        }
    }

    // 检测对象是否离开触发器范围
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == interactableObject)
        {
            interactableObject = null;
            isInRange = false;
        }
    }

    // 显示对话框的函数
    public void ShowDialog(string message)
    {
        // 创建对话框实例，并设置其位置和大小等属性
        GameObject dialog = Instantiate(dialogPrefab, transform.position, Quaternion.identity);
        dialog.transform.SetParent(transform, false);

        // 获取对话框中的文本框组件，更新其显示内容
        TextMeshProUGUI dialogText = dialog.GetComponentInChildren<TextMeshProUGUI>();
        dialogText.text = message;

        // 显示对话框
        dialog.SetActive(true);
    }
}
