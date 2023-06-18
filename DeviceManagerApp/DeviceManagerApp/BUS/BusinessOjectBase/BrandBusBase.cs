﻿using DAO.DataLayer;
using DeviceManagerApp.DAO.DataLayer;
using DeviceManagerApp.DTO.Model;
using DTO.Model;
using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeviceManagerApp.BUS.BusinessOjectBase
{
    public class BrandBusBase
    {
        public static DataTable GetAllBrand()
        {
            return BrandDAO.getData();
        }
        public static void InsertBrand(BrandModel brand)
        {
            if(BrandDAO.CheckNameBrand(brand.Name))
            {
                throw new Exception("Tên Thương Hiệu Đã Tồn Tại");
            }
            else
            {
                BrandDAO.InsertBrand(brand);
            }
        }
        public static void UpdateBrand(BrandModel brand)
        {
            if (BrandDAO.IsDuplicateBrand(brand,brand.Id))
            {
                throw new Exception("Tên Thương Hiệu Đã Tồn Tại");
            }
            BrandDAO.UpdateBrand(brand);
        }
        public static DataTable GetBrandAfterDelete()
        {
            return BrandDAO.GetBrandAfterDelete();
        }
        public static void DeleteBrand(int id) { 
            BrandDAO.DeleteBrand(id);
        }
    }
}
