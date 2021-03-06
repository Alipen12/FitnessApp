using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Содать новый пол
        /// </summary>
        /// <param name="name"> Имя пола </param>
        /// <exception cref="ArgumentNullException"></exception>

        public Gender(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null" , nameof(name));
            }
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
