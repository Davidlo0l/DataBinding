namespace DataBinding
{
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

    public class Persona:Notificable
    {
        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre; 
            }
            set
            {
                if(nombre == value)
                    {
                    return;
                }
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        public string Pais
        {
            get
            {
                return pais;

            }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged("Pais");
            }
        }
    

        public decimal Saldo
        {
            get { return saldo; }
            set {
                if (Saldo == value)
                {
                    return;
                }
                saldo = value;
                OnPropertyChanged("saldo");
            }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set {
                if (fechaNacimiento == value)
                {
                    return;
                }
                fechaNacimiento = value;
                OnPropertyChanged("fecha de Nacimiento");
            }
        }

        #endregion

        #region Atributos
        private string nombre;
        private string pais;
        private decimal saldo;
        #endregion
        #region Metodos
        public override string ToString()
        {
            return $"{Nombre} | {Pais} |{ Saldo} {fechaNacimiento}|";
        }
        #endregion

    }
}
