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
        #endregion

        #region Atributos
        private string nombre;
        private string pais;
        #endregion
        #region Metodos
        public override string ToString()
        {
            return $"{Nombre} | {Pais}";
        }
        #endregion

    }
}
