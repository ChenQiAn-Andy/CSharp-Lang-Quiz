## C#语法测试题 ##
记录了<B>.NET 6.0</B> 下遇到的各种错误、小常识，答案在 *Program.cs* 文件中。

1.以下代码有什么问题？

    byte a = 11, b = 22, c;
    c = a + b;

2.填空，以统计a数组偶数个数.

    int[ ] arr = { 1 , 4 , 3 , 5 , 5 , 4 };
    int num = arr.Aggregate( ____ );

3.指出下述代码错误，并改正.

	int return = 1;

4.以下代码输出值是多少？

	Console.WriteLine( sizeof( char ) );

5.以下 *Foo( )* 方法中 *s* 变量的值有变化吗？为什么？

    Foo( );

    void Foo( )
    {
        string s = "Hello";
        Goo( s );
        Console.WriteLine( s );
    }

    void Goo( string s )
    {
        s = "World";
    }  

6.以下 *Sample* 结构的声明有哪些错误？

    class Base { }

    struct Sub : Base
    {
        public int a;
        private Single b;
        protected int c;
        double d;

        public Sub( int a )
        {
            this.a = a;
            b = 4.0;
        }

		~Sub(){ }
    }

7.填写内插字符串，保留4位小数打印浮点数

    const double PI = 3.14;
    Console.WriteLine( $"{PI:f4}" );

8.指出下述代码中的错误

    Base[ ] bases = new Sub[ 10 ];
    List<Base> list = new List<Sub>( 10 );

9.以下数组初始化有什么错误?请修改

    int[ , , ] a = new int[ 4 , 4 ];
    int[ ][ ][ ] b = new int[ 4 ][ 4 ][ ];
    int n = 3;
    int[ ] c = new int[ n ] { 1 , 2 , 3 };
    int[ ] d = new int[ n ];

10.下面代码中有何错误?

	var o = new { Name="Andy",Age= 40};
	o.Pro = "Doctor";

11.简述下列代码中的装箱、拆箱过程

    int? a = new int?( );
    object o = a;
    var b = ( int? ) o;
    var c = ( int ) o;

12.下列代码中 *var* 关键字使用有何错误?

	var a=1,b=2; 
	var obj=null;
	var arr={2,3,4};
	const var src=(8,11,2,7);
	var func=e=>e+1;
	public delegate var Foo(var o);

13.下列数组的 *Length* 返回值分别是多少?

    int[ , ] a = new int[ 2 , 8 ];
    int[ ][ ] b = new int[ 8 ][ ];

14.将下列arr数组拼接，汇报编译时错误吗？

	int?[ ] arr=new int?[ 4 ] {1,2,3,null };
    string str = string.Join( "," , arr );

15.下列程序输出值多少？

	var arr1 = "#,".Split( "," );
    Console.WriteLine( $"arr1.Length={arr1.Length}" );

    var arr2 = "####".Substring( 0 ).Split( "," );
    Console.WriteLine( $"arr2.Length={arr2.Length},{arr2[0]}" );

    var arr3 = " ".Substring( 0 , 0 ).Split( "," );
    Console.WriteLine( $"arr3.Length={arr3.Length}" );

    var arr4 = " ".Substring( 1 , 1 ).Split( "," );
    Console.WriteLine( $"arr4.Length={arr4.Length}" );

    var arr5 = " ".Substring( 2 ).Split( "," );
    Console.WriteLine( $"arr4.Length={arr5.Length}" );

    var arr6 = " ".Substring( 0, -1 ).Split( "," );
    Console.WriteLine( $"arr4.Length={arr6.Length}" );

16.下面枚举定义有什么问题？

	public enum Week
	{
	    Mon = 01,
	    Tue = 02,
	    Wed = 03,
	    THI = 04,
	    FR = 05,
	    SAT = 06,
	    SUN = 07
	}

17.下面函数定义有什么问题？

	void Foo( params string[ ] props=null,int id=0) 
    {
    }

    void Goo(string name = null , Base b = new Sub( ) )
    {
    }

18.下面函数调用中的命名实参有什么问题？

	void Dump( int x , int y , int z )
    {
        Console.WriteLine( $"{x},{y},{z}" );
    }

    Dump( y: 2 , 1 , z: 3 );
    Dump( 1 , x: 2 , y: 3 );

19.下述程序打印结果是？

    void Dump( int x , int y , int z )
    {
        Console.WriteLine( $"{x},{y},{z}" );
    }

    Func<int , int> Log = value =>
    {
        Console.WriteLine( value );
        return value;
    };

    Dump( z: Log( 3 ) , y: Log( 2 ) , x: Log( 1 ) );

20.填空，以统计arr数组偶数个数.

    int[ ] arr= new int[ ] { 1 , 4 , 3 , 5 , 5 , 4 };
    int num = arr.Where( ______ ).Count();
    int num2 = arr.Count( ______ );

21.简述一下访问权限修饰符有和特点.

	protected internal : ____________
	private protected  : ____________