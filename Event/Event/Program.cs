using System.ComponentModel.DataAnnotations;

class Program
{
    public delegate void Func(string str);
  
    public class MyClass
    {
        public MyClass(string str)
        {
            this.str = str;
        }

        public string str { get; set; }
        public void Space(string str)
        {
            string spaced=string.Join("_",str.ToCharArray());
            Console.WriteLine(spaced);
        }
        public void Reverse(string str)
        {
            char[] reverseArr=str.ToCharArray();
            Array.Reverse(reverseArr);
            string reversed=new string(reverseArr);
            Console.WriteLine(reversed);
        }
    }
    public class Run
    {
        public void runFunc(Func func,string str)
        {
            func(str);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string");
        var str=Console.ReadLine();
        MyClass myClass = new MyClass(str);
        Func funcDell = new Func(myClass.Space);
        funcDell += myClass.Reverse;

        Run run=new Run();
        run.runFunc(funcDell,str);
    }
}