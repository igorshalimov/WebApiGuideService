using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGuideService.Data.Models;

namespace WebApiGuideService.ViewModels
{
    /*модель для показа полной картины метаданных справочника, сделана на основе проблемы, возникшей из-за создания миграции*/
    public class GuideMetaData
    {
        public GuideStructure guide { get; set; } //конкретный справочник
        public List<Atributes> guideAtr { get; set; }//Список его атрибутов, которые данный справочник содержит
    }
}
