## C#语法测试题 ##
记录了**.NET 6.0** 下遇到的各种错误、小常识，答案在 *Program.cs* 文件中。

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
	var func=e=>e+1;
	public delegate var Foo(var o);

13.下列数组的 *Length* 返回值分别是多少?

    int[ , ] a = new int[ 2 , 8 ];
    int[ ][ ] b = new int[ 8 ][ ];
