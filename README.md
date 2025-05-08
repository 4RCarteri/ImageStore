# ImageStore

## 📖 Introduction
**ImageStore** is an application developed in **C#** using **Windows Forms** technology. The main objective of this project is to provide a graphical interface for interacting with functionalities related to image storage and manipulation.

## ✨ Features
- **Image Selection**:
  - Allows users to select images for viewing or manipulation.
  
- **Database Insertion**:
  - Functionality to save image information directly into a database.

- **Record Deletion**:
  - Allows users to delete images or their associated records from the database.

- **Save Locally**:
  - Option to save images locally on the device.

## 🚀 How to Use
### Prerequisites
1. Install **MySQLConnector** on your system.
2. Add the **MySQL.Data** dependency to the project in Visual Studio.
3. Configure the MySQL database with the following schema:

```sql
CREATE TABLE `images` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `image` mediumblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

### Execution Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/4RCarteri/ImageStore.git
   ```
2. Open the project in **Visual Studio**.
4. Compile and run the project.

## 🛠 Project Structure
- **`Program.cs`**:
  - Main entry point of the application, where initial configurations are defined.
- **`Form1.cs`**:
  - Main graphical interface class, which implements the functionalities described above.

## 🤝 Contributions
Contributions are welcome! Follow these steps:
1. Fork this repository.
2. Create a branch with your feature: `git checkout -b my-feature`.
3. Commit your changes: `git commit -m 'Add new feature'`.
4. Push your branch: `git push origin my-feature`.
5. Open a Pull Request.

## 📄 License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.