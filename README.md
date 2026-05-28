# Projeto Lanchonete Novo Milênio

Um sistema web completo de lanchonete desenvolvido com Angular no Front-End e ASP.NET Core Web API no Back-End. O projeto possui autenticação com JWT, sistema de carrinho, cardápio dinâmico, rotas protegidas e interface responsiva utilizando Bootstrap.

---

## 🚀 Funcionalidades

* 🔐 **Autenticação JWT**

  * Login e registro de usuários
  * Proteção de rotas com Guards
  * Interceptor para envio automático do token

* 🍔 **Cardápio Dinâmico**

  * Separação entre bebidas e lanches
  * Produtos carregados dinamicamente da API
  * Utilização de `*ngFor`

* 🛒 **Carrinho**

  * Adicionar produtos ao carrinho
  * Carrinho vinculado ao usuário autenticado
  * Cálculo automático do valor total

* 👨‍💼 **Área Administrativa**

  * Controle de acesso por autenticação
  * Cadastro de produtos

* 🎨 **Interface Responsiva**

  * Bootstrap 5
  * Navbar com dropdown
  * Layout moderno e responsivo

---

## 🛠️ Tecnologias Utilizadas

### Front-End

* **Angular 19**
* **TypeScript**
* **Bootstrap 5**
* **Bootstrap Icons**
* **HTML5/CSS3**

### Back-End

* **ASP.NET Core Web API**
* **Entity Framework Core**
* **MySQL**
* **JWT Authentication**
* **C#**

---

## 🧪 Como Executar

# 🔧 Back-End (.NET)

1. Abra o projeto Back-End no Visual Studio

2. Abra o Console do Gerenciador de Pacotes

if necessario {
3. Execute a migration:

```bash
Add-Migration NomeDaMigration
```
}

4. Atualize o banco:

```bash
Update-Database
```

5. Execute a aplicação:

```bash
Ctrl + F5
```

6. A API ficará disponível em:

```bash
https://localhost:7073
```

---

# 🖥️ Front-End (Angular)

1. Clone o projeto:

```bash
git clone URL_DO_REPOSITORIO
```

2. Abra o projeto no VS Code

3. Entre na pasta do projeto:

```bash
cd nome-da-pasta
```

4. Instale as dependências:

```bash
npm i
```

5. Execute o Angular:

```bash
npx ng serve
```

6. Acesse:

```bash
http://localhost:4200
```

---

## 🔑 Funcionalidades de Segurança

* JWT Authentication
* Guards de proteção de rotas
* Interceptors HTTP
* Controle de autenticação
* Rotas públicas e privadas

---

## 📁 Estrutura de Pastas

```bash
📦 LanchoneteFront
├── src
│   ├── app
│   │   ├── core
│   │   │   ├── guards
│   │   │   ├── interceptors
│   │   │   ├── services
│   │   │
│   │   ├── pages
│   │   │   ├── login
│   │   │   ├── register
│   │   │   ├── bebidas
│   │   │   ├── lanches
│   │   │   ├── carrinho
│   │   │   ├── admin
│   │   │
│   │   ├── shared
│   │
│   ├── assets

📦 LanchoneteBackEnd
├── Controllers
├── Models
├── Data
├── Migrations
├── Services
```

---

## 🏁 Melhorias Futuras

* [ ] Finalização de pedidos
* [ ] Integração com pagamento
* [ ] Upload de imagens dos produtos
* [ ] Sistema de pedidos em tempo real
* [ ] Criptografia de senha com BCrypt
* [ ] Dashboard administrativo
* [ ] Responsividade mobile avançada

---

## 👨‍💻 Desenvolvido por

**Guilherme Santos**
