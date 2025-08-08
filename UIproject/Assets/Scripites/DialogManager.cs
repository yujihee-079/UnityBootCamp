using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public class Dialog
{
    public string character; // ĳ����
    public string content; // ��ȭ �ؽ�Ʈ

    // ������ ��ư -> ���� �۾� �� �����丵 -> ������� ������ ����
    // Ŭ���� ���� �� ȣ��Ǵ� �޼ҵ� (������) /Ŭ�������� ������ ���콺 Ŭ��, ��� ����...(������) Ŭ��
    public Dialog(string character, string content)
    {
        // this�� Ŭ���� �ڽ��� �ǹ��մϴ�.
        // Ŭ������ ���� ���� �Ű������� �̸��� ���Ƽ� �����ϱ� ���� �뵵
        this.character = character;
        this.content = content;
    }
}

public class DialogManager : MonoBehaviour
{
    #region MonoSingleton
    //1)�ڱ� �ڽſ� ���� �ν��Ͻ��� ������. (����)
    public static DialogManager Instance{  get; private set; } // ������Ƽ p472p �Ӽ�.
    //Instance�� ���� ���� �� �ֽ��ϴ�.(���� ���� ���� ����)
    //��� ������ �� �� �����ϴ�.

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // DialogManager. �ش� �ν��Ͻ��� �ڱ� �ڽ��Դϴ�.

            DontDestroyOnLoad(gameObject); // this��� ���� ��ũ��Ʈ�� �ı����� ���� ���Դϴ�.
            //DDOL�� �ش� ��ġ�� �ִ� ������Ʈ�� ���� �Ѿ�� �ı����� �ʰ�
            //���� �����Ǵ� ���� ����
        }

        else
        {
            Destroy(gameObject);
        }
    }



    #endregion

    #region Field
    public TMP_Text message;

    public TMP_Text chatactor_name;

    public GameObject panel;

    public float typing_speed;

    //---------------------------------------------------------
    private Queue<Dialog> queue = new Queue<Dialog>();

    private Coroutine typing;

    private bool istyping = false;

    private Dialog current; // ������ ��ȭ ����


    #endregion

    // Update is called once per frame
    void Update()
    {
        //�����̽� Ű�� ���� �Է��� ����ƴٸ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�̺�Ʈ �ý��ۿ� ���޵� ���� �����ϰ�, �� ���� UI������ ������ ��Ȳ�̶��?
            if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            {
                //�۾� ����
                return;
            }

            // �����̽� ������ ���������� �۾����� ���( ��ȭ �Ŵ��� �ְ�, ��ȭ ���� ���)
            if (istyping) // Ÿ���� ���̸�
            {
                CompletedtLine(); // ���� �۾��� ���� ������
            }

            else
            {
                NextLine(); // ���� �������� �̵��մϴ�.
            }

        }
    }
    /// <summary>
    /// list<T]>�� Queue<T>ó�� ���� ������ �����͸� �� �Ű������� ���� �� �ֽ��ϴ�.
    /// </summary>
    /// <param name="lines">��ȭ �����Ϳ� ���� ������ ���� ������</param>
    public void StartLine(IEnumerable<Dialog> lines)
    { 
        queue.Clear();

        foreach (var line in lines)
        {
            queue.Enqueue(line);
        }

        panel.SetActive(true);
        NextLine();
    }

    // ���� �۾��� ���� �Լ�
    private void NextLine()
    {
        //�۾��� ������ �� �̻� ���ٸ�
        if (queue.Count == 0)// ��ȭ�� ����
        {
            DialogueExit();
            return;
        }
        // ť�� ����� ���� �ϳ� ���ɴϴ�.
        current = queue.Dequeue();
        //���� ��ȭ ���� ĳ���� �̸����� ����
        chatactor_name.text = current.character;

        //�ڷ�ƾ�� �����ִ� ���¶�� �����ݴϴ�.
        if(typing != null) 
            StopCoroutine(typing);

        // ���� ��ȭ �������� ������(��ȭ ����)�� �������� ��ȭ Ÿ������ �����մϴ�.
        typing = StartCoroutine(TypingDialogue(current.content));
    }

    private IEnumerator TypingDialogue(string line)
    {
        istyping = true; // Ÿ���� ���� ������ �˸�

        StringBuilder stringBuilder = new StringBuilder(line.Length);

        message.text = ""; // ���� ����

        // string(���ڿ�)�� ����(char)�� �迭
        foreach (char c in line)
        {
           // message.text += c;
           stringBuilder.Append(c);
            message.text = stringBuilder.ToString();
            yield return new WaitForSeconds(typing_speed);

        }
        istyping = false ;
    }
    
    

    private void DialogueExit()
    {
        panel.SetActive(false); //�г� ����
    }

    // ��� ó��
    private void CompletedtLine()
    {
        if (typing != null)
        {
            StopCoroutine(typing);
        }

        message.text = current.content;
        istyping = false; // ������ �ٲ��ִ� �ڵ� == �÷��� �ڵ�
    }
}
