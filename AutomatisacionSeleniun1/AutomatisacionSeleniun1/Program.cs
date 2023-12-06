using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomatisacionSeleniun1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configurar el navegador Chrome
            IWebDriver driver = new FirefoxDriver();

            //Abre el navegador Firefox y introdice la url de Mi pagina en el localhost
            driver.Navigate().GoToUrl("http://localhost/biblioteca/member/");
           
            //Maximisa la pagina
            driver.Manage().Window.Maximize();
            CapturaPantalla.TomarCapturaDePantalla(driver);
           
            //Register 
            driver.Navigate().GoToUrl("http://localhost/biblioteca/member/register.php");
            //introducir datos de registro
            driver.FindElement(By.Name("m_user")).SendKeys("Otto555");
            driver.FindElement(By.Name("m_pass")).SendKeys("12345");
            driver.FindElement(By.Name("m_name")).SendKeys("Otto Rafael Gonzalez Contreras");
            driver.FindElement(By.Name("m_email")).SendKeys("20220121@itla.edo.do");
            driver.FindElement(By.Name("m_balance")).SendKeys("10000");
            CapturaPantalla.TomarCapturaDePantalla(driver);
            driver.FindElement(By.Name("m_register")).Click();
            CapturaPantalla.TomarCapturaDePantalla(driver);

            //Perfil 1 no creado en la pagina
            //login 
            driver.Navigate().GoToUrl("http://localhost/biblioteca/member/");
            //introduce las credenciales de el usuario
            driver.FindElement(By.Name("m_user")).SendKeys("Ottorafael");
            driver.FindElement(By.Name("m_pass")).SendKeys("6666666");
            CapturaPantalla.TomarCapturaDePantalla(driver);


            //Hace click en el boton de Ingresar 
            driver.FindElement(By.Name("m_login")).Click();

            //Perfil 2 no creado en la pagina
            //login 
            driver.Navigate().GoToUrl("http://localhost/biblioteca/member/");
            //introduce las credenciales de el usuario
            driver.FindElement(By.Name("m_user")).SendKeys("Ottorafael675");
            driver.FindElement(By.Name("m_pass")).SendKeys("6666662226");
            CapturaPantalla.TomarCapturaDePantalla(driver);

            //Hace click en el boton de Ingresar 
            driver.FindElement(By.Name("m_login")).Click();


            //Perfil 3
            //login 
            driver.Navigate().GoToUrl("http://localhost/biblioteca/member/");
            //introduce las credenciales de el usuario
            driver.FindElement(By.Name("m_user")).SendKeys("Otto555");
            driver.FindElement(By.Name("m_pass")).SendKeys("12345");

            CapturaPantalla.TomarCapturaDePantalla(driver);
            //Hace click en el boton de Ingresar 
            driver.FindElement(By.Name("m_login")).Click();
            CapturaPantalla.TomarCapturaDePantalla(driver);

            //cerrar Secion 
            driver.Navigate().GoToUrl("http://localhost/biblioteca../logout.php");


            //Perfil 4
            //login 
            driver.Navigate().GoToUrl("http://localhost/biblioteca/member/");
            //introduce las credenciales de el usuario
            driver.FindElement(By.Name("m_user")).SendKeys("OttoG123");
            driver.FindElement(By.Name("m_pass")).SendKeys("12345");
            CapturaPantalla.TomarCapturaDePantalla(driver);
            //Hace click en el boton de Ingresar 
            driver.FindElement(By.Name("m_login")).Click();
            CapturaPantalla.TomarCapturaDePantalla(driver);

            //cerrando el navegador
            driver.Close();

         

          





        }



    }


}
