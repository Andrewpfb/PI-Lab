﻿using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using MVC5_3.Models;

namespace MVC5_3.Controllers
{
    public class HomeController : Controller
    {
        VideoContext db = new VideoContext();
        static Video selectedVideo = new Video();

        /// <summary>
        /// Сохраняет выбранное видео.
        /// </summary>
        /// <param name="id">Необязаельный параметр. Если id является null, то видео не выбрано.</param>
        /// <returns></returns>
        public ActionResult SetVideo(int? id)
        {
            if (id != null & id != 0)
            {
                selectedVideo = db.Videos.Find(id);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            GetVideo();
            return View();
        }

        public ActionResult VideoList()
        {
            IEnumerable<Video> videos = db.Videos;
            return PartialView(videos);
        }

        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }

        /// <summary>
        /// Метод для загрузки видео-файла на сервер, в качестве имени выбирается комбинация id+title, 
        /// для избежания коллизий.
        /// </summary>
        /// <param name="upload">Объект, содержащий информацию о загружаемом файле.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
                if (upload != null)
                {
                    Video tmp = new Video(upload.FileName);
                    db.Videos.Add(tmp);
                    db.SaveChanges();
                    string fileName = Path.GetFileName(upload.FileName);
                upload.SaveAs(Server.MapPath("~/Videos/" + tmp.Id + "_" + fileName));
                }
            return RedirectToAction("Index");
        }
        /// <summary>
        /// Отдает видео в файловом потоке.
        /// </summary>
        /// <returns></returns>
        public FileStreamResult GetVideo()
        {
            if (selectedVideo.Id == 0)
            {
                return null;
            }
            return new FileStreamResult(
                new FileStream
                (Server.MapPath("~/Videos/" + selectedVideo.Id + "_" + selectedVideo.Title),
                FileMode.Open,
                FileAccess.Read
                ), "video/mp4");
        }
    }
}