using static System.Runtime.InteropServices.JavaScript.JSType;

public class Heranca
{
    public static void MainHeranca(string[] args)
    {
        var a = new A();

        // Não pode ser acessada, por se uma propriedade privada que pode ser acessada somente dentro da classe
        // a1._value = "25";

        var ab = new A.B();
        
        // A classe b pode acessar propriedade value porque herda a classe A e foi criada dentro da classe A
        Console.WriteLine(ab.GetValue());

        var c  = new C();
        // A classe c não pode acessar a propriedade value, pois esse método foi definido na classe b criada dentro da classe A
        // c.GetValue();

        var d = new D();

        // A classe E herda da classe D, como esse método é público, a classe E pode usar como se fosse uma implementação da classe E
        var e = new E();
        e.Method();

    }
}

public class A
{
    private int _value = 10;

    public class B : A
    {
        public int GetValue()
        {
            return _value;
        }
    }
}

public class C : A
{
    //    public int GetValue()
    //    {
    //        return _value;
    //    }
}

public class D
{
    public void Method()
    {

    }
}

public class E : D
{

}