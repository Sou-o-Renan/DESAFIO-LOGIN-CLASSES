//DESAFIO LOGIN E USUÁRIOS EM CLASSES

// Desafio de Login para Estudantes

// Você foi designado para criar um sistema simples de login para estudantes. O sistema deve consistir em duas classes: uma para armazenar os dados dos usuários e outra para realizar a verificação do login.

// Classe Student:

// Esta classe deve armazenar as informações dos alunos, incluindo nome de usuário e senha.
// Deve ter métodos para definir e obter o nome de usuário e a senha.
// Classe LoginManager:

// Esta classe deve ser responsável por verificar se as credenciais de login fornecidas estão corretas.
// Deve ter um método para verificar se um nome de usuário e senha correspondem aos registros armazenados na classe Student.
// O método deve retornar verdadeiro se as credenciais estiverem corretas e falso caso contrário.

using DesafioLogin;


Console.WriteLine("BEM VINDO AO SISTEMA DE LOGIN E SENHA DO RENAN");
Console.WriteLine("PRIMEIRO, VAMOS CRIAR OS 3 USUÁRIOS");
Console.WriteLine("_________________________________");




var aluno1 = new Student();
Console.WriteLine("Digite o nome de usuário do aluno 1: ");
aluno1.CriarUsuário(Console.ReadLine());
Console.WriteLine("Digite a senha do aluno 1: ");
aluno1.CriarSenha(Console.ReadLine());

//_________________________________________________________________//

var aluno2 = new Student();
Console.WriteLine("Digite o nome de usuário do aluno 2: ");
aluno2.CriarUsuário(Console.ReadLine());
Console.WriteLine("Digite a senha do aluno 2: ");
aluno2.CriarSenha(Console.ReadLine());

//_________________________________________________________________//

var aluno3 = new Student();
Console.WriteLine("Digite o nome de usuário do aluno 3: ");
aluno3.CriarUsuário(Console.ReadLine());
Console.WriteLine("Digite a senha do aluno 3: ");
aluno3.CriarSenha(Console.ReadLine());;

//_________________________________________________________________//

var aluno4 = new Student();
Console.WriteLine("Digite o nome de usuário do aluno 4: ");
aluno4.CriarUsuário(Console.ReadLine());
Console.WriteLine("Digite a senha do aluno 4: ");
aluno4.CriarSenha(Console.ReadLine());

//_________________________________________________________________//

Console.WriteLine("Dados dos alunos:");

Console.WriteLine($"Aluno 1 - Nome de usuário: {aluno1.user}, Senha: {aluno1.Senha}");
Console.WriteLine($"Aluno 2 - Nome de usuário: {aluno2.user}, Senha: {aluno2.Senha}");
Console.WriteLine($"Aluno 3 - Nome de usuário: {aluno3.user}, Senha: {aluno3.Senha}");