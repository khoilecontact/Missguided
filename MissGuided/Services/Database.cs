using System;
using System.Collections.Generic;
using MissGuided.Models;
using MissGuided.Models.CheckoutInfo;
using SQLite;

namespace MissGuided.Services
{
    public class Database
    {
        public Database()
        {
        }

        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

        // Khởi tạo database
        public bool createDatabase()
        {
            try
            {
                string path = System.IO.Path.Combine(folder, "MissguidedSQLiteDatabase.db");
                var connection = new SQLiteConnection(path);

                // Tạo bảng
                connection.CreateTable<Address>();
                connection.CreateTable<DeliveryOption>();

                return true;
            }
            catch (SQLiteException ex)
            {
                return false;
                throw;
            }
        }

        public bool addNewAddress(Address address)
        {
            try
            {
                // Tạo kết nối
                string path = System.IO.Path.Combine(folder, "MissguidedSQLiteDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Insert(address);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<Address> getAddresses()
        {
            try
            {
                // Tạo kết nối
                string path = System.IO.Path.Combine(folder, "MissguidedSQLiteDatabase.db");
                var connection = new SQLiteConnection(path);

                return connection.Table<Address>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool addNewDeliveryOptions (DeliveryOption option)
        {
            try
            {
                // Tạo kết nối
                string path = System.IO.Path.Combine(folder, "MissguidedSQLiteDatabase.db");
                var connection = new SQLiteConnection(path);

                connection.Insert(option);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AAAAAAA" + ex.ToString());
                return false;
                throw;
            }
        }

        public List<DeliveryOption> getDeliveryOptions()
        {
            try
            {
                // Tạo kết nối
                string path = System.IO.Path.Combine(folder, "MissguidedSQLiteDatabase.db");
                var connection = new SQLiteConnection(path);

                return connection.Table<DeliveryOption>().ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
