using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c_ch3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-1輸入10個整數，求其最小值
            //int min = int.MaxValue; 
            //Console.WriteLine("輸入 10 個整數：");
            //for (int i = 0; i < 10; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number < min) 
            //    {
            //        min = number; 
            //    }
            //}
            //Console.WriteLine($"輸入的整數中最小值是：{min}");
            //Console.ReadKey();

            //3-1 while
            //int[] numbers = new int[10]; // 儲存 10 個整數
            //int count = 0; // 計數器
            //Console.WriteLine("請輸入 10 個整數：");
            //while (count < 10)
            //{
            //    numbers[count] = Convert.ToInt32(Console.ReadLine());
            //    count++; // 增加計數器
            //}
            //int minValue = numbers[0]; // 假設第一個數是最小值
            //int a = 1; // 從第二個數開始比較
            //while (a < numbers.Length)
            //{
            //    if (numbers[a] < minValue)
            //    {
            //        minValue = numbers[a]; // 更新最小值
            //    }
            //    a++; // 增加索引
            //}
            //Console.WriteLine($"最小值是: {minValue}");


            //3-2輸入N個整數，求其最小值。
            //int min = int.MaxValue;
            //Console.WriteLine("輸入 3 個整數：");
            //for (int i = 0; i < 3; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number < min) { min = number; }
            //}
            //Console.WriteLine($"輸入的整數中最小值是：{min}");
            //Console.ReadKey();

            //3-2 while
            //Console.Write("請輸入要的數量: ");
            //int N = Convert.ToInt32(Console.ReadLine()); // 讀取 N 的值
            //int[] numbers = new int[N]; // 根據 N 的大小宣告整數陣列
            //int count = 0; // 計數器
            //Console.WriteLine($"請輸入 {N} 個整數：");
            //while (count < N)
            //{
            //    numbers[count] = Convert.ToInt32(Console.ReadLine());
            //    count++; // 增加計數器
            //}
            //int minValue = numbers[0]; // 假設第一個數是最小值
            //int a= 1; // 從第二個數開始比較
            //while (a< numbers.Length)
            //{
            //    if (numbers[a] < minValue)
            //    {
            //        minValue = numbers[a]; // 更新最小值
            //    }
            //    a++; // 增加索引
            //}
            //Console.WriteLine($"最小值是: {minValue}");
            //Console.ReadKey();

            //3-3.輸入10個整數，列出其中所有大於12的數字。
            //int[] number = new int[10];
            //Console.WriteLine("請輸入10 個數字: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("大於12的數字有:");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (number[i] > 12)
            //    { Console.WriteLine(number[i]); }
            //}
            //Console.ReadKey();

            //3-3 while
            //int[] numbers = new int[10]; // 儲存 10 個整數
            //Console.WriteLine("請輸入 10 個整數：");
            //int count = 0;
            //while (count < 10)
            //{
            //    numbers[count] = Convert.ToInt32(Console.ReadLine());
            //    count++; // 增加計數器
            //}
            //Console.WriteLine("大於 12 的數字有：");
            //int a = 0;
            //while (a < numbers.Length)
            //{
            //    if (numbers[a] > 12)
            //    {
            //        Console.WriteLine(numbers[a]); // 輸出符合條件的數字
            //    }
            //    a++; // 增加索引
            //}
            //Console.ReadKey();

            //3-4輸入10個整數，列出其中所有大於12的數字的總和。
            //int[] number = new int[10];
            //int sum = 0;
            //Console.WriteLine("請輸入12個整數:");
            //for (int i = 0; i < 10; i++)
            //{ 
            //    number[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("大於12的數字有:");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (number[i] > 12)
            //    {
            //        Console.WriteLine(number[i]);
            //        sum += number[i];
            //    }
            //}
            //Console.WriteLine("大於12的數字總和" + sum);
            //Console.ReadKey();

            //3-4while
            //int[] numbers = new int[10]; 
            //Console.WriteLine("請輸入 10 個整數：");
            //int count = 0;
            //while (count < 10)
            //{
            //    numbers[count] = Convert.ToInt32(Console.ReadLine());
            //    count++; // 增加計數器
            //}
            //int sum = 0; // 儲存大於 12 的數字的總和
            //int index = 0;
            //while (index < numbers.Length)// 計算大於 12 的數字的總和
            //{
            //    if (numbers[index] > 12)
            //    {
            //        sum += numbers[index]; // 將大於 12 的數字加到總和中
            //    }
            //    index++; // 增加索引
            //}
            //Console.WriteLine($"所有大於 12 的數字的總和是: {sum}");
            //Console.ReadKey();

            //3-5輸入N個數字，求其所有奇數中的最大值。
            //int[] number = new int[5];
            //int a = int.MinValue;
            //Console.WriteLine("請輸入5個數字");
            //for (int i = 0; i < 5; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine());
            //    if (number[i] % 2 != 0)
            //    {
            //        if (number[i] > a)
            //        {
            //            a = number[i];
            //        }
            //    }
            //}
            //    if (a == int.MinValue)
            //    {
            //        Console.WriteLine("沒有輸入基數");
            //    }
            //    else
            //    {
            //        Console.WriteLine("最大基數:" + a);
            //    }
            //    Console.ReadKey();

            //3-5while
            //Console.Write("請輸入要的數量: ");
            //int N = Convert.ToInt32(Console.ReadLine()); 
            //int a = int.MinValue; // 假設最大奇數初始為最小整數
            //bool found = false; // 標記是否找到奇數
            //Console.WriteLine($"請輸入 {N} 個數字：");
            //int count = 0; // 計數器
            //while (count < N) // 輸入 N 個數字
            //{
            //    int number = Convert.ToInt32(Console.ReadLine()); // 讀取數字
            //    if (number % 2 != 0)// 檢查是否為奇數
            //    {
            //        found = true; // 標記找到奇數
            //        if (number > a)
            //        {
            //            a = number; // 更新最大奇數
            //        }
            //    }
            //    count++; // 增加計數器
            //}
            //if (found)
            //{
            //    Console.WriteLine($"所有奇數中的最大值是: {a}");
            //}
            //else
            //{
            //    Console.WriteLine("沒有輸入奇數。");
            //}
            //Console.ReadKey();

            //3-6輸入N個數字，求其所有正數之平方的加總。
            //int[] number = new int[5];
            //int sum = 0;
            //Console.WriteLine("輸入五個數字");
            //for (int i = 0; i < 5; i++)
            //{
            //    { number[i] = int.Parse(Console.ReadLine()); }
            //}
            //foreach (int a in number) //a儲整數值in集合
            //{
            //    if (a > 0)// 檢查 a 是否為正數如果 a 是負數，這個條件會返回 false，因此該負數不會被計算到 sum 中
            //    {
            //        sum += a * a;
            //    }
            //}
            //Console.WriteLine("所有正數的加總:" + sum);
            //Console.ReadKey();

            //3-6while
            //Console.Write("請輸入要的數量: ");
            //int N = Convert.ToInt32(Console.ReadLine()); 
            //int sum = 0; // 儲存正數平方的總和
            //Console.WriteLine($"請輸入 {N} 個數字：");
            //int count = 0; // 計數器
            //while (count < N) 
            //{
            //    int number = Convert.ToInt32(Console.ReadLine()); 
            //    if (number > 0)// 檢查是否為正數
            //    {
            //        sum += number * number; // 計算平方並加總
            //    }
            //    count++; // 增加計數器
            //}
            //Console.WriteLine($"所有正數的平方加總是: {sum}");
            //Console.ReadKey();

            //3-7輸入N個數字，其中有些是負數，將這些負數轉換成正數，
            //例如 -7會被轉換成7。
            //int[] number = new int[5];
            //Console.WriteLine("請輸入五個數字");
            //for (int i = 0; i < 5; i++)
            //{
            //    number[i] = int.Parse(Console.ReadLine());
            //    if (number[i] < 0)
            //    {
            //        number[i] = Math.Abs(number[i]); 
            //        // 使用 Math.Abs 將其轉換為正數
            //    }
            //}
            //Console.WriteLine("轉換後的數字:");
            //foreach (int a in number)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadKey();

            //3-7while
            //Console.Write("請輸入要的數量: ");
            //int N = Convert.ToInt32(Console.ReadLine()); 
            //int[] numbers = new int[N]; 
            //Console.WriteLine($"請輸入 {N} 個數字：");
            //int count = 0; // 計數器
            //while (count < N) // 輸入 N 個數字
            //{
            //    numbers[count] = Convert.ToInt32(Console.ReadLine()); 
            //    count++; 
            //}
            //Console.WriteLine("轉換後的數字是：");
            //for (int i = 0; i < numbers.Length; i++) // 將負數轉換為正數並輸出
            //{
            //    if (numbers[i] < 0) // 如果是負數
            //    {
            //        numbers[i] = -numbers[i]; // 轉換成正數
            //    }
            //    Console.WriteLine(numbers[i]); // 輸出結果
            //}
            //Console.ReadKey();

            //補充
            //1.判斷101 - 200之間有多少個質數，並輸出所有質數。
            //int count = 0;
            //Console.WriteLine("101-200之間的的質數如下：");
            //for (int i = 101; i <= 200; i++)
            //{
            //    if (IsPrime(i))// 檢查是否為質數
            //    {
            //        Console.WriteLine(i);// 輸出質數
            //        count++;// 質數計數
            //    }
            //}
            //Console.WriteLine($"共有 {count} 個質數");
            //bool IsPrime(int i)
            //{
            //    if (i < 2) return false;// 小於 2 的數字不是質數
            //    for (int a = 2; a <= Math.Sqrt(i); a++)// 只需要檢查到平方根
            //    {
            //        if (i % a == 0)// 如果能被 i 整除，則不是質數
            //        {
            //            return false;
            //        }
            //    }
            //    return true;// 如果沒有找到因數，則是質數
            //}
            //Console.ReadKey();

            //補充1.while
            int num = 101; // 從 101 開始
            Console.WriteLine("101 到 200 之間的質數有：");
            while (num <= 200)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                }
                num++; // 移到下一個數字
            }
            Console.ReadKey();
        }
            static bool IsPrime(int number)// 判斷是否為質數的函數
        {
            if (number <= 1) return false; // 1 不是質數
            int divisor = 2;

            while (divisor <= Math.Sqrt(number))
            {
                if (number % divisor == 0)
                {return false; } // 如果能被整除，則不是質數
                divisor++;
            }
            return true; // 是質數
        



        //2.輸入一個數，輸出其質因數
        //Console.WriteLine("請輸入一個數：");
        //int i = int.Parse(Console.ReadLine());
        //Console.WriteLine($"質因數為:");
        //while (i % 2 == 0)// 處理 2 的質因數
        //{
        //    Console.WriteLine(2);// 輸出 2
        //    i /= 2;// 除以 2
        //}
        //for (int n = 3; n <= Math.Sqrt(i); n += 2)// 從 3 開始檢查奇數
        //{
        //    while (i % n == 0)//如果能被 n 整除
        //    {
        //        Console.WriteLine(n);// 輸出質因數 n
        //        i /= n;// 除以 n
        //    }
        //}
        //// 如果 i 大於 2，則 i 本身是質數
        //if (i > 2)
        //{ Console.WriteLine(i); }
        //Console.ReadKey();

        //補充2.while
        //Console.Write("輸入一個數: ");
        //int num = int.Parse(Console.ReadLine());
        //Console.Write("質因數有: ");
        //int factor = 2;
        //while (num > 1)
        //{
        //    if (num % factor == 0) // 檢查是否能被當前因數整除
        //    {
        //        Console.Write(factor + " "); // 輸出質因數
        //        num /= factor; // 將數字除以質因數
        //    }
        //    else
        //    {
        //        factor++; // 檢查下一個因數
        //    }
        //}
        //Console.ReadKey();

        //3.求100到300中可以被3與7整除的個數。
        //int count = 0;
        //Console.WriteLine("100 到 300 之間可以被 3 和 7 同時整除的數字有：");
        //for (int i = 100; i <= 300; i++)
        //{
        //    if (i % 3 == 0 && i % 7 == 0)
        //    {
        //        Console.Write(i + " ");
        //        count++;
        //    }
        //}
        //Console.WriteLine($"共 {count}個");
        //Console.ReadKey();

        //補充3.while
        //int count = 0;
        //int num = 100;
        //Console.WriteLine("100 到 300 之間可以被 3 和 7 同時整除的數字有：");
        //while (num <= 300)
        //{
        //    if (num % 3 == 0 && num % 7 == 0)
        //    {
        //        Console.Write(num + " ");
        //        count++;
        //    }
        //    num++;
        //}
        //Console.WriteLine($"共 {count}個");
        //Console.ReadKey();

        //4-1利用while寫一程式求N個數字的最大值。
        //Console.WriteLine("請輸入一個數字範圍: ");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = 0;
        //int max = int.MinValue;
        //Console.WriteLine($"請輸入{a}個數字:");
        //while (b < a)
        //{

        //    int c = Convert.ToInt32(Console.ReadLine());
        //    if (c > max)
        //    {
        //        max = c;
        //    }
        //    b++;
        //}
        //Console.WriteLine($"最大值為:{max}");
        //Console.ReadKey();

        //4-2利用while求一個等差級數數字的和，一共有N個數字，
        //程式應該輸入最小的起始值以及數字間的差。(即從起始值開始，間格差，共N個的總和)
        //起始值：3 差值：2 總數字數N：5 等差級數的總和為: 3 + 5 + 7 + 9 + 11 = 35
        //輸入數據/變數初始化/使用 while 迴圈/輸出結果
        //Console.WriteLine("請輸入最小起始值");
        //int start = int.Parse(Console.ReadLine());
        //Console.WriteLine("請輸入數字間的差");
        //int difference = int.Parse(Console.ReadLine());
        //Console.WriteLine("請輸入總共的數字n");
        //int n = int.Parse(Console.ReadLine());
        //int sum = 0;
        //int a = start;
        //int count = 0;
        //while (count < n)
        //{
        //    sum += a;
        //    a += difference;
        //    count++;
        //}
        //Console.WriteLine($"等級差數的總合為:{sum}");
        //Console.ReadKey();

        //4-3利用while，讀入N個數字，找出所有小於13的數，再求這些數字的和。
        //Console.WriteLine("請輸入一個數字:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine($"請輸入{n}個數字:");
        //int count = 0;
        //int sum = 0;
        //while (count < n)
        //{
        //    int number = int.Parse(Console.ReadLine());
        //    if (number < 13)
        //    {
        //        sum += number;
        //    }
        //    count++;
        //}
        //Console.WriteLine($"小於13數字的和:{sum}");
        //Console.ReadKey();

        //4-4利用while，讀入N個數字，
        //找第一個大於7而小於10的數字就停止，且印出這個數字。
        //Console.WriteLine("請輸入要讀取的數字個數 N：");
        //int n = int.Parse(Console.ReadLine()); // 輸入要讀取的數字個數
        //int count = 0; // 用於計數已輸入的數字
        //bool found = false; // 用於標記是否找到符合條件的數字
        //Console.WriteLine($"請輸入 {n} 個數字要找大於7而小於10的數字：");
        //while (count < n)
        //{
        //    int number = int.Parse(Console.ReadLine());
        //    if (number > 7 && number < 10)
        //    {
        //        Console.WriteLine($"找到的數字: {number}");
        //        found = true;
        //        break;
        //    }
        //    count++;
        //}
        //if (!found)
        //{
        //    Console.WriteLine("未找到符合條件的數字");
        //}
        //Console.ReadKey();

        //4-5利用while，讀入a1,a2,…,a5和b1,b2,…,
        //b5。找到第一個ai > bi，即停止，並列印出ai及bi。
        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine($"請輸入a{i}:");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"請輸入b{i}:");
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    if (a > b)
        //    {
        //        Console.WriteLine($"a{i}:{a};b{i}:{b}");
        //        break;
        //    }
        //}
        //Console.ReadKey();

        //1.Eric覺得麥蒂勞39元漢堡實太好吃，他決定晚餐要把口袋裡所有錢
        //通通拿來吃39元漢堡。假設他每5分鐘就能吃一個漢堡，
        //請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
        //Console.WriteLine("請輸入時間範圍:");
        //int time = Convert.ToInt32(Console.ReadLine());
        //int count = 0;
        //while (time >= 5)
        //{
        //    count++;
        //    time -= 5;
        //    Console.WriteLine($"吃了第{count}個漢堡");
        //}
        //Console.ReadKey();

        //2.小明貸款買房花560萬，每個月可還4萬，每還12個月，
        //因為年終獎金可以多還一萬，請問需要幾個月還清。
        //>> 每年，小明會還款4萬元×12個月 + 1萬元 = 49萬元
        // >> 560 / 49 = 11.4年 = 136.8月
        //int total = 560;
        //int money = 4;
        //int more = 1;
        //int months = 0;
        //while (total > 0)
        //{
        //    total -= money;
        //    months++;
        //    if (months % 12 == 0)
        //    { total -= more; }
        //}
        //Console.WriteLine($"要花{months}個月分還清");
        //Console.ReadKey();

        //3.系統隨機產生一個數字，讓使用者數入數字，
        //直到猜中才離開程式！猜錯時，要提示是比較大還是比較小。
        //Random random = new Random();
        //int get = random.Next(1, 101);// 隨機生成
        //int guess = 0;// 儲存用戶的猜測
        //Console.WriteLine("猜數字1-100");
        //while (guess != get)
        //{
        //    Console.WriteLine("請猜一個數字");
        //    guess = int.Parse(Console.ReadLine());// 讀取用戶的猜測
        //    if (guess < get)
        //    {
        //        Console.WriteLine("在大一點");
        //    }
        //    else if (guess > get)
        //    {
        //        Console.WriteLine("在小一點");
        //    }
        //    else
        //    {
        //        Console.WriteLine("猜對了");
        //    }
        //}
        //Console.ReadKey();
    }
    }
}
    

















        
        
    

