using RegistroLibros.DAL;
using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibros.BLL
{
    public class TipoBLL
    {
        public static bool Guardar(Tipos tipos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Tipos.Add(tipos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Tipos tipos)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tipos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("El tipo de libro no se ha modificado");
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Tipos tipos = contexto.Tipos.Find(id);

                contexto.Tipos.Remove(tipos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran libros registrados");
            }
            return paso;
        }

        public static Tipos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Tipos tipos = new Tipos();
            try
            {
                tipos = contexto.Tipos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran tipos de libros registrados");
            }
            return tipos;
        }

        public static List<Tipos> GetList(Expression<Func<Tipos, bool>> expression)
        {
            List<Tipos> tipos = new List<Tipos>();
            Contexto contexto = new Contexto();
            try
            {
                tipos = contexto.Tipos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encuentran tipos de libros registrados");
            }
            return tipos;
        }
    }
}