<h1 align="center">👤 User Management API</h1>

<p align="center">
  <img src="https://img.shields.io/badge/status-concluído-brightgreen" alt="Status"/>
  <img src="https://img.shields.io/badge/backend-.NET%208-blue" alt="Backend"/>
  <img src="https://img.shields.io/badge/architecture-Clean%20Architecture-orange" alt="Architecture"/>
  <img src="https://img.shields.io/badge/pattern-CQRS-lightgrey" alt="Pattern"/>
  <img src="https://img.shields.io/badge/docs-Swagger-yellow" alt="Docs"/>
</p>


<p> Uma <b>API em C#</b> para <b>gerenciamento de usuários</b>, construída com <b>Clean Architecture</b> e <b>CQRS</b>. <br> Oferece operações de <b>CRUD</b> com <b>Swagger</b> para documentação interativa.<br> Projeto inicial dos meus estudos, já aplicando <b>boas práticas</b> e foco em <b>organização</b> e <b>escalabilidade</b>. </p>

<hr>

<h2>👨‍💻 Tecnologias Utilizadas</h2>
<ul>
  <li>C# / .NET 8</li>
  <li>Clean Architecture</li>
  <li>CQRS (Command Query Responsibility Segregation)</li>
  <li>MediatR</li>
  <li>AutoMapper</li>
  <li>FluentValidation</li>
  <li>Entity Framework Core</li>
  <li>Swagger/OpenAPI</li>
</ul>

<hr>

<h2>⚙️ Instalação e Configuração</h2>

<h3>📋 Pré-requisitos</h3>
<ul>
  <li>.NET SDK 8+</li>
  <li>Visual Studio ou VS Code</li>
  <li>Extensões do Visual Studio para suporte ao EF Core (o banco é gerado automaticamente)</li>
</ul>

<h3>📦 Como executar o projeto</h3>
<ol>
  <li>Clone o repositório:
    <pre><code>git clone https://github.com/seuusuario/user-management-api.git</code></pre>
  </li>
  <li>Abra a solução no <b>Visual Studio</b>.</li>
  <li>Restaure os pacotes NuGet.</li>
  <li>Execute o projeto <code>CleanArchitecture.WebAPI</code>.</li>
</ol>

<p>📌 A documentação estará disponível em:<br>
👉 <code>http://localhost:5207/swagger</code></p>

<hr>

<h2>🔗 Endpoints Principais</h2>

<table>
  <thead>
    <tr>
      <th>Método</th>
      <th>Rota</th>
      <th>Descrição</th>
    </tr>
  </thead>
  <tbody>
    <tr><td>GET</td><td>/api/Users</td><td>Lista todos os usuários</td></tr>
    <tr><td>POST</td><td>/api/Users</td><td>Cria um novo usuário</td></tr>
    <tr><td>PUT</td><td>/api/Users/{id}</td><td>Atualiza um usuário existente</td></tr>
    <tr><td>DELETE</td><td>/api/Users/{id}</td><td>Remove um usuário</td></tr>
  </tbody>
</table>

<hr>

<h2>🏗️ Estrutura do Projeto</h2>
<p>O projeto segue os princípios da <b>Clean Architecture</b>, dividido em camadas independentes:</p>
<ul>
  <li><b>Domain</b> → Entidades e regras de negócio (sem dependências externas)</li>
  <li><b>Application</b> → Casos de uso, validações e lógica de aplicação (depende de Domain)</li>
  <li><b>Persistence</b> → Implementação de acesso a dados (depende de Application)</li>
  <li><b>WebAPI</b> → Camada de apresentação, endpoints e configuração (depende de Application e Persistence)</li>
  <li><b>UnitTest</b> → Camada de testes (planejada com xUnit, ainda não implementada)</li>
</ul>

<hr>

<h2>📌 Observações</h2>
<p>
Este projeto marca meus <b>primeiros passos em C#</b>, inspirado em uma playlist no YouTube.<br>
A camada de testes ainda não foi implementada, mas já aplica <b>boas práticas</b> e serve como base para evoluir.<br><br>
👉 Playlist seguida: 
<a href="https://youtube.com/playlist?list=PLJ4k1IC8GhW3GICba2dLmiTZrVPw0SthC&si=EFgDLWtyYQfleQLE" target="_blank">
Clean Architecture
</a>
</p>


<h2>👨‍💻 Autor</h2>
<ul>
  <li><a href="https://github.com/fcolucasvieira">Lucas Vieira</a> – Desenvolvedor principal</li>
</ul>
