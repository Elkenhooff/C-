using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WoodLand
{
    public class Banco
    {
        public static void Saves()
        {
            string servidor = "localhost"; // Seu servidor MySQL local
            string porta = "3306";         // Porta do seu servidor MySQL
            string usuario = "root";      // Usuário do banco de dados
            string senha = "";           // Senha do banco de dados
            string nomeBanco = "woodland"; // Nome do banco de dados que você deseja conectar

            string connectionString = $"server={servidor};port={porta};user={usuario};password={senha};database={nomeBanco};";
            MySqlConnection conexao = new MySqlConnection(connectionString);

            if (v.save == true)
            {
                Console.Write("");
            }
            else
            {
                try
                {
                    // Abre a conexão
                    conexao.Open();
                    // Verifica se a conexão foi bem-sucedida
                    if (conexao.State == System.Data.ConnectionState.Open)
                    {
                        int i = -1;
                        
                        while (i != 1)
                        {
                            Console.WriteLine("┌────────────────────────┐\r\n│        WoodLand        │\r\n│                        │\r\n│1 - Login               │\r\n│                        │\r\n│2 - Criar Usuário       │\r\n│                        │\r\n└────────────────────────┘");
                            var key = Console.ReadKey().Key;

                            switch (key)
                            {
                                case ConsoleKey.D1:
                                    i = 1;
                                    break;

                                case ConsoleKey.D2:
                                    while (true)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("");
                                        Console.WriteLine(" Usuario:\r\n┌──────────────────────────────┐\r\n│                              │\r\n└──────────────────────────────┘");
                                        Console.SetCursorPosition(1, 3);
                                        object criarJogo = Console.ReadLine();
                                        Console.SetCursorPosition(0, 6);
                                        Console.WriteLine(" Senha:\r\n┌──────────────────────────────┐\r\n│                              │\r\n└──────────────────────────────┘");
                                        Console.SetCursorPosition(1, 8);
                                        object criarsenhaJogo = Console.ReadLine();
                                        Console.SetCursorPosition(0, 11);

                                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                                        {
                                            connection.Open();

                                            string query = "SELECT count(*) FROM saves WHERE usuario = @usuario";
                                            MySqlCommand cmd = new MySqlCommand(query, connection);
                                            cmd.Parameters.AddWithValue("@usuario", criarJogo);

                                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                                            if (count > 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Usuário já existe.");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                CriarSave(criarJogo, criarsenhaJogo);
                                                break;
                                            }
                                        }
                                    }
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível estabelecer a conexão.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }
                finally
                {
                    while (true)
                    {
                    conexao.Close();
                    Console.Clear();
                    Console.WriteLine("");

                    Console.WriteLine(" Usuario:\r\n┌──────────────────────────────┐\r\n│                              │\r\n└──────────────────────────────┘");
                    Console.SetCursorPosition(1, 3);
                    object usuarioJogo = Console.ReadLine();
                    Console.SetCursorPosition(0, 6);
                    Console.WriteLine(" Senha:\r\n┌──────────────────────────────┐\r\n│                              │\r\n└──────────────────────────────┘");
                    Console.SetCursorPosition(1, 8);
                    object senhaJogo = Console.ReadLine();
                    Console.SetCursorPosition(0, 11);


                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open(); 
                        string query = "SELECT * FROM saves WHERE usuario = @usuario AND senha = @senha";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@usuario", usuarioJogo);
                        cmd.Parameters.AddWithValue("@senha", senhaJogo);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    v.id = reader.GetString("usuario");
                                    v.wood = reader.GetDouble("wood");
                                    v.money = reader.GetDouble("money");
                                    v.prestige = reader.GetDouble("prestige");
                                    v.ascension = reader.GetDouble("ascension");
                                    for (int i = 1; i <= 8; i++)
                                    {
                                        v.upgwood[i-1] = reader.GetInt32($"woodupg{i}");
                                        v.upgplantil[i-1] = reader.GetInt32($"plantilupg{i}");
                                        v.upgascension[i - 1] = reader.GetInt32($"ascensionupg{i}");
                                    }
                                    v.trees = reader.GetInt32("arvores");
                                    v.senha = reader.GetString("senha");

                                    Console.WriteLine($"Usuário: {v.id}, Wood: {Math.Round(v.wood)}, Money: {Math.Round(v.money)}, Árvores: {v.trees}");
                                    v.save = true;
                                    break;
                                }
                                else
                                {
                                    
                                    Console.WriteLine("Usuário ou senha inválidos.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Saves();
                                }
                            }
                        }
                    }
                    Console.ReadKey();
                }

            }
        }

        public static void AutoSave()
        {
            string servidor = "localhost"; // Seu servidor MySQL local
            string porta = "3306";         // Porta do seu servidor MySQL
            string usuario = "root";      // Usuário do banco de dados
            string senha = "";            // Senha do banco de dados
            string nomeBanco = "woodland"; // Nome do banco de dados que você deseja conectar

            string connectionString = $"server={servidor};port={porta};user={usuario};password={senha};database={nomeBanco};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"UPDATE saves SET wood = {Math.Round(v.wood)}, money = {Math.Round(v.money)}, prestige = {Math.Round(v.prestige)}, ascension = {Math.Round(v.ascension)}, woodupg1 = {v.upgwood[0]}, woodupg2 = {v.upgwood[1]}, woodupg3 = {v.upgwood[2]}, woodupg4 = {v.upgwood[3]}, woodupg5 = {v.upgwood[4]}, woodupg6 = {v.upgwood[5]}, woodupg7 = {v.upgwood[6]}, woodupg8 = {v.upgwood[7]}, plantilupg1 = {v.upgplantil[0]}, plantilupg2 = {v.upgplantil[1]}, plantilupg3 = {v.upgplantil[2]}, plantilupg4 = {v.upgplantil[3]}, plantilupg5 = {v.upgplantil[4]}, plantilupg6 = {v.upgplantil[5]}, plantilupg7 = {v.upgplantil[6]}, plantilupg8 = {v.upgplantil[7]}, ascensionupg1 = {v.upgascension[0]}, ascensionupg2 = {v.upgascension[1]}, ascensionupg3 = {v.upgascension[2]}, ascensionupg4 = {v.upgascension[3]}, ascensionupg5 = {v.upgascension[4]}, ascensionupg6 = {v.upgascension[5]}, ascensionupg7 = {v.upgascension[6]}, ascensionupg8 = {v.upgascension[7]}, arvores = {v.trees} WHERE usuario = '{v.id}'";
                    //string query = $"UPDATE saves SET wood = {Math.Round(v.wood)}, money = {Math.Round(v.money)}, prestige = {v.prestige}, ascension = {v.ascension} WHERE ID = {v.id}";
                    //string query2 = $"UPDATE saves SET woodupg1 = {v.upgwood[0]} WHERE id = {v.id}";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute o comando SQL
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        public static void CriarSave(object criarJogo, object criarsenhaJogo)
        {
            string servidor = "localhost"; // Seu servidor MySQL local
            string porta = "3306";         // Porta do seu servidor MySQL
            string usuario = "root";      // Usuário do banco de dados
            string senha = "";            // Senha do banco de dados
            string nomeBanco = "woodland"; // Nome do banco de dados que você deseja conectar

            string connectionString = $"server={servidor};port={porta};user={usuario};password={senha};database={nomeBanco};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"INSERT INTO saves (usuario, wood, money, prestige, ascension, woodupg1, woodupg2, woodupg3, woodupg4, woodupg5, woodupg6, woodupg7, woodupg8, plantilupg1, plantilupg2, plantilupg3, plantilupg4, plantilupg5, plantilupg6, plantilupg7, plantilupg8, ascensionupg1, ascensionupg2, ascensionupg3, ascensionupg4, ascensionupg5, ascensionupg6, ascensionupg7, ascensionupg8, arvores, senha) VALUES ('{criarJogo}', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '{criarsenhaJogo}');";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Execute o comando SQL
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }
    }
}
