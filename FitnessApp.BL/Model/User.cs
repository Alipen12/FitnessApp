using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    [Serializable]
    public class User
    {
        #region Свойства

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>

        #endregion Свойство

        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {

            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException
                    ("Имя пользователя не может быть пустым или null", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1940") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозмодная дата рождения", nameof(birthDate));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Невозмодный вес", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException("Невозмодный рост", nameof(height));
            }
            #endregion Проверка условий

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;

        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException
                    ("Имя пользователя не может быть пустым или null", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name + " " + Age  ;
        }
    }
}
