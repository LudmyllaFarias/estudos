/*  
 *  A interface é como um contrato. A classe que herdar a interface precisa implementar os métodos(contratos) declarados por ela. 
 *  Porém a implementação depende de cada classe que herda, pois podem ser diferentes para cada um. Exemplo: Se essa interface fosse um
 *  contrato de locação que obriga a cortar a grama 2 vezes ao mês, não importa quem vai cortar ou os métodos e equipamentos que
 *  vão usar mas, a grama precisa ser cortada.
*/
public interface IVeiculo
{
    public void Ligar();
}
