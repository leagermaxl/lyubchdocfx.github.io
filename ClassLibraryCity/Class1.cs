using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCity
{
    /// <summary>
    /// Абстрактный класс населенного пункта
    /// </summary>
    public abstract class Locality
    {
        /// <summary>
        /// Индекс населенного пункта
        /// </summary>
        protected int index;

        /// <summary>
        /// Население населенного пункта
        /// </summary>
        protected int population;

        /// <summary>
        /// Название населенного пункта
        /// </summary>
        protected string name;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        protected Locality()
        {
            index = -1;
            name = "неизвесно";
        }
        /// <summary>
        /// Свойство для параметра index
        /// </summary>
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                try { index = value; }
                catch (Exception) { index = -1; }
            }
        }
        /// <summary>
        /// Конструктор для населенного пункта
        /// </summary>
        /// <param name="index">Индекс населенного пункта</param>
        protected Locality(int index)
        {
            if (index <= 0)
                Index = -1;
            else
                Index = index;
            name = "неизвесно";
        }
        /// <summary>
        /// Свойство для параметра name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try { name = value; }
                catch (Exception) { name = "НазваниеГорода"; }
            }
        }
        /// <summary>
        /// Конструктор для населенного пункта
        /// </summary>
        /// <param name="index">Индекс населенного пункта</param>
        /// <param name="name">Название населенного пункта</param>
        protected Locality(int index, string name)
        {
            if (index <= 0)
                Index = -1;
            else
                Index = index;

            if (name == "")
                Name = "неизвесно";
            else
                Name = name;
        }
        /// <summary>
        /// Свойство для параметра population
        /// </summary>
        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                try { population = value; }
                catch (Exception) { population = -1; }
            }
        }
        /// <summary>
        /// Конструктор для населенного пункта
        /// </summary>
        /// <param name="index">Индекс населенного пункта</param>
        /// <param name="name">Название населенного пункта</param>
        /// <param name="population">Количество населения населенного пункта</param>
        protected Locality(int index, string name, int population)
        {
            if (index <= 0)
                Index = -1;
            else
                Index = index;
            if (name == "")
                Name = "неизвесно";
            else
                Name = name;
            if (population <= 0)
                Population = -1;
            else
                Population = population;
        }
        /// <summary>
        /// Метод возвращения всей информации
        /// </summary>
        /// <returns>Вся информация в виде строки</returns>
        public virtual string Print()
        {   
            return $"Индекс = {index}\nНазвание = {name}\nНаселение = {population}\n";
        }
    }
    /// <summary>
    /// Класс города
    /// </summary>
    public class City : Locality
    {
        /// <summary>
        /// Имя мэра города
        /// </summary>
        protected string mayor;
        /// <summary>
        /// Количество больниц города
        /// </summary>
        protected int numHospital;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public City() : base()
        {
            mayor = "неизвесно";
            numHospital = -1;
        }
        /// <summary>
        /// Свойство для переменной mayor
        /// </summary>
        public string Mayor
        {
            get
            {
                return mayor;
            }
            set
            {
                try { mayor = value; }
                catch (Exception) { mayor = "ИмяМэра"; }
            }
        }
        /// <summary>
        /// Конструктор для города
        /// </summary>
        /// <param name="mayor">Имя мэра города</param>
        public City(string mayor) : base()
        {
            if (mayor == "")
                Mayor = "неизвесно";
            else
                Mayor = mayor;
            numHospital = -1;
        }
        /// <summary>
        /// Конструктор для города
        /// </summary>
        /// <param name="index">Индекс города</param>
        /// <param name="name">Название города</param>
        /// <param name="population">Количество населения города</param>
        /// <param name="mayor">Имя мэра города</param>
        public City(int index, string name, int population, string mayor) : base(index, name, population)
        {
            if (mayor == "")
                Mayor = "неизвесно";
            else
                Mayor = mayor;
            numHospital = -1;
        }
       /// <summary>
       /// Свойство для параметра numHospital
       /// </summary>
        public int NumHospital
        {
            get
            {
                return numHospital;
            }
            set
            {
                try { numHospital = value; }
                catch (Exception) { numHospital = -1; }
            }
        }
        /// <summary>
        /// Конструктор для города
        /// </summary>
        /// <param name="mayor">Имя мэра города</param>
        /// <param name="numHospital">Количество больниц города</param>
        public City(string mayor, int numHospital) : base()
        {
            if (mayor == "")
                Mayor = "неизвесно";
            else
                Mayor = mayor;
            if (numHospital <= 0)
                NumHospital = -1;
            else
                NumHospital = numHospital;
        }
        /// <summary>
        /// Конструктор для города
        /// </summary>
        /// <param name="index">Индекс города</param>
        /// <param name="name">Название города</param>
        /// <param name="population">Количество населения города</param>
        /// <param name="mayor">Имя мэра города</param>
        /// <param name="numHospital">Количество больниц города</param>
        public City(int index, string name, int population, string mayor, int numHospital) : base(index, name, population)
        {
            if (mayor == "")
                Mayor = "неизвесно";
            else
                Mayor = mayor;
            if (numHospital <= 0)
                NumHospital = -1;
            else
                NumHospital = numHospital;
        }
        /// <summary>
        /// Переоперделённый метод для возвращения всей информации для города
        /// </summary>
        /// <returns>Вся информация в виде строки</returns>
        public override string Print()
        {
            return $"Индекс = {index}\nНазвание Города = {name}\nНаселение = {population}\nИмя мэра = {mayor}\nКоличество больниц = {numHospital}\n";
        }
    }
    /// <summary>
    /// Класс села
    /// </summary>
    public class Village : Locality
    {
        /// <summary>
        /// Имя сельского головы
        /// </summary>
        protected string ruralHead;
        /// <summary>
        /// Количество домов села
        /// </summary>
        protected int numHouse;
        /// <summary>
        /// Конструктор по умолчанию для села
        /// </summary>
        public Village() : base()
        {
            ruralHead = "неизвесно";
            numHouse = 0;
        }
        /// <summary>
        /// Свойство для параметра ruralHead
        /// </summary>
        public string RuralHead
        {
            get
            {
                return ruralHead;
            }
            set
            {
                try { ruralHead = value; }
                catch (Exception) { ruralHead = "ИмяСельскогоГоловы"; }
            }
        }
        /// <summary>
        /// Конструктор для села
        /// </summary>
        /// <param name="ruralHead">Имя сельского головы</param>
        public Village(string ruralHead) : base()
        {
            if (ruralHead == "")
                RuralHead = "неизвесно";
            else
                RuralHead = ruralHead;
            numHouse = 0;
        }
        /// <summary>
        /// Конструктор для села
        /// </summary>
        /// <param name="index">Индекс села</param>
        /// <param name="name">Название села</param>
        /// <param name="population">Количество населения села</param>
        /// <param name="ruralHead">Имя сельского головы</param>
        public Village(int index, string name, int population, string ruralHead) : base(index, name, population)
        {
            if (ruralHead == "")
                RuralHead = "неизвесно";
            else
                RuralHead = ruralHead;
            numHouse = 0;
        }
        /// <summary>
        /// Свойство для параметра numHouse
        /// </summary>
        public int NumHouse
        {
            get
            {
                return numHouse;
            }
            set
            {
                try { numHouse = value; }
                catch (Exception) { numHouse = -1; }
            }
        }
        /// <summary>
        /// Конструктор для села
        /// </summary>
        /// <param name="ruralHead">Имя сельского головы</param>
        /// <param name="numHouse">Количество домов села</param>
        public Village(string ruralHead, int numHouse) : base()
        {
            if (ruralHead == "")
                RuralHead = "неизвесно";
            else
                RuralHead = ruralHead;
            if (numHouse <= 0)
                NumHouse = -1;
            else
                NumHouse = numHouse;
        }
        /// <summary>
        /// Конструктор для села
        /// </summary>
        /// <param name="index">Индекс села</param>
        /// <param name="name">Название села</param>
        /// <param name="population">Количество населения села</param>
        /// <param name="ruralHead">Имя сельского головы</param>
        /// <param name="numHouse">Количество домов села</param>
        public Village(int index, string name, int population, string ruralHead, int numHouse) : base(index, name, population)
        {
            if (ruralHead == "")
                RuralHead = "неизвесно";
            else
                RuralHead = ruralHead;
            if (numHouse <= 0)
                NumHouse = -1;
            else
                NumHouse = numHouse;
        }
        /// <summary>
        /// Переоперделённый метод для возвращения всей информации для села
        /// </summary>
        /// <returns>Вся информация в виде строки</returns>
        public override string Print()
        {
            return $"Индекс = {index}\nНазвание села = {name}\nНаселение = {population}\nИмя сельского головы = {ruralHead}\nКоличество домов = {numHouse}";
        }
    }
}
