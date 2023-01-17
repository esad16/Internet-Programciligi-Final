﻿using Microsoft.AspNetCore.Mvc;
using WebFinal.Models;

namespace WebFinal.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Ogrencisayfası()
        {
            return View();
        }

        public IActionResult Yeni()
        {
            return View();
        }

        public IActionResult OgrenciDetay(int id)
        {
            var r = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        public IActionResult OgrenciSil(int id)
        {
            var r = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == id);
            Models.OgrenciVeri.Ogrenciler.Remove(r);
            return RedirectToAction("Listele");
        }


        [HttpPost]
        public IActionResult Yeni(Ogrenci ogrenci)
        {
            Models.OgrenciVeri.Ogrenciler.Add(ogrenci);
            return RedirectToAction("Listele");
        }

        [HttpPost]
        public IActionResult Guncelle(Ogrenci ogrenci)
        {
            var r = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == ogrenci.Id);
            Models.OgrenciVeri.Ogrenciler.Remove(r);
            Models.OgrenciVeri.Ogrenciler.Add(ogrenci);
            return RedirectToAction("Listele");
        }

        public IActionResult Listele()
        {
            return View(Models.OgrenciVeri.Ogrenciler);
        }


    }
}
