﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace hastaneRandevuSistemi.Models.signUp
{
    public class signUp
    {
        public int  patId { get; set; }

        [Display (Name ="Hasta Tc Kimlik No:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public long patTc { get; set; }

        [Display(Name = "Hasta Adı:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patName { get; set; }

        [Display(Name = "Hasta Soyadı:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patSurname { get; set; }

        [Display(Name = "Hasta Doğum Tarihi:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public DateTime patBirthday { get; set; }

        [Display(Name = "Hasta Telefon Numarası:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public int patPhoneNo { get; set; }

        [Display(Name = "Hasta Mail Adresi:")]
        public string patEmail { get; set; }

        [Display(Name = "Hasta Parola:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public int patParola { get; set; }

        [Display(Name = "Hasta Tekrar Parola:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public int patTeParola { get; set; }

        [Display(Name = "Hastanın Yaşadığı Şehir:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patCity { get; set; }
    }
}
