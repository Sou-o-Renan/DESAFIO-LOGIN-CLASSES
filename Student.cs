namespace DesafioLogin;
    public class Student{ //classe Student
    // Propriedades para armazenar nome de usuário e senha
    public string user { get; set; } // precisa ter usuario
    public string Senha { get; set; } // precisa ter senha

    // Método para definir o nome de usuário
    public void CriarUsuário (string usuario) // método CriarUsuário precisar ter a string usuario
    {
        user = usuario; 
    }

    // Método para definir a senha
    public void CriarSenha (string  senha) // método CriarSenha precisa ter senha do usuario
    {
        Senha = senha;
    }

    // Método para obter o nome de usuário
    public string NomeUsuário() // método para verificar usuario criado
    {
        return user;
    }

    // Método para obter a senha
    public string SenhaUsuario() // método para verificar senha
    {
        return Senha;
    }
}


