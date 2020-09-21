using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WebApiGuideService.Data.Interfaces;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.Data.Implementations
{
    /*
     * делал временную реализацию интерфейса для проверки работоспособности
     */
    public class GuideData /*: IGuideData*/
    {
        //public IEnumerable<ConstructionObjects> AllConstructionObjects
        //{
        //    get { return new List<ConstructionObjects> { new ConstructionObjects { id = 1, Name = "Объект 1", ObjectCode = "S-01", Budget = 100.25f } };   }
        //}

        //public IEnumerable<DataVersions> AllDataVersions
        //{
        //    get { return new List<DataVersions> { new DataVersions { id = 1, Name = "Версия 1", VersionType = "Основная" } }; }
        //}

        //public IEnumerable<GuideStructure> AllGuides
        //{
        //    get
        //    {
        //        return new List<GuideStructure>
        //        {
        //            new GuideStructure
        //            {
        //                Id = 1,
        //                Name = "Объекты строительства"                       
        //            },

        //            new GuideStructure
        //            {
        //                Id = 2,
        //                Name = "Версии данных"
        //            },


        //        };
        //    }
        //}

        //public IEnumerable<Atributes> GuideAtributes
        //{
        //    get 
        //    {
        //        return new List<Atributes>
        //        {
        //             new Atributes { id = 1, Name = "Идентификатор", DataType = "Числовой", guideStructureId = 0 },
        //             new Atributes { id = 2, Name = "Наименование", DataType = "Строковый", guideStructureId = 0 },
        //             new Atributes { id = 3, Name = "Код Объекта", DataType = "Строковый", guideStructureId = 1 },
        //             new Atributes { id = 4, Name = "Бюджет, млн. руб.", DataType = "Вещественный", guideStructureId = 1 },
        //             new Atributes { id = 5, Name = "Тип версии", DataType = "Строковый", guideStructureId = 2 }
        //        };
        //    }
        //}
    }
}
