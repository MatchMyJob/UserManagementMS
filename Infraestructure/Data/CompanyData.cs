using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public static class CompanyData
    {
        public static void SeedData(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    CompanyId = Guid.Parse("ecdb5eda-1cee-4e68-b100-160203158d57"),
                    CUIT = "203454354455",
                    Phone = "54-1132394831",
                    BusinessName = "Accenture",
                    BusinessSector = "Business Consulting and Services",
                    Website = "https://www.accenture.com",
                    MinimalDescription = "Transformamos los desafíos de nuestros clientes con soluciones innovadoras",
                    Description = "Accenture is a leading global professional services company that helps the world’s leading businesses, governments and other organizations build their digital core, optimize their operations, accelerate revenue growth and enhance citizen services—creating tangible value at speed and scale.\r\n\r\nWe are a talent and innovation-led company serving clients in more than 120 countries. Technology is at the core of change today, and we are one of the world’s leaders in helping drive that change, with strong ecosystem relationships. We combine our strength in technology and leadership in cloud, data and AI with unmatched industry experience, functional expertise and global delivery capability. We are uniquely able to deliver tangible outcomes because of our broad range of services, solutions and assets across Strategy & Consulting, Technology, Operations, Industry X and Song.\r\n\r\nThese capabilities, together with our culture of shared success and commitment to creating 360° value, enable us to help our clients reinvent and build trusted, lasting relationships. We measure our success by the 360° value we create for our clients, each other, our shareholders, partners and communities.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/D4E0BAQGs35w9Fb-nnw/company-logo_200_200/0/1717212681869/accenture_logo?e=1725494400&v=beta&t=awvmpU6rBmgQT8hES8WXnH5oJY8xrUZS2ybi7cSPK8Y",
                    FrontPage = "https://thebrandhopper.com/wp-content/uploads/2020/11/Accenture-PowerPoint-Presentation-Slide-Examples-1.jpg",
                    Founded = 1989,
                    CityId = 60763,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("d51252c3-6e21-4ffc-aab3-f4bda791a574"),
                    CUIT = "203444754455",
                    Phone = "54-1134596831",
                    BusinessName = "Mercado Libre",
                    BusinessSector = "Internet Publishing",
                    Website = "https://careers-meli.mercadolibre.com",
                    MinimalDescription = "Co-creando uno de los mejores lugares para trabajar del mundo",
                    Description = "Founded in 1999 and headquartered in Buenos Aires, Argentina, Mercado Libre is Latin America’s leading e-commerce technology company.  Through its primary platforms, MercadoLibre.com and MercadoPago.com, it provides solutions to individuals and companies buying, selling, advertising, and paying for goods online.    \r\nMercado Libe serves millions of users and creates a market for a wide variety of goods and services in an easy, safe and efficient way.  \r\nMercadoLibre maintains a leadership position in 18 Latin American countries.  The Company listed on Nasdaq (NASDAQ: MELI) following its initial public offering in 2007.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/D4D0BAQGAMFztKl2_oA/company-logo_200_200/0/1711465281298/mercadolibre_logo?e=1725494400&v=beta&t=wZGETBiUWUr7U1cGXRs7KDl6hwtW_EBRI5D5Rbqtum0",
                    FrontPage = "https://static.eldiario.es/clip/b72e0e08-837c-441b-a198-89e857a50b40_16-9-discover-aspect-ratio_default_0.jpg",
                    Founded = 2001,
                    CityId = 60763,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("925b2ab6-5a03-40a7-891e-7bb594086e61"),
                    CUIT = "202254354455",
                    Phone = "54-1152540027",
                    BusinessName = "Enta Consulting",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "http://www.entaconsulting.com",
                    MinimalDescription = "Potenciamos la eficiencia aplicando nuevas tecnologías para optimizar los procesos y la información de su empresa",
                    Description = "Enta Consulting es una empresa especializada en la creación de soluciones de automatización de procesos de negocios y desarrollo de software aplicando combinaciones únicas de tecnología, metodologías e información. Potenciamos la eficiencia de nuestros clientes simplificando su acceso a las oportunidades que ofrece el mundo digital. Somos especialistas en RPA (Robotic Process Automation)  \r\n\r\nEnta está formado por un equipo de personas que cada día aportan su pasión, conocimiento y experiencia para resolver las necesidades que nos plantean nuestros clientes. Estamos orgullosos de poder decir que trabajamos en un ambiente donde cada uno puede ser quien es, donde hay aprendizaje continuo, oportunidades de desarrollo, y donde se destaca la colaboración entre todos los colegas a lo largo de la organización. Esto nos llevó a alcanzar, a finales de 2022, la certificación Great Place To Work como un gran lugar para trabajar en Argentina.",
                    WorkerQuantity = 500,
                    Logo = "https://pbs.twimg.com/profile_images/875782274809294848/MKvtWStg_400x400.jpg",
                    FrontPage = "https://www.entaconsulting.com/wp-content/uploads/ENTA-BLOG-34-1080x675.png",
                    Founded = 2011,
                    CityId = 60028,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("9d8b9e84-33a7-4c28-a6c0-5941a68f1968"),
                    CUIT = "202044354455",
                    Phone = "54-1152541027",
                    BusinessName = "ADN - Recursos Humanos",
                    BusinessSector = "Human Resources Services",
                    Website = "http://www.adnrh.com.ar",
                    MinimalDescription = "Buscamos tu GENte",
                    Description = "ADN - BUSCAMOS EL PERSONAL PARA SU EMPRESA\r\n\r\n- Búsqueda y Selección de Personal - Psicotécnicos - Liquidación de Sueldos - Outsourcing. \r\n- Auditoría / Consultoría- Capacitación.\r\n\r\nADN - Recursos Humanos - Somos La Consultora especializada en Recursos Humanos.\r\n\r\n- No cobramos anticipo.\r\n- No pedimos exclusividad.\r\n- Si se cancela la búsqueda, no cobramos NADA.\r\n- El servicio incluye una garantía.\r\n. \r\n- Más de 80.000 Currículums, actualizados permanentemente.\r\n- Trabajamos bajo estándares internacionales de calidad, alineados a los requerimientos de la norma SGC ISO 9001:2008 (sistema de gestión de la calidad).",
                    WorkerQuantity = 200,
                    Logo = "https://d2q79iu7y748jz.cloudfront.net/s/_squarelogo/186ea7f184211b827e377b130fb08c67",
                    FrontPage = "https://media-exp2.licdn.com/dms/image/C4D1BAQFSKaQZH-v7LA/company-background_10000/0/1542331321131?e=2147483647&v=beta&t=a3Pg2kHnQF5a7WHQcwUFyr5TpynnIeVaIyfrCr-oKbw",
                    Founded = 2014,
                    CityId = 60490,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("09260ec0-0368-4da8-80d5-6e8b9c574920"),
                    CUIT = "203354354455",
                    Phone = "54-1177003233",
                    BusinessName = "QUICKPASS - Tiempo y Asistencia",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "https://quickpassweb.com",
                    MinimalDescription = "Ayudamos a las empresas a gestionar el Tiempo, Asistencia y Novedades de los colaboradores.",
                    Description = "Somos una empresa que brinda soluciones de identificación y reconocimiento de personas. Brindamos soluciones para la administración de la asistencia y el tiempo del personal mediante reconocimiento biométrico. Nuestras soluciones están especialmente diseñadas para cadenas de Retail, Pymes y grandes empresas con personal disperso que requieran la información consolidada y centralizada.\r\n\r\nCon más de 10 años de experiencia en el mercado somos la empresa líder en nuestro rubro. Hoy en día trabajamos con más de 300 clientes en Argentina, Chile, Colombia y México.\r\n\r\nQuickPass, empresa proveedora de soluciones IT que incorpora la tecnología Biometrica para minimizar el fraude y maximizar el control en la identificación de los individuos.\r\n\r\nUsos: Control Horario, Control de Accesos, Autorización de transacciones, Reconocimiento de Personas, Sistema de Fidelización, Comedores y mucho mas.\r\n\r\nSpecialties : Time & Attendance, Access Control, Transaction Authorization, Self-service, Customer Loyalty, and more.",
                    WorkerQuantity = 50,
                    Logo = "https://media.licdn.com/dms/image/D560BAQFNEnZ9T3JTmA/company-logo_200_200/0/1689863298510/quickpass_logo?e=1725494400&v=beta&t=vyjvfV67ygo-smaFzK58153ShIjSWoWcDR8HPSzdNfw",
                    FrontPage = "https://eu-images.contentstack.com/v3/assets/blt0bbd1b20253587c0/bltdf11df31e8399c48/651407a3b5e3e2567bb533c1/GettyImages-cybersecurity1400359666.png?width=850&auto=webp&quality=95&format=jpg&disable=upscale",
                    Founded = 2011,
                    CityId = 60441,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("a3fb7e92-6b31-4630-835c-3ea7d11e4306"),
                    CUIT = "202464354455",
                    Phone = "54-1136932646",
                    BusinessName = "Data108",
                    BusinessSector = "Software Development",
                    Website = "https://data108.com",
                    MinimalDescription = "We offer WordPress, Software Development, Web Development, Mobile Development, Desktop Development, Automation & API",
                    Description = "Data108 is a full-service digital agency located in South Florida.\r\n\r\nWe are a team of professional designers, developers, marketers and IT specialists combining our knowledge and expertise to create exceptional designs and strategies, tailored to your business’s needs and requirements.\r\n\r\nTell us about your goal and we’ll show you how you can achieve it. No matter what your project is, we’d love to be involved.",
                    WorkerQuantity = 10,
                    Logo = "https://media.licdn.com/dms/image/D4E0BAQHxTsTuH2BBGg/company-logo_200_200/0/1695671742793/data108_logo?e=1725494400&v=beta&t=Eh5WgQxCPa826LZ-VlhkEVmoQ9CFCZ62FthcuWqsX8c",
                    FrontPage = "https://www.itrixbox.com/storage/portada-software-esp.jpg",
                    Founded = 2015,
                    CityId = 60434,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("02bdfba1-5d7d-46f8-89c7-5d02a5fc7655"),
                    CUIT = "202154354455",
                    Phone = "54-1152540427",
                    BusinessName = "Accusys Technology",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "http://www.accusys.com.ar",
                    MinimalDescription = "Transformamos los desafíos de nuestros clientes con soluciones innovadoras.",
                    Description = "Accusys Technology, es  líder en el desarrollo y mantenimiento de aplicaciones de software para la innovación, gestión y mayor productividad de los procesos de negocios.\r\nLa compañía, posee  amplia experiencia en el área de servicios financieros en América Latina, con un fuerte foco en el mercado de Banca y Seguros. \r\n\r\nAccusys Technology cuenta con una amplia gama de productos y servicios informáticos, cuyos diseños permiten satisfacer las distintas necesidades y  requerimientos corporativos.\r\nEntre sus principales productos se encuentran el Core Bancario COBIS,  COE para el Control Optimo de Efectivo, y  para la planificación y ejecución de procesos el producto AST PROBATCH.\r\n\r\nLa  empresa cuenta con un equipo de más de 300 profesionales altamente capacitados, que contribuyen con su trabajo y sus competencias profesionales a la mejora continua e innovación en las organizaciones.  \r\nAccusys Technology cuenta con filiales en Venezuela, Bolivia, Estados Unidos y Argentina, la empresa posee un Centro de desarrollo en Buenos Aires.\r\n\r\nAccusys Technology brinda los siguientes servicios:\r\n\r\n•\tConsultoría: brinda consultoría en diseño, desarrollo e  implantación de Soluciones de software, como también consultoría en procesos.\r\n\r\n•\tMantenimiento Aplicaciones: Mantenimiento Correctivo, Normativo, Evolutivo/Proyecto, para soluciones de misión critica. Soporte 7 x 24.\r\n\r\n•\tTesting: Probadas Metodologías para la verificación de la calidad del software e identificación de fallos en su implementación, calidad, o usabilidad.\r\n\r\n•\tSoftware Factory: la compañía desarrolla aplicaciones específicas con alta consistencia en la calidad del código.",
                    WorkerQuantity = 500,
                    Logo = "https://media.licdn.com/dms/image/C4D0BAQGYiIk7JYRxLg/company-logo_200_200/0/1631332444066?e=2147483647&v=beta&t=or7qa3YYF2QvfIBAr6UJduaW4fA2oyfpuoYavXcls6A",
                    FrontPage = "https://media-exp1.licdn.com/dms/image/C561BAQFcz2R8heFjxw/company-background_10000/0/1639489687528?e=2159024400&v=beta&t=Q5GACpkRTUUpb7ec_cSlS6J2xfgqkonhx76xSV4gEwY",
                    Founded = 2001,
                    CityId = 60861,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("be76d6cb-0532-4dd5-8e4e-f944faf0106b"),
                    CUIT = "201254354455",
                    Phone = "54-1151540027",
                    BusinessName = "Sistemas Activos SRL",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "http://www.sistemasactivos.com",
                    MinimalDescription = "Potenciamos la eficiencia aplicando nuevas tecnologías para optimizar los procesos y la información de su empresa",
                    Description = "Sistemas Activos es una empresa de desarrollo de software, especializada en el sector financiero. Cuenta con importante experiencia en proyectos de desarrollo de software, en múltiples  plataformas para diferentes industrias y se especializa en análisis, diseño y construcción de sistemas para banca y seguros. En el transcurso de estos años conformamos un equipo multidiciplinario de jóvenes profesionales con los que realizamos las siguientes actividades: Fábrica de Software, multiplataforma | Outsourcing de análisis, diseño y construcción de software a medida | Outsourcing de mantenimiento de aplicaciones | Desarrollo de software “llave en mano” con garantía de funcionamiento y calidad | Diseño y Construcción de Manuales Técnicos y de Usuario | Implementación de aplicaciones | Reclutamiento y Selección de Personal para contratación externa | Servicio de Capacitación con planificación de contenidos a medida.",
                    WorkerQuantity = 200,
                    Logo = "https://www.empleosit.com.ar/files/pictures/sistemas-activos.png",
                    FrontPage = "https://img.freepik.com/foto-gratis/concepto-sistema-gestion-empresarial-activos-digitales_53876-121226.jpg?w=1380&t=st=1690433056~exp=1690433656~hmac=57e506ed6a2753cd7cf6be67608bc1940f7ab526f107a08f337381abbb3da052",
                    Founded = 2002,
                    CityId = 60861,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("ac270f24-3f1f-43a6-b291-1f0ce4489bfd"),
                    CUIT = "201344354455",
                    Phone = "54-1151540447",
                    BusinessName = "Ingematica S.A.",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "http://www.ingematica.net",
                    MinimalDescription = "Desarrollamos soluciones tecnológicas innovadoras que agreguen valor a nuestros clientes",
                    Description = "Technological company dedicated to the personalized application development for 25 years. In their customer relationship, Ingematica commits itself as a strategic partner by understanding the problems and opportunities posed by businesses, so that it can provide technology solutions that not only meet the requirements but also add value to the project. Its business not only comprises the systems and technology areas but goes beyond that and takes into account the core of the business, therefore creating value.\r\n\r\nIngemática has gained wide experience in technology solutions in the financial, commercial, storage and distribution, e_commerce fields, among others.\r\n\r\nIn this way, Ingemática has provided overall advice in the information technology area, from the strategic planning to the realization of the project for the implementation of improvements in commercial, administrative and process fields. The company has chosen the most suitable technology to use in networks and databases, as well as having tested and planned hardware migrations, primary and intermediate software and applications installation\r\n\r\nLike Microsoft’s Gold Partner in e-commerce solutions, the company has developed multiple on-line sites, Web services and integration services that include a wide range of industries and sectors of the market.",
                    WorkerQuantity = 200,
                    Logo = "https://th.bing.com/th/id/OIP.e_KR8q6Eov7usmPt0Rmc_QAAAA?rs=1&pid=ImgDetMain",
                    FrontPage = "https://info.mavtechglobal.com/hubfs/07.23_MAV-CFE_IIoT.jpg",
                    Founded = 1983,
                    CityId = 60861,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("2a913313-dc4c-4f93-a1be-3fc5568e00b1"),
                    CUIT = "201256654455",
                    Phone = "54-1141540027",
                    BusinessName = "Axoft",
                    BusinessSector = "Software Development",
                    Website = "http://www.axoft.com",
                    MinimalDescription = "Potenciamos la eficiencia aplicando nuevas tecnologías para optimizar los procesos y la información de su empresa",
                    Description = "Somos la empresa líder del mercado ERP en Argentina.  Desarrollamos Software para empresas, estudios contables , comercios y gastronomía.  Junto a nuestros colaboradores, partners, clientes, estudiantes y graduados de Tango Univerisity, formamos una enorme comunidad que genera sinergia y colaboración en todo lo que emprendemos. #LaRebeldíaDeCrecer",
                    WorkerQuantity = 500,
                    Logo = "https://media.licdn.com/dms/image/C4E0BAQFqZnda3B2tSg/company-logo_200_200/0/1631354439249?e=1725494400&v=beta&t=9uiJKcFhfAClRoh--djZSIZyDzr7j1O_1vEjOhkiMcY",
                    FrontPage = "https://th.bing.com/th/id/OIP.cdUAE2drVxaH2PBRnFRotAHaD3?rs=1&pid=ImgDetMain",
                    Founded = 1988,
                    CityId = 60091,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("f42be566-1cc3-4863-9cf1-315828169000"),
                    CUIT = "201356654455",
                    Phone = "54-1141540027",
                    BusinessName = "Softtek",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "http://www.softtek.com",
                    MinimalDescription = "...creating value through technology.",
                    Description = "Founded in 1982 by a small group of entrepreneurs, Softtek started out in Mexico providing local IT services, and today is a global leader in next-generation digital solutions. The first company to introduce the Nearshore model, Softtek helps Global 2000 organizations build their digital capabilities constantly and seamlessly, from ideation and development to execution and evolution. Its entrepreneurial drive spans 20+ countries and more than 15,000 talented professionals.\r\n\r\nFor more information on what we do, who we are, and career opportunities, visit www.softtek.com / Follow us on Instagram (@softtekofficial), on Twitter (@Softtek), and be our fan on Facebook www.facebook.com/softtek.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/D560BAQGPNg8TewdnIg/company-logo_200_200/0/1699028835508/softtek_logo?e=1725494400&v=beta&t=SYiZ5XhA6cStX3ZJB1lEFWPQ00bsL2wjMnBhYmsJAUg",
                    FrontPage = "https://www.softtek.com/hubfs/Softtek/images/Media%20Resources/Softtek_MR01.jpg",
                    Founded = 1982,
                    CityId = 60861,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("0d4ad714-56a4-4bfc-b4b4-d776cfd51fd8"),
                    CUIT = "201246654455",
                    Phone = "54-1141560027",
                    BusinessName = "Telecom Argentina",
                    BusinessSector = "Telecommunications",
                    Website = "https://institucional.telecom.com.ar",
                    MinimalDescription = "Potenciamos la eficiencia aplicando nuevas tecnologías para optimizar los procesos y la información de su empresa",
                    Description = "We are Telecom Argentina, a connectivity solutions and entertainment company with over 23,000 collaborators throughout the country. We transform the digital experience of our over 28 million customers providing them a secure, flexible and dynamic service on all of their devices, with high speed mobile and fixed connections, and a live and on-demand contents platform which includes series, films, gaming, music and TV shows. Through our commercial brands Personal, Fibertel, Flow and Telecom | Fibercorp, we provide services such as fixed and mobile telephony, data transmission, pay TV and Internet, for individuals, companies and institutions throughout the country. We are also present in Paraguay, providing mobile service, and in Uruguay, with pay TV.\r\nWe are leaders in an industry that has become one of the pillars for the social and economic development of our country, and we are active participants in the community with sustainable practices and initiatives that add value to the use of technology as a tool for training and social inclusion.\r\n\r\n",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/C560BAQFprODE31hkZw/company-logo_200_200/0/1633362509709/telecom_argentina_logo?e=1725494400&v=beta&t=SzsNY0t_wJt9VZ8gfJ8SOIgUsxGnOSpehBseYaBpg9Q",
                    FrontPage = "https://www.radiosudamericana.com/notix/multimedia/imagenes/fotos/2021-10-05/936513.jpg",
                    Founded = 1990,
                    CityId = 60427,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("d4caf327-f110-4ab6-9305-c064a2071dc5"),
                    CUIT = "201256754455",
                    Phone = "54-1141540027",
                    BusinessName = "Personal Argentina",
                    BusinessSector = "Telecommunications",
                    Website = "https://www.personal.com.ar",
                    MinimalDescription = "Personal es el servicio de conectividad total, fija y móvil, de Telecom Argentina",
                    Description = "Personal es el servicio de conectividad total, fija y móvil, de Telecom Argentina. Con la red 4G/LTE más rápida y la primera red 5G del país, las redes FTTH (fibra óptica al hogar) y HFC (red que incorpora fibra óptica y cable coaxial), brinda una experiencia de conectividad sin fronteras, dentro y fuera del hogar, para estudiar, trabajar o entretenerse, desde cualquier dispositivo, momento y lugar.  Ofrece velocidades de navegación que llegan los 300 y 1000 megas, y con su red 4G alcanza a más de 1.900 localidades en todas las provincias.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/C4D0BAQEPykopfVrlFA/company-logo_200_200/0/1636481278317/personal_argentina_logo?e=1725494400&v=beta&t=630rgenJQ6Ram88lQa3lLngMBtWmGjtth8Oav5pEC28",
                    FrontPage = "https://argentinaesim.com/wp-content/uploads/sites/39/2023/11/26-1024x683.jpg",
                    Founded = 1988,
                    CityId = 60427,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("874fb32f-0ddd-4b5f-ac31-f2f11b66e098"),
                    CUIT = "201256654455",
                    Phone = "54-1141540027",
                    BusinessName = "Paypal",
                    BusinessSector = "Software Development",
                    Website = "https://www.paypal.com/us/home",
                    MinimalDescription = "We're championing possibilities for all by making money fast, easy, and more enjoyable",
                    Description = "We're championing possibilities for all by making money fast, easy, and more enjoyable. Our hope is unlock opportunities for people in their everyday lives and empower the millions of people and businesses around the world who trust, rely, and use PayPal every day. \r\n\r\nFor support, visit the PayPal Help Center. https://payp.al/help\r\n\r\nFor employment opportunities, check out our job openings in the 'Jobs' tab. We're an equal opportunity employer that welcomes diversity, and offer generous benefits to help you thrive at work and in your free time.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/D560BAQEBi1qAFwOeEg/company-logo_200_200/0/1705414740395/paypal_logo?e=1725494400&v=beta&t=JFRCXFAAq6f5W-4MvFc3EAbfFCsUq7ozxCWppUliKp8",
                    FrontPage = "https://tynmagazine.com/wp-content/uploads/sites/3/2015/08/paypal-900x620.jpg",
                    Founded = 1995,
                    CityId = 60412,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("57168621-b0dd-4fe4-a20e-489171d70a5d"),
                    CUIT = "201256654455",
                    Phone = "54-1141540027",
                    BusinessName = "EY",
                    BusinessSector = "Professional Services",
                    Website = "http://www.ey.com",
                    MinimalDescription = "EY exists to build a better working world...",
                    Description = "EY exists to build a better working world, helping create long-term value for clients, people and society and build trust in the capital markets.\r\n\r\nEnabled by data and technology, diverse EY teams in over 150 countries provide trust through assurance and help clients grow, transform and operate.\r\n\r\nWorking across assurance, consulting, law, strategy, tax and transactions, EY teams ask better questions to find new answers for the complex issues facing our world today.\r\n\r\nFind out more about the EY global network http://ey.com/en_gl/legal-statement",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/C510BAQGpRhkpxp5A9A/company-logo_200_200/0/1630570672166/ernstandyoung_logo?e=1725494400&v=beta&t=AtOxU4BR9-jY6sLiwS6Ayj9muNw55lwSADpzMJn3oGY",
                    FrontPage = "https://th.bing.com/th/id/R.561c527d1aca80affd4e665bd076bf3c?rik=zpvdFzoQRCRPnA&pid=ImgRaw&r=0",
                    Founded = 1998,
                    CityId = 60412,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("379982fe-d22e-429f-bc14-26fffc569958"),
                    CUIT = "201256655455",
                    Phone = "54-1141540027",
                    BusinessName = "Santander Argentina",
                    BusinessSector = "Banking",
                    Website = "http://www.santander.com.ar",
                    MinimalDescription = "#QueremosAyudarte",
                    Description = "Somos el Equipo de Santander Río, 7.800 personas que buscamos compartir nuestras iniciativas orientadas a construir cada día, en cada Oficina, en cada Sucursal un mejor lugar para trabajar. \r\n\r\nDar forma a una empresa orientada a las personas, creando un entorno que privilegia el reconocimiento, el trabajo en equipo y el desarrollo, integrando los intereses personales con los laborales. Mientras crecemos como profesionales y como personas buscamos crear grandes relaciones con nuestros clientes y contribuir al progreso de las Comunidades en las que estamos presentes.\r\n\r\nA través de este espacio, invitamos a nuestros más de 2,5 millones de clientes en más de 397 sucursales, a colegas y profesionales, a profesores y estudiantes de carreras de capital humano a conocer y enriquecer mutuamente nuestras prácticas. Te invitamos a crecer, a innovar y crear experiencias, juntos.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/D4D0BAQH4npMYAm8s8Q/company-logo_200_200/0/1688566399619?e=1725494400&v=beta&t=VNWXJEM7LQF-RXYBa6dbsiyaK6misDSIdcTYoXCVq-A",
                    FrontPage = "https://image.blockchain.news/features/DC5D08441EF81C2B346BB8958233EFCEF16CAF3538A0CD57AD444F5927A4FB02.jpg",
                    Founded = 1921,
                    CityId = 60412,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("9f7c46a4-9ea5-4bc6-bd47-90ba52c54734"),
                    CUIT = "201256654444",
                    Phone = "54-1141543227",
                    BusinessName = "Galicia Bank",
                    BusinessSector = "Financial Services",
                    Website = "https://www.galicia.ar/personas",
                    MinimalDescription = "Sumate a mejorar el día a día de más personas",
                    Description = "Fundado en 1905, Banco Galicia es uno de los principales bancos privados del sistema financiero argentino, líder en la provisión de servicios financieros en todo el país. \r\n\r\nComo banco universal –y a través de distintas compañías vinculadas y de variados canales de distribución–, ofrecemos una amplia gama de servicios financieros a más de 4,2 millones de clientes, tanto individuos como empresas. \r\nOperamos en una de las más extensas y diversificadas redes de distribución del sector financiero privado argentino, ofreciendo más de 350 puntos de contacto con sus clientes por intermedio de sucursales bancarias y centros de banca electrónica y otros más de 200 centros de atención correspondientes a las compañías de tarjetas regionales. \r\nNuestros clientes también cuentan con acceso a servicios de banca telefónica y a bancogalicia.com y Galicia Móvil, el primer portal financiero de Internet y el primer servicio de pagos mediante el teléfono celular, respectivamente, establecidos por un banco en la Argentina.\r\n\r\nEl principal accionista del Banco es Grupo Financiero Galicia S.A.,sociedad holding de servicios  financieros.",
                    WorkerQuantity = 10000,
                    Logo = "https://media.licdn.com/dms/image/C4D0BAQFp8pBc86ERbg/company-logo_200_200/0/1672239398829/bancogalicia_logo?e=1725494400&v=beta&t=u2zR5ftORacCv6qOk-lmUWX5QHkWk-BrTkDu71Ykqy4",
                    FrontPage = "https://www.ideailuminacion.com.ar/wp-content/uploads/2018/02/galicia-portada-opcion-2-1920x1038.jpg",
                    Founded = 1905,
                    CityId = 60410,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("b735e23e-c928-41fc-b399-aa4a28807210"),
                    CUIT = "201256654455",
                    Phone = "54-1115881458",
                    BusinessName = "Adviters",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "https://www.adviters.com",
                    MinimalDescription = "SHIFTING IDEAS INTO FACTS",
                    Description = "We are a digital native company with leading capabilities whose objective is to empower our clients and support them in their transformation processes towards modern, digital organizations, with the agility and dynamism necessary to successfully materialize their business vision\r\n\r\nWith clients such Volkswagen, Fiserv, Itaú, we stand for them as a technology partner with a service oriented mindset, providing Digital Transformation services end to end.  \r\nWe partner big brands such Microsoft, Google, AWS and RedHat with specialists in their tools and applications.\r\n\r\nWe have been recognized as one of the best IT Companies by GreatPleaceToWork.  That is just a sign of our advocacy for equality putting the people first.",
                    WorkerQuantity = 200,
                    Logo = "https://media.licdn.com/dms/image/C4D0BAQEEBMsbWMdO5A/company-logo_200_200/0/1678907502108/adviters_logo?e=1725494400&v=beta&t=Q68iW4TgfRWRZj4MofsduiWslaaAqwZwzVjn-wfm8jQ",
                    FrontPage = "https://adviters.com/wp-content/uploads/2023/05/20230228_141700-1-scaled.jpg",
                    Founded = 2015,
                    CityId = 60091,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("f4c4ffe2-e95d-4c05-a958-d32b26fecfc2"),
                    CUIT = "201256653355",
                    Phone = "54-1115881458",
                    BusinessName = "Faster Argentina",
                    BusinessSector = "Human Resources Services",
                    Website = "http://www.ettfaster.com.ar",
                    MinimalDescription = "Búsqueda y Selección de Personal - Personal Eventual",
                    Description = "Somos una empresa de trabajo temporal, que inició su actividad en 1980 con el propósito de afianzar el sector de RR.HH.\r\n\r\nContamos con un grupo de profesionales altamente calificados en Recursos Humanos, dispuestos a interpretar las necesidades de quienes quieren insertarse en el mercado laboral y aquellos que buscan talentos para desempeñarse en sus posiciones vacantes.\r\n\r\nBuscamos agilizar y optimizar el proceso de selección y asegurar una atención totalmente personalizada, donde la satisfacción de nuestros clientes se convertirá en nuestro primer objetivo.",
                    WorkerQuantity = 5000,
                    Logo = "https://ii.ct-stc.com/5/logos/empresas/2017/11/21/ett-faster-argentina-sa-A5C885307F8746A7180927thumbnail.jpeg",
                    FrontPage = "https://res.cloudinary.com/people-matters/image/upload/fl_immutable_cache,w_768,h_432,q_auto,f_auto/q_auto,f_auto/v1692140931/1692140930.jpg",
                    Founded = 1980,
                    CityId = 60412,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("a4db8ecb-2f10-436e-8011-cf701620ea60"),
                    CUIT = "201156654455",
                    Phone = "54-1115882458",
                    BusinessName = "SIDESYS IT SOLUTIONS",
                    BusinessSector = "IT Services and IT Consulting",
                    Website = "http://www.sidesys.com",
                    MinimalDescription = "Brindamos soluciones destinadas a mejorar y optimizar el circuito de los procesos de atención al público.",
                    Description = "WeEn SIDESYS IT SOLUTIONS® nos dedicamos hace más de 20 años al desarrollo e implementación de soluciones tecnológicas integrales e innovadoras, orientadas a optimizar el circuito de los procesos de atención al público y la experiencia del cliente.\r\n\r\nAdemás, somos una empresa que desde su nacimiento en el año 1999 en Buenos Aires, hasta el día de hoy fue logrando un crecimiento constante tanto a nivel comercial, llegando a tener más de 300 clientes, como también regional, contando con más de 10 oficinas a lo largo de todo América Latina.",
                    WorkerQuantity = 200,
                    Logo = "https://media.licdn.com/dms/image/C560BAQFuSnwdYVIErQ/company-logo_200_200/0/1630634222975/sidesys_logo?e=1725494400&v=beta&t=Gd3vDsqLp3_5ox_aCuMP43hW7Y_GBUhubD7KmjSwR2M",
                    FrontPage = "https://media-exp1.licdn.com/dms/image/C4E1BAQFXP9i9g43__w/company-background_10000/0/1555400015935?e=2159024400&v=beta&t=5C0t657HxzUlGUVvteARb1d_SztEdDQ_cWOqpFY_SY4",
                    Founded = 1999,
                    CityId = 60091,
                    Status = true
                },
                new Company
                {
                    CompanyId = Guid.Parse("ddc7879b-e104-4047-bd15-d0fade9bbeee"),
                    CUIT = "201253653455",
                    Phone = "54-1115281458",
                    BusinessName = "Grupo Gestión",
                    BusinessSector = "Human Resources Services",
                    Website = "http://www.grupo-gestion.com.ar",
                    MinimalDescription = "Líderes en la prestación de servicios profesionales de búsqueda, selección y gestión de capital humano.",
                    Description = "WeDesde su formación en 1997, GRUPO GESTIÓN se afianzó en el país, a través de sus diferentes Unidades de Negocio, como uno de los líderes de Compañías especializadas en la prestación de Servicios Integrales de Recursos Humanos. Ofreciendo la mejor cobertura de Personal Temporario y brindando asistencia profesional en las áreas de: Consultoría en Búsqueda y Selección de Personal; Promoción y Merchandising; Servicios Logísticos y de Out Sourcing, Servicios para la Agroindustria, entre otras.\r\n\r\nActualmente somos la Compañía de capitales nacionales número UNO en el Mercado del Personal Eventual, asegurando siempre el mejor Servicio, brindando asistencia y Capital Humano en todo momento y lugar.\r\n\r\nCon más de 250 profesionales puestos a disposición y 23 Sucursales estratégicamente ubicadas a lo largo de todo el país, alcanzamos una cobertura de los pedidos superior al 90 por ciento. 600 Empresas confían diariamente en nosotros.\r\nEn el 2011, se incorporó la nueva Unidad de Negocio Gestión Consultores, especializada en Búsquedas y selección de personal; Head Hunting; Encuestas de clima organizacional; Evaluaciones de desempeño; Outplacement; Capacitación; Informes psicotécnicos y ambientales; Encuestas salariales; y Evaluación de la cultura en seguridad e higiene.\r\n\r\nGestión Laboral, Gestión Integral, Gestión Logística, Gestión Industrial, Gestión Agro y Gestión Consultores. Juntos somos GRUPO GESTIÓN.",
                    WorkerQuantity = 200,
                    Logo = "https://media.licdn.com/dms/image/C4D0BAQEx9lY5-7_NIg/company-logo_200_200/0/1631376883650/grupo_gesti_n_logo?e=1725494400&v=beta&t=QDMyJ6NdAgwBY4KNCPAzBKVovF-gT26MX8Ml7YVOTBQ",
                    FrontPage = "https://th.bing.com/th/id/R.01939c6d2797605321b119cde9a0505a?rik=Lk53XXEo6YBiMQ&pid=ImgRaw&r=0",
                    Founded = 1997,
                    CityId = 60412,
                    Status = true
                });
        }
    }
}