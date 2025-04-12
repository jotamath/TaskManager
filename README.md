# TaskManager.API – Sistema de Gestão de Tarefas com Agendamento Inteligente

<div align="center">
	<img width="50" src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/c%23.png" alt="C#" title="C#"/>
	<img width="50" src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/_net_core.png" alt=".NET Core" title=".NET Core"/>
	<img width="50" src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/swagger.png" alt="Swagger" title="Swagger"/>
</div>

## 📚 Descrição

API desenvolvida em **ASP.NET Core** com arquitetura em camadas, responsável por gerenciamento de tarefas, categorização, agendamento automático estilo *time blocking*, e integração futura com Google Calendar. Ideal para produtividade pessoal ou equipes enxutas.

---

## 🧠 Funcionalidades

- ✅ CRUD de Tarefas
- ✅ CRUD de Categorias
- ✅ Agendamento inteligente de tarefas
- ✅ Algoritmo de *Time Blocking*
- ✅ [Em breve] Integração com Google Calendar

---

## 🛠️ Tecnologias

- ASP.NET Core Web API
- Entity Framework Core (SQLite)
- Clean Architecture (Domain, Application, Infrastructure, API)
- AutoMapper (opcional)
- Swagger (OpenAPI)

---

## 📂 Estrutura do Projeto

```
TaskManager/
│
├── TaskManager.API               # Camada de apresentação (controllers)
├── TaskManager.Application       # Camada de aplicação (DTOs, Services)
├── TaskManager.Domain            # Entidades e interfaces (núcleo da lógica)
├── TaskManager.Infrastructure    # Implementações de repositórios e EF Core
└── README.md
```

---

## 🧪 Como rodar

```bash
# 1. Clone este repositório
git clone https://github.com/jotamath/taskmanager-api.git

# 2. Navegue até a pasta do projeto
cd taskmanager-api

# 3. Restaurar pacotes
dotnet restore

# 4. Criar banco de dados local (SQLite)
dotnet ef database update -s TaskManager.API

# 5. Rodar a aplicação
dotnet run --project TaskManager.API
```

---

## 🌐 Acesso à API (Swagger)

Depois de rodar, acesse no navegador:

```
http://localhost:5262/swagger
```

---

## 📀 Exemplos de Endpoints

### ➕ Criar tarefa

`POST /api/tasks`

```json
{
  "title": "Estudar C#",
  "description": "Aprofundar em ASP.NET Core",
  "priority": 3,
  "categoryId": "GUID",
  "duration": "01:00:00"
}
```

### ⏱️ Agendar automaticamente

`POST /api/tasks/schedule`

```json
{
  "startDate": "2025-04-10",
  "endDate": "2025-04-15",
  "startTime": "08:00:00",
  "endTime": "18:00:00"
}
```

---

## 🧠 Lógica de Agendamento

O algoritmo ordena as tarefas pendentes por prioridade, verifica os horários livres no intervalo informado e agenda as tarefas conforme disponibilidade – em blocos de tempo de 15 minutos.

---

## 📈 Futuras melhorias

- Integração com Google Calendar
- Notificações via e-mail
- Interface Web com React ou Blazor
- Autenticação com JWT

---

## 👨‍💻 Autor

| Nome         | GitHub                                   | LinkedIn                                                     |
| ------------ | ---------------------------------------- | ------------------------------------------------------------ |
| João Matheus | [@jotamath](https://github.com/jotamath) | [linkedin.com/in/jotamath](https://linkedin.com/in/jotamath) |



