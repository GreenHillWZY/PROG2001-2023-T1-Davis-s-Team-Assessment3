using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BirdSpeak : MonoBehaviour
{
    public float radius = 1.5f;

    // �ɽ�������� tag
    public string interactableTag = "Interactable";

    // ���������İ���
    public KeyCode interactionKey = KeyCode.E;

    // ���� Prefab�����ڴ����Ի���
    public GameObject dialogPrefab;

    // �����ı���������ʾ�Ի�������
    public TextMeshProUGUI dialogText;

    private bool isInRange;
    private GameObject interactableObject;

    void Update()
    {
        // ���������¼������û�����ָ���İ���ʱ������Ƿ��ڴ�������Χ�ڣ�������򵯳��Ի���
        if (Input.GetKeyDown(interactionKey) && isInRange)
        {
            ShowDialog("Hello, world!");
        }
    }

    // �������Ƿ���봥������Χ��
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(interactableTag))
        {
            interactableObject = other.gameObject;
            isInRange = true;
        }
    }

    // �������Ƿ��뿪��������Χ
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == interactableObject)
        {
            interactableObject = null;
            isInRange = false;
        }
    }

    // ��ʾ�Ի���ĺ���
    public void ShowDialog(string message)
    {
        // �����Ի���ʵ������������λ�úʹ�С������
        GameObject dialog = Instantiate(dialogPrefab, transform.position, Quaternion.identity);
        dialog.transform.SetParent(transform, false);

        // ��ȡ�Ի����е��ı����������������ʾ����
        TextMeshProUGUI dialogText = dialog.GetComponentInChildren<TextMeshProUGUI>();
        dialogText.text = message;

        // ��ʾ�Ի���
        dialog.SetActive(true);
    }
}
