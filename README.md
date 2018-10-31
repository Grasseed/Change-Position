# 陣列,位置與順序
    ex: 輸入 紅,黑,白,黃,綠
         輸出 MyArray[0] = 綠 MyArray[0] = 黃 MyArray[0] = 白 MyArray[0] = 黑 MyArray[0] = 紅
         (規定:請使用陣列)
# 關於C#陣列的介紹
* 陣列的宣告
```
型別[] 陣列名稱= new 型別[];
ex: int[] myArray = new int[];
string myArray = new string[5] {"紅","黑","白","黃","綠"};
```    
* 陣列屬性
```
Array.Length 取得陣列資料長度
範例:
int[] num = { 1, 2, 3, 4, 5, 6, 7 };
Console.WriteLine(num.Length);
```
更多資訊可以參考[C# Array陣列](https://adon988.logdown.com/posts/1175641-c-array-teaching-notes-using-visual-studio "按下去發現新世界")
# 作法
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tAry = new string[] { "紅", "黑", "白", "黃", "綠" };
            for (int k = tAry.Length - 1; k >= 0; k--)
            {
                Console.Write("tAry[{0}]={1} ", k, tAry[k]);
            }
            //令k為終止值(減一是為了避免溢位造成程序出錯),k在大於等於零時,反向列出陣列值(k--)
            Console.Read();
        }
    }
}
```
# 注意事項
小草籽保留最終所有權利
