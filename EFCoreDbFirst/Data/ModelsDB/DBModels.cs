using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace EFCoreDbFirst.Data.ModelsDB
{
    public class DBModels
    {
        private readonly string ConnectionString="Server=localhost;Database=Intern;Uid=raccoon;Pwd=123456;";

        public List<ThingsModel> GetThings(){
            MySqlConnection sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM todolist_tbl",sqlConnection);
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();

            List<ThingsModel> things=new List<ThingsModel>();
            if(sqlReader.HasRows){
                while(sqlReader.Read()){
                    ThingsModel thing=new ThingsModel{
                        Id = Convert.ToInt32(sqlReader["id"]),
                        Title = sqlReader.GetString(sqlReader.GetOrdinal("title")),
                        CreateTime = sqlReader.GetDateTime(sqlReader.GetOrdinal("createTime")),
                        EndTime = sqlReader.GetDateTime(sqlReader.GetOrdinal("endTime")),
                    };
                    things.Add(thing);
                }
            }else{
                Console.WriteLine("SQL Empty");
            }
            sqlReader.Close();
            return things;
        }

        public void CreateThings(ThingsModel thing){
            MySqlConnection sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();
            MySqlCommand sqlCommand = new MySqlCommand("insert into todolist_tbl(title, createTime, endTime) values(@Title,NOW(),@EndTime)",sqlConnection);
            sqlCommand.Parameters.Add(new MySqlParameter("@Title",thing.Title));
            sqlCommand.Parameters.Add(new MySqlParameter("@EndTime",thing.EndTime));
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();
            sqlReader.Close();
        }

        public ThingsModel FindThingsByID(int id){
            // ?????? Model ThingsModel thing
            ThingsModel thing = new ThingsModel();            
            // ?????? sqlConnection???????????????????????????????????????
            MySqlConnection sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();
            // ?????? sqlCommand????????? SQL ???????????????
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM todolist_tbl WHERE id = @Id",sqlConnection);
            sqlCommand.Parameters.Add(new MySqlParameter("@Id",id));
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            if(sqlReader.HasRows){
                while(sqlReader.Read()){
                    thing = new ThingsModel{
                        Id = Convert.ToInt32(sqlReader["id"]),
                        Title = sqlReader.GetString(sqlReader.GetOrdinal("title")),
                        CreateTime = sqlReader.GetDateTime(sqlReader.GetOrdinal("createTime")),
                        EndTime = sqlReader.GetDateTime(sqlReader.GetOrdinal("endTime")),
                    };
                }
            }else{
                Console.WriteLine("SQL Empty");
            }
            // ?????????????????????
            sqlReader.Read();
            sqlReader.Close();

            // ?????????????????? View ??????
            return thing;
        }

        public void UpdateThings(ThingsModel thing){
            // ?????? sqlConnection???????????????????????????????????????
            MySqlConnection sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();
            // ?????? sqlCommand????????? SQL ???????????????
            MySqlCommand sqlCommand = new MySqlCommand("UPDATE todolist_tbl SET title=@Title,createTime=@CreateTime,endTime=@EndTime WHERE id=@Id;",sqlConnection);
            sqlCommand.Parameters.Add(new MySqlParameter("@Title",thing.Title));
            sqlCommand.Parameters.Add(new MySqlParameter("@CreateTime",thing.CreateTime));
            sqlCommand.Parameters.Add(new MySqlParameter("@EndTime",thing.EndTime));
            sqlCommand.Parameters.Add(new MySqlParameter("@Id",thing.Id));
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            // ?????????????????????
            sqlReader.Read();
            sqlReader.Close();
        }


        public void DeleteByID(int id){
            // ?????? Model ThingsModel thing
            ThingsModel thing = new ThingsModel();
            // ?????? sqlConnection???????????????????????????????????????
            MySqlConnection sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();
            // ?????? sqlCommand????????? SQL ???????????????
            MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM todolist_tbl WHERE id = @Id",sqlConnection);
            sqlCommand.Parameters.Add(new MySqlParameter("@Id",id));
            MySqlDataReader sqlReader = sqlCommand.ExecuteReader();
            // ?????????????????????
            sqlReader.Read();
            sqlReader.Close();
        }
    }
}