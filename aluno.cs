class Aluno{
    // Estado
    public int rm= default!;
    public string nome = default!;
    public int? idade= default!;
    public bool ativo = true;
    //Comportamento
}
    void Exibir (); {
        if (!this.ativo) return;
        
        string mensagem = $" o aluno(a) {this.nome} posuui o rm {this.rm} e idade {this.idade}.";
        Console.WriteLine(mensagem);

    }
 void TrancarMatricula (){
        this.ativo = false;
    }
