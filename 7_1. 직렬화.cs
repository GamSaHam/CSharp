///<summary>
/// Serializable 예제
/// [Serializable] 어트리뷰트 설정
/// Soap XML 단위로 저장 DLL임포트 시켜야 한다.
/// </summary>

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

[Serializable]
class SerialExample
{
    string _str;
    int _value;

    public SerialExample(string str,int value)
    {
        _str = str;
        _value = value;
    }

    public string Str
    {
        get { return _str; }
    }

    public int Value
    {
        get { return _value; }
    }
};

class Program
{

    static void Main()
    {

        SerialExample serial_example1 = new SerialExample("kim",21);
        SerialExample serial_example2 = new SerialExample("joo",24);

        Stream stream1 = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite);
        Stream stream2 = new FileStream("soap.txt", FileMode.Create, FileAccess.ReadWrite);

        IFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream1, serial_example1);

        formatter = new SoapFormatter();
        formatter.Serialize(stream2, serial_example2);

        stream1.Close();
        stream2.Close();


        Stream stream_read1 = new FileStream("test.txt", FileMode.Open, FileAccess.ReadWrite);
        Stream stream_read2 = new FileStream("soap.txt", FileMode.Open, FileAccess.ReadWrite);

        IFormatter formatter1 = new BinaryFormatter();
        SerialExample ex1 = (SerialExample)formatter1.Deserialize(stream_read1);

        Console.WriteLine("str:{0} value:{1}", ex1.Str, ex1.Value);
        

        IFormatter formatter2 = new SoapFormatter();
        SerialExample ex2 = (SerialExample)formatter2.Deserialize(stream_read2);
        Console.WriteLine("str:{0} value:{1}", ex2.Str, ex2.Value);

        stream_read1.Close();
        stream_read2.Close();
    }
};

