# 🔧 Azure AI Foundry Setup Guide

This guide walks you through how to use **Azure AI Foundry** to deploy an OpenAI model (like `gpt-4o`) and integrate it into your ASP.NET Core MVC application.

---

## 🧠 What is Azure AI Foundry?

[Azure AI Foundry](https://ai.azure.com/) is a centralized platform provided by Microsoft for:
- Accessing state-of-the-art AI models like `GPT`, `Sora`, `Grok`, and `Phi`.
- Deploying them securely and at scale.
- Managing API keys, rate limits, endpoints, and quotas from a unified interface.

---

## 🚀 Step-by-Step Setup

### 1. **Create a Foundry Project**

- Navigate to [Azure AI Studio](https://ai.azure.com/)
- Create a project (e.g., `ai_agent_test_project`)

📷 *Screenshot: Model Catalog*

<img width="1907" height="889" alt="Screenshot 2025-07-11 222732" src="https://github.com/user-attachments/assets/f4818ffa-d62d-49cb-bd7d-6c9f48eaaf44" />


---

### 2. **Choose and Deploy a Model**

- From the **Model Catalog**, select your desired model (e.g., `gpt-4o`)
- Click **Deploy**, give your deployment a name (`gpt-4o`)
- Wait for provisioning to complete

📷 *Screenshot: Deployment Info*

<img width="589" height="531" alt="Screenshot 2025-07-11 222553" src="https://github.com/user-attachments/assets/8029fb50-c00d-4e9a-8dfc-0a3bacc7fbc2" />


> ✅ Model Status: `Succeeded`  
> 📅 Created: `June 10, 2025`  
> 🔢 Rate Limit: 10,000 TPM | 60 RPM

---

### 3. **Get API Key and Endpoint**

Once the model is deployed:

- Go to **Project Overview > Endpoints and Keys**
- Copy your **API Key** and **Foundry endpoint**

📷 *Screenshot: API Key and Endpoint*

<img width="1085" height="556" alt="Screenshot 2025-07-11 222144" src="https://github.com/user-attachments/assets/20db7db3-5713-42f5-bad7-a15043cb8d41" />


---

### 4. **Use in Your ASP.NET Core App**

In `appsettings.json`, update:

```json
"AzureOpenAISettings": {
  "Endpoint": "https://ai-agent-test-project-resource.services.ai.azure.com/",
  "ApiKey": "your-api-key-here",
  "DeploymentName": "gpt-4o"
}
