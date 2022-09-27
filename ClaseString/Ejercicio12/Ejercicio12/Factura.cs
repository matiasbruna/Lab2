using System;
class Factura
{
    private string nombre = "1";
    private string apellido = "";


    public void CargarNombre (string n)
     {

        nombre = n;
      }

    public string leernombre ()
    {

        return nombre;
    }

}   