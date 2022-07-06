// 1.以下代码有什么问题？
{
    byte a = 11, b = 22, c;
    c = ( byte ) ( a + b );
}

// 2.填空，以统计arr数组偶数个数.
{
    int[ ] arr = { 1 , 4 , 3 , 5 , 5 , 4 };
    int num = arr.Aggregate( 0 , ( count , element ) => count += 1 - element % 2 );
}

// 3.指出下述代码错误，并改正.
{
    int @return = 1;
}

// 4.以下代码输出值是多少？
{
    Console.WriteLine( sizeof( char ) );//不知道就试一下
}

// 5.以下F方法中s变量的值有变化吗？为什么？
{
    F( );

    void F( )
    {
        string s = "Hello";
        G( s );
        Console.WriteLine( s );
    }

    void G( string s )
    {
        s = "World";
    }
}

// 6.以下Sample结构的声明有哪些错误？
{
///*class*/interface Base { }
//
//struct Sub : Base
//{
//    public int a;
//    private Single b;
//    /*protected*/ int c;
//    double d;
//
//    public Sub( int a )
//    {
//        this.a = a;
//        b = 4.0f;
//        c = 0;
//        d= .0;
//    }
//}
}

// 7.填写内插字符串，保留4位小数打印浮点数
{
    const double PI = 3.14;
    Console.WriteLine( $"{PI:f4}" );
}

// 8.指出下述代码中的错误
{
    Base[ ] bases = new Sub[ 10 ];
    List</*Base*/Sub> list = new List<Sub>( 10 );
}

// 9.以下数组初始化有什么错误?请修改
{
    int[ , , ] a = new int[ 4 , 4 , 4 ];
    int[ ][ ][ ] b = new int[ 4 ][ /*4*/ ][ ];
    int n = 3;
    int[ ] c = new int[ /*n*/ ] { 1 , 2 , 3 };
    int[ ] d = new int[ n ];
}
// 10.下面代码中有何错误?
{
    var o = new { Name = "Andy" , Age = 40 , Pro = "Doctor" };
    //o.Pro = "Doctor";
}

// 11.简述下列代码中的装箱、拆箱过程
{
    int? a = new int?( );
    object o = a;
    var b = ( int? ) o;
    //var c = ( int ) o;
}

// 12.下列代码中var关键字使用有何错误?
{
    var a = 1;
    var b = 2;
    Console.WriteLine( $"{a + b}" );

    //var obj = null;

    var arr = new int[ ] { 2 , 3 , 4 };

    //var func = e => e + 1;

    //public delegate var Foo( var o );
}

// 13.下列数组的Length返回值分别是多少?
{
    int[ , ] a = new int[ 2 , 8 ];
    int[ ][ ] b = new int[ 8 ][ ];
}

// 14.将下列arr数组拼接，汇报编译时错误吗？
{
    int?[ ] arr=new int?[ 4 ] {1,2,3,null };
    string str = string.Join( "," , arr );
}

// 15.下列程序输出值多少？
{
    var arr1 = "#,".Split( "," );
    Console.WriteLine( $"arr1.Length={arr1.Length}" );

    var arr2 = "####".Substring( 0 ).Split( "," );
    Console.WriteLine( $"arr2.Length={arr2.Length},{arr2[0]}" );

    var arr3 = " ".Substring( 0 , 0 ).Split( "," );
    Console.WriteLine( $"arr3.Length={arr3.Length}" );

    //var arr4 = " ".Substring( 1 , 1 ).Split( "," );
    //Console.WriteLine( $"arr4.Length={arr4.Length}" );

    //var arr5 = " ".Substring( 2 ).Split( "," );
    //Console.WriteLine( $"arr4.Length={arr5.Length}" );

    //var arr6 = " ".Substring( 0, -1 ).Split( "," );
    //Console.WriteLine( $"arr4.Length={arr6.Length}" );
}