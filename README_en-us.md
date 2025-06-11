# **MVC-Web: Community Mini Hub**
An interactive website developed using the MVC (Model-View-Controller) architecture, integrated with a database to dynamically manage and present user-generated content.

<div align="center">

| [繁體中文](README.md) | [English](README_en-us.md) | 🎥 [Demo Video](https://www.youtube.com/watch?v=JC-y-y8_nVY) |

</div>

---

## 📌 Website Purpose & Core Concept

This site adopts a member-only model, where users must **register and log in** to access any features.

Inspired by the idea of **open data**, this project aims to build a **semi-public social platform** where users can share parts of their life with others. All content posted by users is publicly viewable by other members, fostering a lightweight and accessible social space.

The platform includes the following functional modules:

- 📄 Personal Introduction
- 🧭 Travel Plans
- 💰 Secondhand Item Wishlist
- 🎬 Movie/TV Show Recommendations
- ⭐ Favorite Celebrities (organized by category)

---

## 🔧 Core Features

### ✅ Full CRUD Functions (Create / Read / Update / Delete)
- All modules **except the Favorite Celebrities section** support the full set of operations:
  - **Create new entries**
  - **Read and search**
  - **Update existing records**
  - **Delete content**

> To improve readability and user experience, all modules include **pagination** to avoid overly long pages. Sorting features are also implemented for better organization.

### ⭐ Favorite Celebrities (Category Filtering)
- Users can **add or remove** their favorite celebrities.
- Celebrities are grouped by **category** (e.g., actors, singers, athletes).
- Visitors can browse by selecting specific categories of interest.

---

## 🧱 Technical Architecture

- Built with the **MVC structure**, separating the application into:
  - **Model**: Data schema and database
  - **View**: Webpage UI and presentation layer
  - **Controller**: Logic and routing for user actions

- A fully integrated **database** ensures that user data is persistently stored and dynamically retrieved.

- All queries, filtering, and pagination logic are handled within the **Controller** for efficiency and scalability.
