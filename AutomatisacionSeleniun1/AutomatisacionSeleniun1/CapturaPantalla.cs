using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.HeadlessExperimental;

namespace AutomatisacionSeleniun1
{
    public class CapturaPantalla
    {
        private static string ImagePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static string TomarCapturaDePantalla(IWebDriver driver)
        {
            long milisegundos = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            string nombreArchivo = $"captura_{milisegundos}.png"; 

            string rutaCompleta = Path.Combine(ImagePath, nombreArchivo);

            Screenshot captura = ((ITakesScreenshot)driver).GetScreenshot();
            captura.SaveAsFile(rutaCompleta);

            return rutaCompleta;
        }
    }



}

