namespace DesafioLogin;
    public class Student{  

    public string user { get; set; } // precisa ter usuario
    public string Senha { get; set; } // precisa ter senha

   
    public void CriarUsuário (string usuario) // método CriarUsuário precisar ter a string usuario
    {
        user = usuario; 
    }

 
    public void CriarSenha (string  senha) // método CriarSenha precisa ter senha do usuario
    {
        Senha = senha;
    }

   
    public string NomeUsuário() // método para verificar usuario criado
    {
        return user;
    }

    public string SenhaUsuario() // método para verificar senha
    {
        return Senha;
    }
}


