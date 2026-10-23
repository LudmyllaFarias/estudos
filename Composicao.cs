public class Produto
{
    public string Nome { get; set; } = string.Empty;
    public double Preco { get; set; }

    private int Estoque { get; set; }

    public double ConsultaEstoque()
    {
        return Estoque;
    }

    public int AdicionarEstoque(int estoque)
    {
        return Estoque += estoque;
    }

}

public class Carrinho
{
    public List<Produto> Produtos { get; set; } = [];

    public int Quantidade { get; set; }

    public void AdicionarProduto(Produto produto)
    {
        // Consigo utilizar um método da classe Produto sem precisar de herança
        var estoque = produto.ConsultaEstoque();

        if (estoque > 0)
        {
            Produtos.Add(new Produto()
            {
                Nome = produto.Nome,
                Preco = produto.Preco,
            });
        }
    }
}

public class Composicao
{
    public static void MainComposicao(string[] args)
    {
        /*
         * Quando uma classe herda de uma classe base, qualquer alteração na classe base pode quebrar a classe que deriva da classe base.
         * A composição é diferente de herança, ao invéz de herdar comportamentos, uma classe contém objetos que fornecem esse comportamento.
         * Quando eu tenho repetição de propriedades e comportamentos como uma pessoa juridica e uma pessoa física a melhor opção para evitar a duplicidade
         * é utilizar herança. Mas se eu tenho uma classe produto e uma classe carrinho, carrinho não tem nenhuma duplicidade com produto mas, ele precisa de
         * algumas propriedades e comportamentos como o método consultarEstoque
         * 
         */

        /*
         * Depedendo da situação não usamos herança. Ela viola alguns princípios como encapsulamento, já que a classe derivada pode ter acesso
         * a propriedade e comportamento da classe base. Alterar uma classe pai pode quebrar método e comportamentos usado nas classes derivadas. 
         * Podemos usar composição quando um objeto faz parte ou possui o outro, por exemplo: Se eu tenho uma classe livro e uma classe autor,
         * autor faz parte de livro.
         * A composição tem menos dependência de implementações. Cada classe é focada em uma tarefa. Bom encapsulamento visto que os detalhes instânciados 
         * internamente não são vistos.
         */


        var produto = new Produto();
        produto.Nome = "Teclado";
        produto.Preco = 49.99;
        produto.AdicionarEstoque(5);

        var produto2 = new Produto();
        produto2.Nome = "Mouse sem fio";
        produto2.Preco = 39.40;

        var carrinho = new Carrinho();
        carrinho.Quantidade = 1;
        carrinho.AdicionarProduto(produto);
        carrinho.AdicionarProduto(produto2);

        foreach(var item in carrinho.Produtos)
        {
            Console.WriteLine(item.Nome);
        }
    }
}
