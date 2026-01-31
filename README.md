<h1 align="center">User Management API</h1>

<h2>📖 Sobre o projeto</h2>
<p>
Este é um projeto de <strong>estudo inicial em C#</strong>, onde desenvolvi uma API para gerenciamento de usuários aplicando os princípios de <strong>Clean Architecture</strong> e <strong>CQRS</strong>.<br>
A ideia foi aprender boas práticas desde o começo: separar responsabilidades, manter o código escalável e já incluir ferramentas modernas como <strong>Swagger</strong> para documentação interativa.
</p>

<p>Com esta API você pode:</p>
<ul>
  <li>👤 Criar usuários</li>
  <li>📋 Listar todos os usuários</li>
  <li>✏️ Atualizar informações</li>
  <li>❌ Remover usuários</li>
</ul>

<p>Tudo isso de forma organizada e preparada para crescer junto com novos aprendizados.</p>

<hr>

<h2>🛠️ Tecnologias utilizadas</h2>
<ul>
  <li>C# / .NET</li>
  <li>Clean Architecture</li>
  <li>CQRS (Command Query Responsibility Segregation)</li>
  <li>MediatR</li>
  <li>AutoMapper</li>
  <li>FluentValidation</li>
  <li>Swagger (OpenAPI)</li>
  <li>Entity Framework Core (banco gerado automaticamente via extensões do Visual Studio)</li>
</ul>

<hr>

<h2>🚀 Como executar</h2>
<ol>
  <li>Clone este repositório:
    <pre><code>git clone https://github.com/seuusuario/user-management-api.git</code></pre>
  </li>
  <li>Abra a solução no <strong>Visual Studio</strong>.</li>
  <li>Restaure os pacotes NuGet.</li>
  <li>Execute o projeto <code>CleanArchitecture.WebAPI</code>.</li>
</ol>

<p>📌 A documentação estará disponível em:<br>
👉 <code>http://localhost:5207/swagger</code></p>

<p><em>💡 O banco de dados é criado automaticamente, sem necessidade de instalação manual.</em></p>

<hr>

<h2>🔗 Endpoints principais</h2>
<ul>
  <li><strong>GET</strong> /api/Users → Lista todos os usuários</li>
  <li><strong>POST</strong> /api/Users → Cria um novo usuário</li>
  <li><strong>PUT</strong> /api/Users/{id} → Atualiza um usuário existente</li>
  <li><strong>DELETE</strong> /api/Users/{id} → Remove um usuário</li>
</ul>

<hr>

<h2>🏗️ Estrutura do projeto</h2>
<p>O projeto segue os princípios da <strong>Clean Architecture</strong>, dividido em camadas independentes:</p>
<ul>
  <li><strong>Domain</strong> → Entidades e regras de negócio (sem dependências externas)</li>
  <li><strong>Application</strong> → Casos de uso, validações e lógica de aplicação (depende de Domain)</li>
  <li><strong>Persistence</strong> → Implementação de acesso a dados (depende de Application)</li>
  <li><strong>WebAPI</strong> → Camada de apresentação, endpoints e configuração (depende de Application e Persistence)</li>
  <li><strong>UnitTest</strong> → Camada de testes (planejada com xUnit, ainda não implementada)</li>
</ul>

<hr>

<h2>📌 Observações</h2>
<p>
Este projeto foi desenvolvido como parte dos meus <strong>primeiros passos em C#</strong>.<br>
A camada de testes ainda não foi implementada, pois o conteúdo seguido (via YouTube) não abordava essa parte.<br>
Mesmo assim, já é um projeto que reflete boas práticas e serve como base para evoluir em estudos futuros.
</p>
