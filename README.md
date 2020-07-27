# Foto evento Dal & Rô
### Em planejamento...

##### Sobre o projeto

Um sistema feito em Windows Forms para organizar e gerenciar a empresa de fotografia.
- Cadastrando clientes
- Exibindo lucros
- Enviar e-mail
- Agendar reuniões
- Agendar dias em cartórios
- Agendar eventos
- Agendar entregas
Entre outras funcionalidades.

##### Bibliotecas e tecnologias utilizadas:
- C#
- Windows Forms
- SQL Server
- API correios `Link` https://viacep.com.br

##### Inciar o projeto:
- Você pode iniciar o porjeto em:
`\DrFotografia\DrFotografia\bin\Debug\DrFotografia.exe`
- Necessário configurar banco de dados.
- Criar um usuário para fazer o login.
`UPDATE TB_CLIENTE SET nome="admin",senha="admin",email="email@admin.com.br"`


### Obs:
- O projeto não foi concluído, pois foi sugerido novas tecnologias

![](https://i.imgur.com/SMaPE7t.jpg)

![](https://i.imgur.com/1422N4A.jpg)

![](https://i.imgur.com/2bzIF3R.jpg)

![](https://i.imgur.com/uPeFFHP.jpg)

### DDL [SQL SERVER]

    CREATE DATABASE DalRo
    GO
    CREATE TABLE TB_USUARIO
    (
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] VARCHAR(20) NOT NULL,
    [senha] VARCHAR(20) NOT NULL,
    [email] VARCHAR(50) NOT NULL,
    [logado] bit NULL
    )
    GO
    INSERT INTO TB_USUARIO (nome,senha) VALUES ('admin','admin')
    GO
    INSERT INTO TB_USUARIO (nome,senha) VALUES ('keven','123')
    GO
    CREATE TABLE TB_CLIENTE
    (
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] VARCHAR(50) NOT NULL,
    [email] VARCHAR(50) NULL,
    [telefone1] VARCHAR(20) NOT NULL,
    [telefone2] VARCHAR(20) NULL,
    [telefone3] VARCHAR(20) NULL,
    [descricao] VARCHAR(MAX) NULL,
    )
    GO
    CREATE TABLE TB_EVENTO
    (
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [idCliente] INT NULL,
    [valortotal] VARCHAR(50) NOT NULL,
    [valorpago] VARCHAR(50) NULL,
    [tipo] VARCHAR(20) NOT NULL,
    [data] VARCHAR(20) NULL,
    [hora] VARCHAR(20) NULL,
    [local] VARCHAR(MAX) NULL,
    [descricao] VARCHAR(MAX) NULL
    )
    GO
    CREATE TABLE TB_LUCRO
    (
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [lucrodia] VARCHAR(50) NOT NULL,
    [lucromes] VARCHAR(50) NULL,
    [lucroano] VARCHAR(20) NOT NULL,
    [lucrocortorio] VARCHAR(20) NULL,
    [lucroeventos] VARCHAR(20) NULL,
    )
    GO
    ALTER TABLE TB_EVENTO ADD FOREIGN KEY (idCliente) REFERENCES TB_CLIENTE(id);
