
<h1 align="center">
	<img src="https://seeklogo.com/images/C/c-sharp-c-logo-02F17714BA-seeklogo.com.png"  alt="Logo"  width="240"><br><br>
    CRUD C# Desenvolvido em .Net 4.8, Utilizando Padrão de Modelagem DDD
</h1>

<div align="center">
    <a href="https://www.linkedin.com/in/carlos-r-de-oliveira-filho-62a996200/">
        <img src="https://img.shields.io/static/v1?label=Author&message=Carlos&color=162285&style=for-the-badge&logo=LinkedIn" alt="Author: Carlos">
    </a>
  <br>
    <a href="#">
		<img  src="https://img.shields.io/static/v1?label=Language&message=CSharp&color=purple&style=for-the-badge&logo=CSharp"  alt="Language: CSharp">
	</a>
	<a href="#">
		<img src="https://img.shields.io/static/v1?label=Framework&message=4.8&color=bf53b1&style=for-the-badge&logo=DotNet"  alt="Language: Dot Net 6">
	</a>
    </p>
</div>

## Table of Contents

<p align="center">
 <a href="#about">About</a> •
 <a href="#features">Features</a> •
 <a href="#revised-concepts">Revised Concepts</a> • 
 <a href="#installation">Installation</a> • 
 <a href="#technologies">Technologies</a> • 
 <a href="#bonus">Bonus</a>
</p>

## 📌About

<div>
    <p align="center">
    <em>
        Desenvolvimento de uma aplicação CRUD simples com foco nos padrões de modelagem de software DDD utilizando como linguagem para 
        desenvolvimento o C# (CSharp) e .Net 4.8, Sql Server para base de dados.
    </em>
    </p>
</div>

## 🚀Features

- Criação, Edição, Deleção de Categorias;
- Criação, Edição, Deleção de Produtos;
- Vínculo entre Produtos e Categorias.

## 👓Revised Concepts


- CRUD Básico

## 📕Installation

**Você precisa ter instalado na máquina**
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/)
- [DotNet Framework 4.8](https://dotnet.microsoft.com/pt-br/download/dotnet-framework/net48)
- [SQLServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

**Recomendações**
-   É recomendado que você tenha na sua máquina o Visual Studio 2022 instalado
-   Para base de dados utilize o SQL Server da versão 18 para cima

**Passo-a-Passo**
1. Clone este repositório
2. Direcione o projeto de inicialização para o UI
3. Inicialize a aplicação console
  ---
### 1. Clone este repositório
```
git clone https://github.com/DevCarlosOli/MadeFyCRUD.git
```
### 2. Direcione o projeto de inicialização para o UI

Para executar o projeto, com o Visual Studio aberto é necessário ir na pasta UI, clicar com botão direito no projeto MadeFyCRUD.UI, clicar na opção Definir Como Projeto
de Inicialização.

### 3. Inicialize a aplicação console

Basta esperar e um terminal irá abrir o projeto local.

## 🌐Technologies

**Pacotes Utilizados**

- System.Data.SqlClient

## 🎇Bonus
**Script para criação das tabelas da base de dados**

-- Script para criação da tabela Categoria <br/>
CREATE TABLE Categoria ( <br/>
    ID INT IDENTITY(1,1) PRIMARY KEY, <br/> 
    Nome NVARCHAR(100) NOT NULL, <br/> 
    DataCadastro DATETIME NOT NULL, <br/> 
    DataAtualizacao DATETIME NOT NULL <br/>
);

-- Script para criação da tabela Produto <br/>
CREATE TABLE Produto ( <br/>
    ID INT IDENTITY(1,1) PRIMARY KEY, <br/> 
    Nome NVARCHAR(100) NOT NULL, <br/> 
    Descricao NVARCHAR(200) NOT NULL, <br/> 
    Preco DECIMAL(18, 2) NOT NULL, <br/> 
    Quantidade INT NOT NULL, <br/> 
    CategoriaID INT NOT NULL, <br/> 
    DataCadastro DATETIME NOT NULL, <br/> 
    DataAtualizacao DATETIME NOT NULL, <br/> 
    FOREIGN KEY (CategoriaID) REFERENCES Categoria(ID) <br/>
);
