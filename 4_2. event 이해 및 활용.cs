// Event 이해 및 활용
// 델리게이트랑 같고 event 키워드로 변경 된다.

using System;

class MyEventArgs : EventArgs
{
    private int ClickCount;     // 클릭 횟수 지정

    public MyEventArgs()
    {
        this.ClickCount = 0;
    }
    public MyEventArgs(int data)
    {
        this.ClickCount = data;
    }
    public int GetClickCount()
    {
        return this.ClickCount;
    }

}

// 이벤트 핸들러 역할을 수행할 메서드 정의(인자 확인)
class ExampleClass      // OnClick 메서드 정의
{
    public void OnClick(object sender, MyEventArgs args)
    {
        Console.WriteLine("{0} 개체이서 {1}번 이벤트가 발생했습니다.",
            sender.ToString(), args.GetClickCount());
    }

}


class EventExaml
{
    // 델리게이트 선언
    // sender : 이벤트를 발생시킨 개체 인스턴스
    // args   : 이벤트의 내용
    public delegate void ClickEvent(object sender, MyEventArgs args);
    // 이벤트 선언 
    // [접근한정자] event [델리게이트] [ 이벤트 이름]
    private event ClickEvent ExamEvent;


    public EventExaml()
    {
        // 이벤트 등록 
        ExampleClass obj = new ExampleClass();
        ExamEvent += new ClickEvent(obj.OnClick);
    }

    public void ClickMethod(int clickcount)
    {
        if (ExamEvent != null)
        {
            // 이벤트 호출 
            MyEventArgs args = new MyEventArgs(10);
            ExamEvent(this, args);
        }
    }
    static void Main(string[] args)
    {
        EventExaml obj = new EventExaml();
        obj.ClickMethod(10);
    }
}
