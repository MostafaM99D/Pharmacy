# **Pharmacy Management System**

A comprehensive desktop application built with **C# and Windows Forms** for efficient pharmacy operations. This system streamlines **inventory, sales, purchases, and user management** to ensure smooth daily workflows.

---

## **Overview**

This project is a robust Pharmacy Management System designed to automate and manage the core operations of a pharmacy. It provides a user-friendly interface for various roles, ensuring data integrity, security, and efficient workflow management. From managing user access to handling medicine inventory and sales, the system aims to cover all essential aspects of administration.

---

## **Key Features**

The system is developed in a modular fashion, covering essential functionalities:

* ### **User Management (Completed)**

  * **Secure Login:** Multi-role authentication system.

  * **Administrator Dashboard:** Provides a comprehensive overview with dynamic statistics (e.g., number of users by role, customers, suppliers).

  * **People Management:** Full CRUD (Create, Read, Update, Delete) operations for basic person data (name, address, contact info).

  * **Roles Management:** Full CRUD operations to define and manage user roles (Manager, Pharmacist, Salesperson).

  * **User Management:** Full CRUD operations for user accounts, including advanced features like password change and reset functionalities.

  * **Categories Management:** Full CRUD operations for organizing medicines into categories (e.g., Painkillers, Antibiotics).

---

* ### **Product & Inventory Management (Upcoming)**

  * Comprehensive view of medicines and inventory details (quantities, expiry dates, purchase/sale prices).

  * Adding and modifying medicine definitions.

  * Managing and tracking individual inventory batches.

---

* ### **Supplier & Purchase Management (Upcoming)**

  * Management of supplier data.

  * Recording purchase operations and their detailed contents.

---

* ### **Customer & Sales Management (Upcoming)**

  * Management of customer data.

  * Point of Sale (POS) screen for efficient sales transactions.

  * Reviewing sales and order records.

---

* ### **Reporting (Upcoming)**

  * Various analytical reports for sales, purchases, inventory, and more.

---

## **Technologies Used**

* **Programming Language:** C#

* **User Interface (UI):** Windows Forms

* **Database:** SQL Server

* **Data Access Layer (DAL):** ADO.NET

* **Business Logic Layer (BLL):** C# Classes

---

## **Architecture**

The system is built with a **Layered Architecture** to ensure clear separation of concerns, modularity, and maintainability:

* **User Interface Layer (UI):** The Windows Forms application that users interact with.

* **Business Logic Layer (BLL):** Contains all business rules, validations, and orchestrates data flow between UI and DAL.

* **Data Access Layer (DAL):** Handles all direct communication with the database, executing SQL commands.

* **Database Layer:** SQL Server database storing all application data.
