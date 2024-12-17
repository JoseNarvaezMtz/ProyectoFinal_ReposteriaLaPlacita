using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoBase
{
    internal class ImagenConvert
    {
        // Convertir Imagen a byte[]
        public byte[] imagenToByte(Image img)
        {
            if (img == null)
            {
                return null;
            }
            // Aquí se puede especificar el formato de la imagen según sea necesario
            MemoryStream memoria = new MemoryStream();
            img.Save(memoria, ImageFormat.Png);
            byte[] byteArray = memoria.ToArray(); 
            //MessageBox.Show("Tamaño de la imagen en bytes: " + byteArray.Length); // Verificación del tamaño
            return byteArray;
        }

        // Convertir Bitmap a Image
        public Image BitmapToImagen(Bitmap bmp)
        {
            if (bmp == null)
            {
                return null;
            }
            MemoryStream memoria = new MemoryStream();
            bmp.Save(memoria, ImageFormat.Png);
            memoria.Position = 0; // Resetear la posición del stream antes de leerlo
            return Image.FromStream(memoria);
        }
    }

}
