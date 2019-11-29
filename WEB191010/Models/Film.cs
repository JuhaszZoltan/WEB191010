using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB191010.Models
{
    public class Film
    {
        public int Id { set; get; }
        public string Cim { get; set; }
        public DateTime MegjelenesDatum { get; set; }
        public DateTime BeszerzesDatum { get; set; }
        public int KeszletDb { get; set; }
        public string ImgReference { get; set; } = null;

        public string[] Mufajok
        {
            get { return MufajokDbCol.Split(','); }
            set
            {
                var mdc = "";
                foreach (var m in value) mdc += $"{m}, ";
                MufajokDbCol = mdc.Trim().TrimEnd(',');
            }
        }
        public string MufajokDbCol { get; set; }
    }
}