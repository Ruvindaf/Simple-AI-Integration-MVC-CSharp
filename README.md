# Simple-AI-Integration-MVC
A minimal ASP.NET Core MVC web app demonstrating how to integrate Azure OpenAI (via Foundry) using a simple AI chat interface with AJAX and C#.

This project demonstrates how to integrate **Azure OpenAI (via Azure Foundry)** into a simple **ASP.NET Core MVC web application**. It allows users to type a message and receive a response from an AI assistant.

---

## ✨ Features

- ✅ Ask AI questions from a web interface
- ✅ Azure OpenAI integration via Foundry
- ✅ Clean MVC structure using Controllers & Views
- ✅ AJAX-based interaction using jQuery
- ✅ Example settings for easy configuration

---

## 🧰 Technologies Used

- ASP.NET Core MVC (.NET 6 or later)
- Azure OpenAI (gpt-4o deployment)
- Azure SDK (`Azure.AI.OpenAI`)
- jQuery / AJAX
- C#

---

## 🖼️ Demo Screenshot

<img width="1039" height="603" alt="Screenshot 2025-07-11 215255" src="https://github.com/user-attachments/assets/93b5a55e-9417-4994-b582-2027601d45bb" />

---

Sure! Here's the **tidied-up version** of your `🚀 Getting Started` section, now including:

* Clean instructions for cloning.
* A reference to the Foundry setup file (`AI_Foundry.md` or `AzureFoundrySetup.md`).
* A recommended learning module from Microsoft Learn.

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/Simple-AI-Integration-MVC.git
cd Simple-AI-Integration-MVC
```

### 2. Configure Your Azure OpenAI Settings

Update the `appsettings.json` file with your Azure AI Foundry credentials:

```json
"AzureOpenAISettings": {
  "Endpoint": "https://your-foundry-endpoint/",
  "ApiKey": "your-api-key-here",
  "DeploymentName": "gpt-4o"
}
```

> 🔐 **Important**: Never commit your API keys. Use [User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets) or [Azure Key Vault](https://learn.microsoft.com/en-us/azure/key-vault/general/overview) in production environments.

### 3. Deploy the Model in Azure AI Foundry

Follow the step-by-step guide in [`AI_Foundry.md`](AI_Foundry.md) to deploy a model (like `gpt-4o`) and retrieve your API credentials.

---

## 📘 Recommended Learning

Want to learn more about Azure AI and OpenAI integration?

Check out this official **Microsoft Learn** collection:
🔗 [Build intelligent apps with Azure OpenAI](https://learn.microsoft.com/en-us/collections/50wkaqtq50egz3?source=docs&tab=credentials-tab)

This curated set of modules covers:

* Azure OpenAI model usage
* Prompt engineering
* Real-world integrations
* Responsible AI practices

