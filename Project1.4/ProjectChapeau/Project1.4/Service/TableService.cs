﻿using Project1._4.DAL;
using Project1._4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1._4.Service
{
    public class TableService
    {
        private TableDao tabledb;
        public TableService()
        {
            tabledb = new TableDao();
        }
        public Table GetTableById(int tableId)
        {
            return tabledb.GetTableById(tableId);
        }
        public Reservation GetReservationById(int reservationId)
        {
            return tabledb.GetReservationById(reservationId);
        }
        public void UpdateTableStatus(TableStatus status, int tableId)
        {
            tabledb.UpdateTableStatus(status, tableId);
        }
        public List<Table> GetAllTables()
        {
            return tabledb.GetAllTables();
        }
        public void ReserveTable(Reservation reservation , int tableId)
        {
            tabledb.ReserveTable(reservation , tableId);
        }
        public void RemoveReservation(Reservation reservation, int tableId , TableStatus status)
        {
            tabledb.RemoveReservation(reservation, tableId , status);
        }
    }
}