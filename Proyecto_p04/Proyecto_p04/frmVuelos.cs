using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_p04
{
    public partial class frmVuelos : Form
    {
        public frmVuelos()
        {
            InitializeComponent();
            CargarDatosEnListBoxes();
        }

        

        private void CargarDatosEnListBoxes()
        {
            lstVuelo.Items.Clear();
            lstMarca.Items.Clear();
            lstModelo.Items.Clear();

            // Agrega datos a los ListBox
            AgregarVuelos();
            AgregarMarcas();
            AgregarModelos();
        }

        private void AgregarVuelos()
        {
            lstVuelo.Items.Add("Vuelo 1 - Afganistán");
            lstVuelo.Items.Add("Vuelo 2 - Albania");
            lstVuelo.Items.Add("Vuelo 3 - Alemania");
            lstVuelo.Items.Add("Vuelo 4 - Andorra");
            lstVuelo.Items.Add("Vuelo 5 - Angola");
            lstVuelo.Items.Add("Vuelo 6 - Antigua y Barbuda");
            lstVuelo.Items.Add("Vuelo 7 - Arabia Saudita");
            lstVuelo.Items.Add("Vuelo 8 - Argelia");
            lstVuelo.Items.Add("Vuelo 9 - Argentina");
            lstVuelo.Items.Add("Vuelo 10 - Armenia");
            lstVuelo.Items.Add("Vuelo 11 - Australia");
            lstVuelo.Items.Add("Vuelo 12 - Austria");
            lstVuelo.Items.Add("Vuelo 13 - Azerbaiyán");
            lstVuelo.Items.Add("Vuelo 14 - Bahamas");
            lstVuelo.Items.Add("Vuelo 15 - Baréin");
            lstVuelo.Items.Add("Vuelo 16 - Bangladés");
            lstVuelo.Items.Add("Vuelo 17 - Barbados");
            lstVuelo.Items.Add("Vuelo 18 - Bélgica");
            lstVuelo.Items.Add("Vuelo 19 - Belice");
            lstVuelo.Items.Add("Vuelo 20 - Benín");
            lstVuelo.Items.Add("Vuelo 21 - Bielorrusia");
            lstVuelo.Items.Add("Vuelo 22 - Birmania (Myanmar)");
            lstVuelo.Items.Add("Vuelo 23 - Bolivia");
            lstVuelo.Items.Add("Vuelo 24 - Bosnia y Herzegovina");
            lstVuelo.Items.Add("Vuelo 25 - Botsuana");
            lstVuelo.Items.Add("Vuelo 26 - Brasil");
            lstVuelo.Items.Add("Vuelo 27 - Brunéi");
            lstVuelo.Items.Add("Vuelo 28 - Bulgaria");
            lstVuelo.Items.Add("Vuelo 29 - Burkina Faso");
            lstVuelo.Items.Add("Vuelo 30 - Burundi");
            lstVuelo.Items.Add("Vuelo 31 - Bután");
            lstVuelo.Items.Add("Vuelo 32 - Cabo Verde");
            lstVuelo.Items.Add("Vuelo 33 - Camboya");
            lstVuelo.Items.Add("Vuelo 34 - Camerún");
            lstVuelo.Items.Add("Vuelo 35 - Canadá");
            lstVuelo.Items.Add("Vuelo 36 - Catar");
            lstVuelo.Items.Add("Vuelo 37 - Chad");
            lstVuelo.Items.Add("Vuelo 38 - Chile");
            lstVuelo.Items.Add("Vuelo 39 - China");
            lstVuelo.Items.Add("Vuelo 40 - Chipre");
            lstVuelo.Items.Add("Vuelo 41 - Colombia");
            lstVuelo.Items.Add("Vuelo 42 - Comoras");
            lstVuelo.Items.Add("Vuelo 43 - Congo (Brazzaville)");
            lstVuelo.Items.Add("Vuelo 44 - Congo (Kinshasa)");
            lstVuelo.Items.Add("Vuelo 45 - Corea del Norte");
            lstVuelo.Items.Add("Vuelo 46 - Corea del Sur");
            lstVuelo.Items.Add("Vuelo 47 - Costa de Marfil");
            lstVuelo.Items.Add("Vuelo 48 - Croacia");
            lstVuelo.Items.Add("Vuelo 49 - Cuba");
            lstVuelo.Items.Add("Vuelo 50 - Dinamarca");
            lstVuelo.Items.Add("Vuelo 51 - Dominica");
            lstVuelo.Items.Add("Vuelo 52 - Ecuador");
            lstVuelo.Items.Add("Vuelo 53 - Egipto");
            lstVuelo.Items.Add("Vuelo 54 - El Salvador");
            lstVuelo.Items.Add("Vuelo 55 - Emiratos Árabes Unidos");
            lstVuelo.Items.Add("Vuelo 56 - Eritrea");
            lstVuelo.Items.Add("Vuelo 57 - Eslovaquia");
            lstVuelo.Items.Add("Vuelo 58 - Eslovenia");
            lstVuelo.Items.Add("Vuelo 59 - España");
            lstVuelo.Items.Add("Vuelo 60 - Estados Unidos");
            lstVuelo.Items.Add("Vuelo 61 - Estonia");
            lstVuelo.Items.Add("Vuelo 62 - Etiopía");
            lstVuelo.Items.Add("Vuelo 63 - Fiyi");
            lstVuelo.Items.Add("Vuelo 64 - Filipinas");
            lstVuelo.Items.Add("Vuelo 65 - Finlandia");
            lstVuelo.Items.Add("Vuelo 66 - Francia");
            lstVuelo.Items.Add("Vuelo 67 - Gabón");
            lstVuelo.Items.Add("Vuelo 68 - Gambia");
            lstVuelo.Items.Add("Vuelo 69 - Georgia");
            lstVuelo.Items.Add("Vuelo 70 - Ghana");
            lstVuelo.Items.Add("Vuelo 71 - Granada");
            lstVuelo.Items.Add("Vuelo 72 - Grecia");
            lstVuelo.Items.Add("Vuelo 73 - Guatemala");
            lstVuelo.Items.Add("Vuelo 74 - Guinea");
            lstVuelo.Items.Add("Vuelo 75 - Guinea-Bisáu");
            lstVuelo.Items.Add("Vuelo 76 - Guinea Ecuatorial");
            lstVuelo.Items.Add("Vuelo 77 - Guayana");
            lstVuelo.Items.Add("Vuelo 78 - Haití");
            lstVuelo.Items.Add("Vuelo 79 - Honduras");
            lstVuelo.Items.Add("Vuelo 80 - Hungría");
            lstVuelo.Items.Add("Vuelo 81 - India");
            lstVuelo.Items.Add("Vuelo 82 - Indonesia");
            lstVuelo.Items.Add("Vuelo 83 - Irak");
            lstVuelo.Items.Add("Vuelo 84 - Irán");
            lstVuelo.Items.Add("Vuelo 85 - Irlanda");
            lstVuelo.Items.Add("Vuelo 86 - Islandia");
            lstVuelo.Items.Add("Vuelo 87 - Islas Marshall");
            lstVuelo.Items.Add("Vuelo 88 - Islas Salomón");
            lstVuelo.Items.Add("Vuelo 89 - Israel");
            lstVuelo.Items.Add("Vuelo 90 - Italia");
            lstVuelo.Items.Add("Vuelo 91 - Jamaica");
            lstVuelo.Items.Add("Vuelo 92 - Japón");
            lstVuelo.Items.Add("Vuelo 93 - Jordania");
            lstVuelo.Items.Add("Vuelo 94 - Kazajistán");
            lstVuelo.Items.Add("Vuelo 95 - Kenia");
            lstVuelo.Items.Add("Vuelo 96 - Kirguistán");
            lstVuelo.Items.Add("Vuelo 97 - Kiribati");
            lstVuelo.Items.Add("Vuelo 98 - Kuwait");
            lstVuelo.Items.Add("Vuelo 99 - Laos");
            lstVuelo.Items.Add("Vuelo 100 - Lesoto");
            lstVuelo.Items.Add("Vuelo 101 - Letonia");
            lstVuelo.Items.Add("Vuelo 102 - Líbano");
            lstVuelo.Items.Add("Vuelo 103 - Liberia");
            lstVuelo.Items.Add("Vuelo 104 - Libia");
            lstVuelo.Items.Add("Vuelo 105 - Liechtenstein");
            lstVuelo.Items.Add("Vuelo 106 - Lituania");
            lstVuelo.Items.Add("Vuelo 107 - Luxemburgo");
            lstVuelo.Items.Add("Vuelo 108 - Macedonia del Norte");
            lstVuelo.Items.Add("Vuelo 109 - Madagascar");
            lstVuelo.Items.Add("Vuelo 110 - Malasia");
            lstVuelo.Items.Add("Vuelo 111 - Malaui");
            lstVuelo.Items.Add("Vuelo 112 - Maldivas");
            lstVuelo.Items.Add("Vuelo 113 - Malí");
            lstVuelo.Items.Add("Vuelo 114 - Malta");
            lstVuelo.Items.Add("Vuelo 115 - Marruecos");
            lstVuelo.Items.Add("Vuelo 116 - Mauricio");
            lstVuelo.Items.Add("Vuelo 117 - Mauritania");
            lstVuelo.Items.Add("Vuelo 118 - México");
            lstVuelo.Items.Add("Vuelo 119 - Micronesia");
            lstVuelo.Items.Add("Vuelo 120 - Moldavia");
            lstVuelo.Items.Add("Vuelo 121 - Mónaco");
            lstVuelo.Items.Add("Vuelo 122 - Mongolia");
            lstVuelo.Items.Add("Vuelo 123 - Montenegro");
            lstVuelo.Items.Add("Vuelo 124 - Mozambique");
            lstVuelo.Items.Add("Vuelo 125 - Namibia");
            lstVuelo.Items.Add("Vuelo 126 - Nauru");
            lstVuelo.Items.Add("Vuelo 127 - Nepal");
            lstVuelo.Items.Add("Vuelo 128 - Nicaragua");
            lstVuelo.Items.Add("Vuelo 129 - Níger");
            lstVuelo.Items.Add("Vuelo 130 - Nigeria");
            lstVuelo.Items.Add("Vuelo 131 - Noruega");
            lstVuelo.Items.Add("Vuelo 132 - Nueva Zelanda");
            lstVuelo.Items.Add("Vuelo 133 - Omán");
            lstVuelo.Items.Add("Vuelo 134 - Paises Bajos");
            lstVuelo.Items.Add("Vuelo 135 - Pakistán");
            lstVuelo.Items.Add("Vuelo 136 - Palaos");
            lstVuelo.Items.Add("Vuelo 137 - Panamá");
            lstVuelo.Items.Add("Vuelo 138 - Papúa Nueva Guinea");
            lstVuelo.Items.Add("Vuelo 139 - Paraguay");
            lstVuelo.Items.Add("Vuelo 140 - Perú");
            lstVuelo.Items.Add("Vuelo 141 - Polonia");
            lstVuelo.Items.Add("Vuelo 142 - Portugal");
            lstVuelo.Items.Add("Vuelo 143 - Reino Unido");
            lstVuelo.Items.Add("Vuelo 144 - República Centroafricana");
            lstVuelo.Items.Add("Vuelo 145 - República Checa");
            lstVuelo.Items.Add("Vuelo 146 - República Dominicana");
            lstVuelo.Items.Add("Vuelo 147 - Ruanda");
            lstVuelo.Items.Add("Vuelo 148 - Rumanía");
            lstVuelo.Items.Add("Vuelo 149 - Rusia");
            lstVuelo.Items.Add("Vuelo 150 - Samoa");
            lstVuelo.Items.Add("Vuelo 151 - San Cristóbal y Nieves");
            lstVuelo.Items.Add("Vuelo 152 - San Marino");
            lstVuelo.Items.Add("Vuelo 153 - Santa Lucía");
            lstVuelo.Items.Add("Vuelo 154 - Santo Tomé y Príncipe");
            lstVuelo.Items.Add("Vuelo 155 - San Vicente y las Granadinas");
            lstVuelo.Items.Add("Vuelo 156 - Senegal");
            lstVuelo.Items.Add("Vuelo 157 - Serbia");
            lstVuelo.Items.Add("Vuelo 158 - Seychelles");
            lstVuelo.Items.Add("Vuelo 159 - Sierra Leona");
            lstVuelo.Items.Add("Vuelo 160 - Singapur");
            lstVuelo.Items.Add("Vuelo 161 - Siria");
            lstVuelo.Items.Add("Vuelo 162 - Somalia");
            lstVuelo.Items.Add("Vuelo 163 - Sri Lanka");
            lstVuelo.Items.Add("Vuelo 164 - Suazilandia");
            lstVuelo.Items.Add("Vuelo 165 - Sudáfrica");
            lstVuelo.Items.Add("Vuelo 166 - Sudán");
            lstVuelo.Items.Add("Vuelo 167 - Sudán del Sur");
            lstVuelo.Items.Add("Vuelo 168 - Suecia");
            lstVuelo.Items.Add("Vuelo 169 - Suiza");
            lstVuelo.Items.Add("Vuelo 170 - Surinam");
            lstVuelo.Items.Add("Vuelo 171 - Tailandia");
            lstVuelo.Items.Add("Vuelo 172 - Taiwán");
            lstVuelo.Items.Add("Vuelo 173 - Tanzania");
            lstVuelo.Items.Add("Vuelo 174 - Tayikistán");
            lstVuelo.Items.Add("Vuelo 175 - Timor Oriental");
            lstVuelo.Items.Add("Vuelo 176 - Togo");
            lstVuelo.Items.Add("Vuelo 177 - Tonga");
            lstVuelo.Items.Add("Vuelo 178 - Trinidad y Tobago");
            lstVuelo.Items.Add("Vuelo 179 - Túnez");
            lstVuelo.Items.Add("Vuelo 180 - Turkmenistán");
            lstVuelo.Items.Add("Vuelo 181 - Turquía");
            lstVuelo.Items.Add("Vuelo 182 - Tuvalu");
            lstVuelo.Items.Add("Vuelo 183 - Ucrania");
            lstVuelo.Items.Add("Vuelo 184 - Uganda");
            lstVuelo.Items.Add("Vuelo 185 - Uruguay");
            lstVuelo.Items.Add("Vuelo 186 - Uzbekistán");
            lstVuelo.Items.Add("Vuelo 187 - Vanuatu");
            lstVuelo.Items.Add("Vuelo 188 - Vaticano");
            lstVuelo.Items.Add("Vuelo 189 - Venezuela");
            lstVuelo.Items.Add("Vuelo 190 - Vietnam");
            lstVuelo.Items.Add("Vuelo 191 - Yemen");
            lstVuelo.Items.Add("Vuelo 192 - Yibuti");
            lstVuelo.Items.Add("Vuelo 193 - Zambia");
            lstVuelo.Items.Add("Vuelo 194 - Zimbabue");
        }

        private void AgregarMarcas()
        {
            lstMarca.Items.Add("Boeing");
            lstMarca.Items.Add("Airbus");
            lstMarca.Items.Add("Embraer");
            lstMarca.Items.Add("Bombardier");
            lstMarca.Items.Add("Cessna");
            lstMarca.Items.Add("Dassault");
            lstMarca.Items.Add("Fokker");
            lstMarca.Items.Add("Gulfstream");
            lstMarca.Items.Add("Hawker");
            lstMarca.Items.Add("Lockheed Martin");
            lstMarca.Items.Add("McDonnell Douglas");
            lstMarca.Items.Add("Piper");
            lstMarca.Items.Add("Saab");
            lstMarca.Items.Add("Sukhoi");
            lstMarca.Items.Add("Tupolev");
            lstMarca.Items.Add("Antonov");
            lstMarca.Items.Add("Beechcraft");
            lstMarca.Items.Add("Emivest Aerospace");
            lstMarca.Items.Add("Ilyushin");
            lstMarca.Items.Add("KAI");
        }

        private void AgregarModelos()
        {
            
        }

        public void ActualizarMArca()
        {
            if (lstMarca.SelectedItem == "Boeing")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("737");
                lstModelo.Items.Add("747");
                lstModelo.Items.Add("767");
                lstModelo.Items.Add("777");
                lstModelo.Items.Add("787 Dreamliner");

                string imageUrl = "https://www.pngall.com/wp-content/uploads/5/Flying-Aeroplane-PNG-Clipart.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }


            }
            if (lstMarca.SelectedItem == "Airbus")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("a320");
                lstModelo.Items.Add("a330");
                lstModelo.Items.Add("a350");
                lstModelo.Items.Add("a380");


                string imageUrl = "https://www.pngmart.com/files/6/Airbus-PNG-Photos.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                           // Mostrar la imagen en el PictureBox
                           pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }



            }
            if (lstMarca.SelectedItem == "Embraer")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("E-Jet E2");
                lstModelo.Items.Add("ERJ 145");
                lstModelo.Items.Add("Phenom 300");

                string imageUrl = "https://patriotaviation.mx/wp-content/uploads/2020/08/PHENOM300-2.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Bombardier")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("Serie CRJ");
                lstModelo.Items.Add("Global Express");
                lstModelo.Items.Add("Serie Challenger de Bombardier");

                string imageUrl = "https://uploads-ssl.webflow.com/5efdba023305d23112eed72e/5f905ea1dfc7479755d11312_portfolio_item_global6000_2.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }



            }
            if (lstMarca.SelectedItem == "Cessna")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("172");
                lstModelo.Items.Add("208 caravana");
                lstModelo.Items.Add("Serie de citas de Cessna");

                string imageUrl = "https://www.aerolineasejecutivas.com/static/fab1ccabdcbbb62914a7ce0925c5f1c3/ee604/thumbnail.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Dassault")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("Rafale");
                lstModelo.Items.Add("Serie Dassault Falcon");

                string imageUrl = "https://globaljet.aero/sites/default/files/2023-03/Exterior%20for%20Web_better%20quality.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Fokker")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("F27 Amistad");
                lstModelo.Items.Add("F50");

                string imageUrl = "https://flyings.net/images/aircraft/V3_.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Gulfstream")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("G550");
                lstModelo.Items.Add("G650");

                string imageUrl = "https://businessaircraft.bombardier.com/sites/default/files/2018-05/DDBA0457_Global7500_RightSide_V1.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }


            }




            if (lstMarca.SelectedItem == "Hawker")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("4000");
                lstModelo.Items.Add("800");

                string imageUrl = "https://patriotaviation.mx/wp-content/uploads/2020/08/HAWKER700-1.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }


            }
            if (lstMarca.SelectedItem == "Lockheed Martin")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("F-22 Raptor");
                lstModelo.Items.Add("C-130 Hércules");

                string imageUrl = "https://w7.pngwing.com/pngs/706/600/png-transparent-airplane-fighter-aircraft-lockheed-p-3-orion-helicopter-air-force-airplane-fighter-aircraft-airplane-helicopter.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "McDonnell Douglas")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("MD-80");
                lstModelo.Items.Add("F/A-18");

                string imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/McDonnell_Douglas_DC-10.svg/1280px-McDonnell_Douglas_DC-10.svg.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Piper")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("PA-28 Cherokee");
                lstModelo.Items.Add("PA-34 Séneca");

                string imageUrl = "https://www.sud-rc.fr/img/cms/Avion/PIPER-PA-38-TOMAHAWK-1830mm-ARF-Jamara-012150.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }


            }
            if (lstMarca.SelectedItem == "Saab")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("JAS 39 Gripen");

                string imageUrl = "https://www.swiftair.com/wp-content/uploads/2018/04/EMB120.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }


            }
            if (lstMarca.SelectedItem == "Sujoi")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("Su-27");
                lstModelo.Items.Add("Su-35");

                string imageUrl = "https://4.bp.blogspot.com/-oC7yrVYZTQM/T8d-XwJdBdI/AAAAAAAAD54/HrDmTfxuOaI/s1600/Sukhoi+Superjet+100.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Tupolev")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("Tu-154");
                lstModelo.Items.Add("Tu-204");

                string imageUrl = "https://www.aviationtoday.com/wp-content/uploads/2016/12/368_image.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Antonov")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("An-124 Ruslán");
                lstModelo.Items.Add("An-225 Mriya");

                string imageUrl = "https://www.avico.com/wp-content/uploads/2021/12/an225.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Beechcraft")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("Serie King Air ");
                lstModelo.Items.Add("Bonanza");

                string imageUrl = "https://www.aerolineasejecutivas.com/static/0dfcfcb0b10cd69fe7cd3271210fc8b4/ee604/thumbnail.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }


            }
            if (lstMarca.SelectedItem == "Emivest Aerospace")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("SJ30");

                string imageUrl = "https://w7.pngwing.com/pngs/969/875/png-transparent-bombardier-challenger-600-series-flight-aircraft-syberjet-sj30-air-travel-aircraft-mode-of-transport-flight-airplane.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "Ilyushin")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("Il-76");
                lstModelo.Items.Add("Il-96");

                string imageUrl = "https://www.avico.com/wp-content/uploads/2021/12/maxresdefault-removebg-preview.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }

            }
            if (lstMarca.SelectedItem == "KAI")
            {
                lstModelo.Items.Clear();

                lstModelo.Items.Add("T-50 Águila Dorada");
                lstModelo.Items.Add(" KF-X ");


                string imageUrl = "https://www.swiftair.com/wp-content/uploads/2018/01/ATR42.png"; // Obtener el enlace de la imagen desde el cuadro de texto

                try
                {
                    // Descargar la imagen desde el enlace
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageBytes = webClient.DownloadData(imageUrl);
                        using (var stream = new System.IO.MemoryStream(imageBytes))
                        {
                            // Mostrar la imagen en el PictureBox
                            pbAviones.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }






        private void btnVerVuelos_Click_1(object sender, EventArgs e)
        {
            if (lstVuelo.SelectedItem != null && lstMarca.SelectedItem != null && lstModelo.SelectedItem != null)
            {
                if (cbescala.Checked)
                {
                    string vueloSeleccionado = lstVuelo.SelectedItem.ToString();
                    string marcaSeleccionada = lstMarca.SelectedItem.ToString();
                    string modeloSeleccionado = lstModelo.SelectedItem.ToString();
                    
                    txtVueloSeleccionado.Text = $"{vueloSeleccionado}{",(Vuelo Directo)"} - {marcaSeleccionada} - {modeloSeleccionado}";

                }
                else
                {
                    string vueloSeleccionado = lstVuelo.SelectedItem.ToString();
                    string marcaSeleccionada = lstMarca.SelectedItem.ToString();
                    string modeloSeleccionado = lstModelo.SelectedItem.ToString();
                    string Escala = cbPaises.SelectedItem.ToString();
                    txtVueloSeleccionado.Text = $"{vueloSeleccionado}{",(Escala: " + Escala + ")"} - {marcaSeleccionada} - {modeloSeleccionado}";

                }

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vuelo, una marca y un modelo antes de hacer clic en 'Seleccionar'.");
            }
        }

        private void lstModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarMArca();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los datos?", "Confirmar Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Para guardar los datos de los dateTimePicker
                    txtSalida.Text = dateTimePicker1.Text;
                    txtLLegada.Text = dateTimePicker2.Text;



                    //Codigo Guardar
                    conexionBD.conectarBD();
                    string insertar = "INSERT INTO tbl_vuelos(Estado,Destino,Piloto,Aerolinea,HoraSalida,HoraLlegada,EstadoV,Escala) VALUES(@Estado,@Destino,@Piloto,@Aerolinea,@HoraSalida,@HoraLlegada,@EstadoV,@Escala)";
                    SqlCommand cmd = new SqlCommand(insertar, conexionBD.conectarBD());

                    cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@Destino", txtVueloSeleccionado.Text);
                    cmd.Parameters.AddWithValue("@Piloto", txtpiloto.Text);
                    cmd.Parameters.AddWithValue("@Aerolinea", txtAerolinea.Text);
                    cmd.Parameters.AddWithValue("@HoraSalida", txtSalida.Text);
                    cmd.Parameters.AddWithValue("@HoraLlegada", txtLLegada.Text);
                    cmd.Parameters.AddWithValue("@EstadoV", cbEstadoV.SelectedItem);
                    cmd.Parameters.AddWithValue("@Escala", txtescala.Text);

                    int resulta = cmd.ExecuteNonQuery();
                    if (resulta == 0)
                    {
                        MessageBox.Show("Hcaen falta datos");
                    }
                    


                    MessageBox.Show("Los datosfueron agregados de forma exitosa!!!");
                    dataGridView1.DataSource = LLenar_grid1();

                    MessageBox.Show("Datos guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hcaen falta datos, por favor verificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void frmVuelos_Load(object sender, EventArgs e)
        {
            conexionBD.conectarBD();
            MessageBox.Show("Conexion Exitosa!!!");
            dataGridView1.DataSource = LLenar_grid1();
            dataGridView2.DataSource = LLenar_grid2();
            dataGridView3.DataSource = LLenar_grid3();
            paises();
            


        }

       



        public DataTable LLenar_grid1()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_vuelos"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable LLenar_grid2()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_pilotos"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable LLenar_grid3()
        {
            //se llena el grid con la tabla de aerolina

            conexionBD.conectarBD();
            DataTable dt = new DataTable();
            string consultar = "SELECT * FROM tbl_aerolineas"; //Crear la tabla en BD para lenar el grid
            SqlCommand cmd = new SqlCommand(consultar, conexionBD.conectarBD());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea aplicar los cambios?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Para guardar los datos de los dateTimePicker
                    txtSalida.Text = dateTimePicker1.Text;
                    txtLLegada.Text = dateTimePicker2.Text;


                    //Codigo Modificar
                    conexionBD.conectarBD();
                    string actualizar = "UPDATE tbl_vuelos SET  Estado=@Estado,Destino=@Destino,Piloto=@Piloto,Aerolinea=@Aerolinea,HoraSalida=@HoraSalida,HoraLlegada=@HoraLlegada,EstadoV=@EstadoV,Escala=@Escala WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(actualizar, conexionBD.conectarBD());

                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@Destino", txtVueloSeleccionado.Text);
                    cmd.Parameters.AddWithValue("@Piloto", txtpiloto.Text);
                    cmd.Parameters.AddWithValue("@Aerolinea", txtAerolinea.Text);
                    cmd.Parameters.AddWithValue("@HoraSalida", txtSalida.Text);
                    cmd.Parameters.AddWithValue("@HoraLlegada", txtLLegada.Text);
                    cmd.Parameters.AddWithValue("@EstadoV", cbEstadoV.SelectedItem);
                    cmd.Parameters.AddWithValue("@Escala", txtescala.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos fueron cambiados de forma exitosa!!!");

                    MessageBox.Show("Cambios aplicados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = LLenar_grid1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar los datos?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Codigo Eliminar
                    conexionBD.conectarBD();
                    string eliminar = "DELETE FROM tbl_vuelos WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(eliminar, conexionBD.conectarBD());

                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datosfueron Eliminados!!!");

                    MessageBox.Show("Datos eliminados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = LLenar_grid1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, debe selecionar la ID que desea Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea limpiar los datos?", "Confirmar Limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    limpiar_txt();

                    MessageBox.Show("Datos limpiados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiar_txt()
        {
            
            txtEstado.Clear();
            txtId.Clear();
            txtVueloSeleccionado.Clear();
            txtpiloto.Clear();
            txtAerolinea.Clear();
            txtSalida.Clear();
            txtLLegada.Clear();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtVueloSeleccionado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtpiloto.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAerolinea.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSalida.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtLLegada.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtescala.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpiloto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAerolinea.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        

        public void paises()
        {
            DataTable dt = new DataTable();
            cbPaises.ValueMember = "id";
            cbPaises.DisplayMember = "pais";
            cbPaises.Items.Insert(0, " - Seleccione Nacionalidad");
            dt = Clases.pilotosDAL.getPaises();
            int i = 0;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    cbPaises.Items.Insert(Convert.ToInt32(dt.Rows[i]["id"]), dt.Rows[i]["nombre"].ToString());
                    i++;
                }
            }
        }

        private void cbescala_CheckedChanged(object sender, EventArgs e)
        {

           if(cbescala.Checked)
            {
                cbPaises.SelectedItem = "Seleccione Escala";
                cbPaises.Enabled = true;
                txtescala.Text = "1";
            }
            else
            {
                cbPaises.SelectedItem = "No Escala";
                cbPaises.Enabled = false;
                txtescala.Text = "0";
            }
        }
    }
}
    

