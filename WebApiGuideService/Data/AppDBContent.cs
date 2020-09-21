using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.Data
{
    /*класс для работы с базой данных*/
    /*База данных реализована в папке Migrations данного проекта*/
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<ConstructionObjects> constructionObjects { get; set; } // Таблица Объекты строительства
        public DbSet<DataVersions> dataVersions { get; set; }// Таблица Версии данных
        public DbSet<GuideStructure> guides { get; set; }// Таблица Справочники
        public DbSet<Atributes> Atributes { get; set; }// Таблица атрибуты
    }
}
