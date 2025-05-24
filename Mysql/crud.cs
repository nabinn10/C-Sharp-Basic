using System;
using MySql.Data.MySqlClient;
using MySql.Data;

class Program
{
    static string connStr = "Server=localhost;Database=dotnet;Uid=root;Pwd=;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- STUDENT MENU ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. Remove Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": AddStudent(); break;
                case "2": ShowStudents(); break;
                case "3": EditStudent(); break;
                case "4": RemoveStudent(); break;
                case "5": return;
                default: Console.WriteLine("Invalid option!"); break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        using (var con = new MySqlConnection(connStr))
        {
            var cmd = new MySqlCommand("INSERT INTO student (name) VALUES (@name)", con);
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Student added." : "Error inserting student.");
        }
    }

    static void ShowStudents()
    {
        using (var con = new MySqlConnection(connStr))
        {
            var cmd = new MySqlCommand("SELECT * FROM student", con);
            con.Open();
            var reader = cmd.ExecuteReader();

            Console.WriteLine("\nID\tName");
            Console.WriteLine("---------------");
            while (reader.Read())
            {
                Console.WriteLine(reader["id"] + "\t" + reader["name"]);
            }
            reader.Close();
        }
    }

    static void EditStudent()
    {
        Console.Write("Enter student ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter new name: ");
        string name = Console.ReadLine();

        using (var con = new MySqlConnection(connStr))
        {
            var cmd = new MySqlCommand("UPDATE student SET name = @name WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Student updated." : "Student not found.");
        }
    }

    static void RemoveStudent()
    {
        Console.Write("Enter student ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        using (var con = new MySqlConnection(connStr))
        {
            var cmd = new MySqlCommand("DELETE FROM student WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Student deleted." : "Student not found.");
        }
    }
}
