# Stock-Management
A complete Stock Management System built with C#, Entity Framework 6, and DevExpress.
It manages articles, suppliers, invoices, and stock movements with automatic quantity and price calculations powered by SQL Server triggers.
The system also includes a user licensing and permission module to control access for each user.
⚙️ Technologies Used

C# (.NET Framework)

Entity Framework 6 (Database-First with EDMX)

SQL Server

DevExpress WinForms Components

SQL Triggers for real-time updates

📋 Features

🧾 Article Management – create, update, and classify articles by category.

🏷️ Category Management – organize items by category for easier tracking.

📦 Stock Entries (In) – register incoming goods with supplier details.

🚚 Stock Exits (Out) – manage outgoing stock and delivery notes.

🧮 Automatic Calculations – triggers handle quantity and price updates automatically.

💼 Supplier Management – maintain full supplier records and business activities.

🧍‍♂️ Service Management – track which internal services receive materials.

💬 Quotations & Delivery Notes – link supplier quotes and internal orders to stock transactions.

🔐 User Permissions – access and functionality depend on user roles.

📊 Statistics & Reporting – visualize stock flow and supplier activity.

💾 Backup & Settings – configurable rules and database backup options.

🧠 Database Logic

The system relies on SQL triggers for automatic consistency:

calcul_in_stock → updates total quantities and prices after stock entries.

calcul_out_stock → decreases stock when items are consumed or sold.

init_setting → loads price-calculation parameters (average, FIFO, etc.) from the settings table.

These ensure real-time synchronization between the database and the application.

🧩 Main Tables
Table	Description
les_articles	Items with name, quantity, category, and price.
catgr	Article categories.
stocks_in	Incoming stock transactions.
stock_out	Outgoing stock transactions.
devis	Supplier invoices or quotations.
les_bon	Delivery notes.
fornisseur	Supplier records (name, contact, bank info).
forni_activite / type_activite_fornisseur	Supplier business activities.
les_services	Internal departments.
users	Authentication and permissions.
settings	Configuration and calculation rules.

🖥️ User Interface

Built with DevExpress WinForms, providing:

Modern grid views and filter controls.

Real-time visual updates after each transaction.

Data export to Excel or PDF.

Permission-based menu visibility per user.


<img width="1382" height="712" alt="1" src="https://github.com/user-attachments/assets/2726f44e-56fc-49fc-9f63-b08fac2a1404" />
<img width="1331" height="655" alt="2" src="https://github.com/user-attachments/assets/87162fa5-a90f-4b03-a820-0e0999592dc4" />
<img width="1106" height="510" alt="3" src="https://github.com/user-attachments/assets/3fb92dc1-57a6-459a-8e64-6e5cf1ebee4a" />
<img width="716" height="396" alt="4" src="https://github.com/user-attachments/assets/8ca100d2-c1aa-42da-8fd9-477b592bf85f" />
<img width="1383" height="417" alt="5" src="https://github.com/user-attachments/assets/a59188d1-a27b-401c-b46a-c3d8c263410b" />
<img width="815" height="695" alt="6" src="https://github.com/user-attachments/assets/367106d8-e576-4714-871a-1b55535b2190" />


