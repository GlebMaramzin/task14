using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_020221_TBD61
{
    //Описание класса BOX
    class BOX
    {
        //Закрытые поля класса BOX
        private int number;
        private float width;
        private float weight;
        private float length;

        //Конструктор без параметров, устанавливает значения полей класса по умолчанию
        public BOX()
        {
            this.number = 20;
            this.width = 10.2f;
            this.weight = 2.4f;
            this.length = 1.8f;
        }

        //Перегруженный конструктор с параметрами, через сеттеры устанавливает значения полей класса
        public BOX(int number, float width, float weight, float length)
        {
            this.setNumber(number);
            this.setWeight(width);
            this.setWeight(weight);
            this.setLength(length);
        }

        //Геттеры для полей класса
        public int getNumber() => this.number;

        public float getWidth() => this.width;

        public float getWeight() => this.weight;

        public float getLength() => this.length;

        //Сеттеры для полей класса
        public void setNumber(int number)
        {
            if (number > 0)
            {
                this.number = number;
            }
        }

        public void setWidht(float width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        }

        public void setWeight(float weight)
        {
            if (weight > 0)
            {
                this.weight = weight;
            }
        }

        public void setLength(float length)
        {
            if (length > 0)
            {
                this.length = length;
            }
        }
    }
}
