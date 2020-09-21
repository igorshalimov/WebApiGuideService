using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.Data
{
    /*класс для заполнения данных и сохранения, при начале работы сервиса для дальнейшей демонстрации и работы с данными в сервисе*/
    public class DBObjects
    {
        public static void Initial(AppDBContent content) 
        {
            if (!content.dataVersions.Any())
            {
                content.dataVersions.AddRange
                    (
                      new DataVersions { Name = "Версия 1", VersionType = "Основная" },
                      new DataVersions { Name = "Версия 2", VersionType = "Черновик" },
                      new DataVersions { Name = "Версия 3", VersionType = "Черновик" }
                    );
            }

            if (!content.constructionObjects.Any())
            {
                content.constructionObjects.AddRange
                    (
                       new ConstructionObjects { Name = "Объект 1", ObjectCode = "S-01", Budget = 100.25f },
                       new ConstructionObjects { Name = "Объект 2", ObjectCode = "S-02", Budget = 150.00f },
                       new ConstructionObjects { Name = "Объект 3", ObjectCode = "S-QWE", Budget = 99.678f }
                    );
            }

            if (!content.guides.Any())
            {
                content.guides.AddRange
                    (
                        new GuideStructure
                        { Name = "Объекты строительства"},
                        new GuideStructure
                        {Name = "Версии данных" }
                    );

                if (!content.Atributes.Any())
                {
                    content.Atributes.AddRange
                    (
                        new Atributes { Name = "Идентификатор", DataType = "Числовой", guideStructureId = 0 }, 
                        new Atributes { Name = "Наименование", DataType = "Строковый", guideStructureId = 0 },
                        new Atributes { Name = "Код Объекта", DataType = "Строковый", guideStructureId = 1 },
                        new Atributes { Name = "Бюджет, млн. руб.", DataType = "Вещественный", guideStructureId = 1 },
                        new Atributes { Name = "Тип версии", DataType = "Строковый", guideStructureId = 2 }

                    );
                }    

            }

            content.SaveChanges();
        }

        

    }
}
