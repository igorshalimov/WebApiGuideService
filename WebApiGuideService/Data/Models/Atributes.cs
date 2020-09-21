using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGuideService.Data.Models
{
    //Атрибуты справочника (на данном этапе каждый атрибут существует как самостоятельный отдельный элемент, который используется в одном или нескольких справочниках)
    //читайте комментарий в модели guideStructure
    public class Atributes 
    {
        /*Идентификатор атрибута*/
        public int id { get; set; }
        /*Наименование атрибута*/
        public string Name { get; set; }        
        /*Тип данных*/
        public string DataType { get; set; }
        /*Идентификатор справочника*/
        public int guideStructureId { get; set; } /* Если guideStructureId=0, то данный атрибут универсален и присутсвует в каждом справочнике
                                                   значение 1 соостветствует справочнику объекты строительства
                                                    значение 2 соответсвует справочнику версии данных*/

    }
}
