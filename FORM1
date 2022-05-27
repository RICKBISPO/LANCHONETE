Venda lanchonete = new Venda();
private void button1_Click(object sender, EventArgs e)
{
    lanchonete.qtdLanche = int.Parse(txtLanche.Text);
    lanchonete.qtdRefri = int.Parse(txtRefri.Text);

    lanchonete.calcularTotalPagar();

    txtTotalConta.Text = Convert.ToString(lanchonete.TotalConta);
}

private void button2_Click(object sender, EventArgs e)
{
    lanchonete.dinheiroRecebido = Convert.ToDouble(tctDinheiro.Text);

    lanchonete.calculaTroco();

    txtTroco.Text = Convert.ToString(lanchonete.troco);
}

private button3_Click(object sender, EventArgs e) 
{
    this.Close();
}

private void button4_Click(object sender, EventArgs e)
{
    txtLanche.Text = "";
    txtRefri.Text = "";
    txtDinheiro.Text = "";
    txtTotalConta.Text = "";
    txtTroco.Text = "";

}
