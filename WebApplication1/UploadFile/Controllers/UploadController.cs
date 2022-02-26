using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadFile.Controllers
{
    public class UploadController : Controller
    {
        //Get Img with docx
        public ActionResult GetImageAndPath(String imgpath, String docxpath, int fileImgSize, int fileDocSize, String typeFileImg, String typeFileDocx)
        {
            string filename = imgpath;
            string filename2 = docxpath;

            ViewBag.FileImg = filename;

            FileInfo fi = new FileInfo(filename);
            FileInfo fi2 = new FileInfo(filename2);

            //img
            string justFileName = fi.Name;
            ViewBag.Message = justFileName;
            //docx
            string justFileName2 = fi2.Name;
            ViewBag.Message2 = justFileName2;
            //download 

            //dem kich co file
            ViewBag.CountStorageDocx = fileDocSize;

            //loai file
            ViewBag.typeDocxFile = typeFileDocx;


            return View();
        }


        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UploadFiles()
        {
            return View();
        } 


        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase ImgUpload, HttpPostedFileBase DocxUpload)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    //Method 2 Get file details from HttpPostedFileBase class    

                    if (ImgUpload != null && DocxUpload != null)
                    {
                        string path = Path.Combine(Server.MapPath("~/UploadFiles"), Path.GetFileName(ImgUpload.FileName));
                        string path2 = Path.Combine(Server.MapPath("~/UploadFiles"), Path.GetFileName(DocxUpload.FileName));

                        ImgUpload.SaveAs(path);
                        DocxUpload.SaveAs(path2);

                        int fileImgSize = ImgUpload.ContentLength;
                        int fileDocxSize = ImgUpload.ContentLength;

                        String fileImgType = ImgUpload.ContentType;
                        String fileDocxType = DocxUpload.ContentType;

                        GetImageAndPath(path, path2, fileImgSize, fileDocxSize, fileImgType, fileDocxType);
                      
                    }
                    ViewBag.FileStatus = "File uploaded successfully.";
                    return View("GetImageAndPath");
                }
                catch (Exception)
                {
                    ViewBag.FileStatus = "Error while file uploading."; ;
                }
            }
            return View("Index");
        }
    }
}