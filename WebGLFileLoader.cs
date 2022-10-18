using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;

public class IFC_Import_Controller : MonoBehaviour
{
    public Text cur_status_txt;

    private void Start()
    {
        //이 시스템은 싱글톤이므로, 지워질 필요가 없음.
        DontDestroyOnLoad(gameObject);
    }

    public void FileLoad()
    {
        InitFileLoader();
    }

    [DllImport("__Internal")]
    private static extern void InitFileLoader();
}
