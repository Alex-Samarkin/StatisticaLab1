using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticaLab1
{
    public class Person
    {
        //
        [DisplayName("Институт"),Description(""),Category("Общие сведения")]
        public string Institut { get; set; } = "Медицинский";
        [DisplayName("Специальность"), Description(""), Category("Общие сведения")]
        public string Spec { get; set; } = "Лечебное дело";
        [DisplayName("Курс"), Description("Номер курса"), Category("Общие сведения")]
        public int Curs { get; set; } = 2;
        [DisplayName("Группа"), Description("Полное название группы"), Category("Общие сведения")]
        public string Group { get; set; } = "0402-05";
        //
        [DisplayName("Фамилия"), Description(""), Category("ФИО")]
        public string FName { get; set; } = "Иванов";
        [DisplayName("Имя"), Description(""), Category("ФИО")]
        public string LFName { get; set; } = "Иван";
        [DisplayName("Отчество"), Description(""), Category("ФИО")]
        public string MName { get; set; } = "Иванович";
        //
        [DisplayName("Дата"), Description(""), Category("Дата")]
        public DateTime Date { get; set; } = DateTime.Now;

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Institut == person.Institut &&
                   Spec == person.Spec &&
                   Curs == person.Curs &&
                   Group == person.Group &&
                   FName == person.FName &&
                   LFName == person.LFName &&
                   MName == person.MName &&
                   Date == person.Date;
        }

        public override int GetHashCode()
        {
            var h = new HashCode();
            //h.Add(base.GetHashCode());
            h.Add(Institut);
            h.Add(Spec);
            h.Add(Curs);
            h.Add(Group);
            h.Add(FName);
            h.Add(LFName);
            h.Add(MName);
            h.Add(Date.Year);
            h.Add(Date.Month);
            h.Add(Date.DayOfWeek);
            h.Add(Date.Day);
            h.Add(Date.Hour);
            return h.ToHashCode();
        }
        //
        [DisplayName("Code"),Browsable(true),ReadOnly(true),Category("Misc")]
        public int HashCode => GetHashCode();
    }
}
