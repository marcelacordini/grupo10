using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.config
{
    internal class FontLoader
    {
        private static PrivateFontCollection privateFonts = new PrivateFontCollection();
        private static bool fontsLoaded = false;

        public static void LoadFonts()
        {
            if (fontsLoaded) return;

            try
            {

                string fontResourceName = "PI_CLUB_DEPORTIVO.assets.fonts.MaterialSymbolsRounded-VariableFont_FILL,GRAD,opsz,wght.ttf";
                Assembly assembly = Assembly.GetExecutingAssembly();

                using (Stream fontStream = assembly.GetManifestResourceStream(fontResourceName))
                {
                    if (fontStream != null)
                    {
                        byte[] fontData = new byte[fontStream.Length];
                        fontStream.Read(fontData, 0, (int)fontStream.Length);

                        // Crear un puntero a los datos de la fuente en memoria
                        System.IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                        System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                        privateFonts.AddMemoryFont(fontPtr, fontData.Length);

                        // Liberar la memoria asignada
                        System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                        fontsLoaded = true;
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo cargar la fuente: {fontResourceName}. Asegúrate de que está marcada como 'Embedded Resource' y la ruta es correcta.", "Error de Fuente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar fuentes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Font GetIconFont(float size, FontStyle style = FontStyle.Regular)
        {
            // Asegúrate de que las fuentes estén cargadas antes de intentar usarlas
            if (!fontsLoaded) LoadFonts();

            if (privateFonts.Families.Length > 0)
            {
                // Asume que la primera fuente cargada es la de iconos.
                // Si cargas varias, necesitarás una forma de identificarla por nombre.
                return new Font(privateFonts.Families[0], size, style);
            }
            return new Font(SystemFonts.DefaultFont.FontFamily, size, style); // Fallback
        }
    }
}
