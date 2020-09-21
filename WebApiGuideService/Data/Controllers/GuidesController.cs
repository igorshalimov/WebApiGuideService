using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGuideService.Data.Interfaces;
using WebApiGuideService.Data.Models;
using WebApiGuideService.ViewModels;

namespace WebApiGuideService.Data.Controllers
{
    [Route("api/[controller]")]
    public class GuidesController : ControllerBase
    {
        private readonly IGuideData _guideData; //Объект интерфейса
        /*Данная View модель была сделана с целью удобной демонстрации и показа полной структуры данных всех справочников и отображения этих данных на странице*/
        private GuidesViewModels obj = new GuidesViewModels(); 

        public GuidesController(IGuideData guideData)
        {
            _guideData = guideData; // реализуем интерфейс 
            obj.constructionObj = _guideData.AllConstructionObjects; // получаем все сразу при запуске сервиса, а именно данные по объектам строительства
            obj.dataVersions = _guideData.AllDataVersions; //версиям данных
            obj.guides = _guideData.AllGuides; //всем справочникам
            obj.guideAtributes = _guideData.GuideAtributes;//всем атрибутам
        }

        /*Get метод который срабатывает по умолчанию при запуске сервиса, и возвращает по умолчанию все справочники, которые имеются в БД
         Адрес по умолчанию localhost:<port>/api/guides 
        */
        [HttpGet]
        public ActionResult<IEnumerable<ConstructionObjects>> Get()
        {
            return this.Ok(obj.guides);
        }



        /*
         * Здесь я пытался сделать Fronted в самом начале, но потом понял, что ухожу далеко от истины, и поэтому приостановаил данную деятельность
         * В данном проекте Вы можете увидеть папку Views там хранятся Razor страницы c которыми я пытался работать, такжже использовал подключение Bootstrap
         */

        //[HttpGet]
        //public ViewResult List()
        //{
        //    ViewBag.Title = "Сервис справочников";
        //    obj.GuideCurrent = obj.guides.ToList().FirstOrDefault().Name;
        //    return View(obj);
        //}

        //[HttpGet("All")]
        //public ViewResult All()
        //{
        //    ViewBag.Title = "Сервис справочников";
        //    obj.GuideCurrent = "Все справочники";
        //    return View(obj);
        //}



        /* 
         * Если ввести Адрес localhost:<port>/api/guides/constructions -> то сервис выдаст данные по объектам строительства
         * Если ввести Адрес localhost:<port>/api/guides/versions -> то сервис выдаст данные по версиям
         */
        [HttpGet("{Data}")]
        public ActionResult GetData(string Data)
        {
            Object DataGuide = null;
            switch (Data)
            {
                case "constructions": DataGuide = obj.constructionObj; break;
                case "versions": DataGuide = obj.dataVersions;  break;
                default: DataGuide = "NoData";  break;
            }
            return this.Ok(DataGuide);            
        }

        /* 
          * Если ввести Адрес localhost:<port>/api/guides/metadata/id=1 -> то сервис выдаст метаданные справочника объекты строительства
          * Если ввести Адрес localhost:<port>/api/guides/metadata/id=2 -> то сервис выдаст метаданные справочника версии данных
        */

        [HttpGet("metadata/id={id}")]
        public ActionResult GetMetaData(int id)
        {
            GuideMetaData guidemetadata = new GuideMetaData(); // с целью удобной демонстрации и показа полной структуры метаданных справочника со всеми его атрибутами
            guidemetadata.guide = obj.guides.ToList().Find(g => g.Id == id);
            guidemetadata.guideAtr = obj.guideAtributes.ToList().FindAll(ind => ind.guideStructureId == 0 || ind.guideStructureId == id);
            if (id > 0 && id < 3) return this.Ok(guidemetadata);
            else return this.Ok("NoMetaData");
        }
    }
}
