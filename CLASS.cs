class Venda 
{
    
    public int qtdLanche;
    public int qtdRefri;
    public double totalConta;
    public double dinheiroRecebido;
    public double troco;

    public void calculaTotalPagar()
    {
        this.totalConta = this.qtdLanche * 6 + this.qtdRefri * 2;
    }
    
    public void calculaTroco()
    {
        this.troco = this.dinheiroRecebido - this.totalConta;
    }
}
