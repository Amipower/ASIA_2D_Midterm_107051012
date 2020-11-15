using UnityEngine;

public class player: MonoBehaviour
{
    //欄位:儲存資料
    //語法:
    //修飾詞 類型 名稱 (指定 值);
    //None空值:沒東西-程式錯誤
    public GameObject final;

    //碰撞偵測條件
    //1.兩個物件必須要有碰撞器Collider2D
    //2.兩個至少必須要有一個剛體Rigidbody2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門");
    }
    
}