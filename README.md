API de Exemplo: Aplicativo de Lista de Tarefas (To-do) em C#

Esta API exemplifica um aplicativo "To-do" construído em C# utilizando uma arquitetura robusta que incorpora conceitos avançados de desenvolvimento, incluindo domínios ricos, autenticação no Firebase, separação por domínio e princípios SOLID. Foi projetada para fornecer uma base sólida para sistemas escaláveis e de alta qualidade.

Recursos Principais:

Domínios Ricos:
Utiliza uma abordagem de modelagem de domínio rico, onde as entidades como Tarefa (Task) refletem de forma precisa o negócio em questão, encapsulando lógica de negócios complexa e comportamentos relacionados.

Autenticação no Firebase:
Implementa autenticação de usuário utilizando o Firebase Authentication, garantindo uma autenticação segura e robusta.

Separação por Domínio:
Aplica uma estrutura de código bem definida, organizando os diferentes componentes da aplicação por domínios específicos, como Tarefa (Task), Usuário (User), promovendo uma melhor manutenibilidade e escalabilidade.

Princípios SOLID:
Segue os princípios SOLID (Single Responsibility Principle, Open/Closed Principle, Liskov Substitution Principle, Interface Segregation Principle e Dependency Inversion Principle), promovendo um código limpo, modular e de fácil extensibilidade.

Funcionalidades:
Autenticação de Usuário: Permite que os usuários se autentiquem de forma segura utilizando o Firebase Authentication.

Gerenciamento de Tarefas: Fornece operações CRUD (Criar, Ler, Atualizar, Excluir) para as tarefas, incluindo marcação de tarefas como concluídas, definindo prioridades, e atribuindo a usuários específicos.

Validação de Dados: Implementa validações robustas para garantir a integridade dos dados e a consistência das operações.

Tecnologias Utilizadas:

Linguagem de Programação: C#

Firebase: Para autenticação de usuário e gerenciamento de dados em tempo real.

ASP.NET Core: Para construção da API RESTful.

Entity Framework Core: Para mapeamento objeto-relacional e acesso a dados.

Flunt: Utilizado para validação de dados e implementação de domínios ricos.
