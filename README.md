# 📚 SECON Library Management System – AI Chatbot

## 📖 Overview

The SECON Library Management System (SLMS) is a web-based application developed using ASP.NET Core. It helps manage library resources, employees, departments, book issues, returns, and digital content.

This project includes an AI-powered chatbot that provides library information, analytics, reports, and general knowledge assistance.

---

## 🚀 Features

- 🤖 AI Chat Assistant
- 📊 Dashboard Summary
- 👨 Employee Details
- 📚 Book Details
- 📈 Library Analytics
- 📄 Library Report Generation
- 💡 AI Recommendations
- 📖 Digital Library Information
- ⚡ AJAX-based Real-time Chat
- ⌛ Typing Animation
- 🕒 Message Timestamps
- 🔍 Search Support

---

## 🛠 Technologies Used

- ASP.NET Core MVC
- ASP.NET Core Web API
- C#
- Entity Framework Core
- PostgreSQL
- Bootstrap 5
- jQuery
- AJAX
- Google Gemini API

---

## 🏗 Architecture

MVC UI

↓

Web API

↓

Service Layer

↓

Repository Pattern

↓

PostgreSQL Database

↓

Google Gemini API (General AI Questions)

---

## 🤖 AI Workflow

1. User enters a question.
2. AIService checks predefined library queries.
3. If it is a library question, data is retrieved from the database.
4. If it is a general question, it is forwarded to Google Gemini.
5. The response is displayed in the chat window using AJAX.

---

## 📸 Screenshots

(Add screenshots here)

- Dashboard
- AI Chat
- Employee Details
- Book Details
- Reports

---

## 👨‍💻 My Contributions

- Developed AI Chat Module
- Designed Chat UI
- Integrated Google Gemini API
- Implemented Dashboard Analytics
- Implemented Employee Details
- Implemented Book Details
- Implemented Library Report Generation
- AJAX Communication
- Typing Animation
- Repository Integration

---

## ▶️ How to Run

1. Clone the repository.
2. Configure PostgreSQL connection string.
3. Add your Gemini API Key in configuration.
4. Run the Web API.
5. Run the MVC application.

---

## 📌 Future Enhancements

- Voice Assistant
- Multi-language Support
- Smart Book Recommendations
- Borrow History Analysis
- PDF Report Generation
