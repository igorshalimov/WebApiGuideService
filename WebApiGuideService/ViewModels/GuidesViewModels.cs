using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.ViewModels
{
    /*так как я пытался сделать fronted реализацию, сделал данныую модель чтобы передавать ее как полностью так и частично в шаблоны*/
    public class GuidesViewModels
    {
        public IEnumerable<ConstructionObjects> constructionObj { get; set; } // список всех объектов стороительства
        public IEnumerable<DataVersions> dataVersions { get; set; } // список всех версий 
        public IEnumerable<GuideStructure> guides { get; set; }// список всех справочников
        public IEnumerable<Atributes> guideAtributes { get; set; }// список всех атрибутов
        public string GuideCurrent { get; set; }// строка для заголовка, определяющая конкретный справочник
    }
}
