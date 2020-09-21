using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGuideService.Data.Interfaces;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.Data.Repository
{
    /*Основная реализация интерфейса для работы с данными*/
    public class GuideDataRepository : IGuideData
    {
        private readonly AppDBContent appDbContent; // объект доступа к базе данных

        public GuideDataRepository(AppDBContent _appdbcontent)
        {
            appDbContent = _appdbcontent; /*получаем при инициализации данные из IoC, так как класс AppDBContent зарегистрирован как зависимость в StartUp.cs данного сервиса*/
        }
        public IEnumerable<ConstructionObjects> AllConstructionObjects => appDbContent.constructionObjects; //получаем данные из таблицы Объекты строительства

        public IEnumerable<DataVersions> AllDataVersions => appDbContent.dataVersions; // получаем данные из таблицы Версии данных

        public IEnumerable<GuideStructure> AllGuides => appDbContent.guides; // получаем данные из таблицы справочники

        public IEnumerable<Atributes> GuideAtributes => appDbContent.Atributes; // получаем данные из таблицы атрибуты

    }
}
