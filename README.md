# valida-senha

Criado uma classe *sealed* **PasswordValidate** contendo métodos privados para para validar a força da senha e um método *public* para validar a senha. A classe não pode ser herdada para que não se tenha acesso a validação de senha a não ser pela própria classe.

Criado uma *interface* **IPasswordValidateService** com um método para validação de senha utilizando a classe PasswordValidate de senha. 

O *Controller* **ValidaSenhaController** recebe a interface por injeção de dependência.

executar com Visual Studio ou VSCode

executar *dotnet run --launch-profile ValidaSenhaApi | start chrome http://localhost:5000/swagger* na pasta src\ValidaSenhaApi

