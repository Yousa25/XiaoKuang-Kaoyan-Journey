namespace OOP
{

    public abstract class 函数
    {
        public string 定义域;
        public abstract void 对应法则(int x);


        public abstract void 奇偶性();



    }

    public class  绝对值函数:函数
    {

        public override void 对应法则(int x)
        {

            if(x<=0)
                Console.WriteLine(-x);
            else if (x>=0)
                Console.WriteLine(x);
        }

        public override void 奇偶性()
        {
            Console.WriteLine("偶函数");
        }
       
    }

    public class  sgnx :函数
    {
        public override void 对应法则(int x)
        {
            if(x<0)
                Console.WriteLine(-1);
            else if (x==0)
                Console.WriteLine(0);
            else if (x>0)
                Console.WriteLine(1);
        }

        public override void 奇偶性()
        {
            Console.WriteLine("偶函数");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            函数 f1 = new 绝对值函数();
            f1.对应法则(-5); // 输出 5
            函数 f2 = new sgnx();
            f2.对应法则(-5); // 输出 -1
        }
    }
}
