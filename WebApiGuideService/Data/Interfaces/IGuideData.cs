using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.Data.Interfaces
{
    /*Интерфейс, с помощью которого мы получаем данные и можем работать с ними*/
    public interface IGuideData
    {
        IEnumerable<ConstructionObjects> AllConstructionObjects { get; } //Получить все объекты строительства
        IEnumerable<DataVersions> AllDataVersions { get; }// Получить все версии данных
        IEnumerable<GuideStructure> AllGuides { get; } // Получить все справочники
        IEnumerable<Atributes> GuideAtributes { get; }// Получить все атрибуты
    }
}
