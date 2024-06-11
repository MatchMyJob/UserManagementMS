using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public static class ApplicantData
    {
        public static void SeedData(EntityTypeBuilder<Applicant> builder)
        {
            builder.HasData(
                new Applicant
                {
                    UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85"),
                    CityId = 60274,
                    DNI = "307977771",
                    Phone = "54-1115281450",
                    Linkedin = "https://www.linkedin.com/in/leonel47",
                    Email = "leonelesquivel@gmail.com",
                    Name = "Leonel",
                    Surname = "Esquivel",
                    MinimalDescription = "Experienced full-stack developer skilled in C# and .NET.",
                    BirthDate = new DateOnly(1990, 5, 15),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473"),
                    CityId = 60274,
                    DNI = "307977772",
                    Phone = "54-1115281451",
                    Linkedin = "https://www.linkedin.com/in/anagomez",
                    Email = "anagomez@gmail.com",
                    Name = "Ana",
                    Surname = "Gomez",
                    MinimalDescription = "Front-end developer with expertise in React and Angular.",
                    BirthDate = new DateOnly(1992, 8, 20),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8"),
                    CityId = 60274,
                    DNI = "307977773",
                    Phone = "54-1115281452",
                    Linkedin = "https://www.linkedin.com/in/carlos23",
                    Email = "carlosrodriguez@gmail.com",
                    Name = "Carlos",
                    Surname = "Rodriguez",
                    MinimalDescription = "Backend developer specializing in Java and Spring framework.",
                    BirthDate = new DateOnly(1988, 3, 12),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84"),
                    CityId = 60274,
                    DNI = "307977774",
                    Phone = "54-1115281453",
                    Linkedin = "https://www.linkedin.com/in/maria25",
                    Email = "mariagarcia@gmail.com",
                    Name = "Maria",
                    Surname = "Garcia",
                    MinimalDescription = "Software engineer with a focus on data analysis and Python.",
                    BirthDate = new DateOnly(1995, 11, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931"),
                    CityId = 60274,
                    DNI = "307977775",
                    Phone = "54-1115281454",
                    Linkedin = "https://www.linkedin.com/in/joseluis45",
                    Email = "joseluis@gmail.com",
                    Name = "Jose Luis",
                    Surname = "Perez",
                    MinimalDescription = "Full-stack developer with a passion for mobile app development.",
                    BirthDate = new DateOnly(1991, 7, 22),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb"),
                    CityId = 60274,
                    DNI = "307977776",
                    Phone = "54-1115281455",
                    Linkedin = "https://www.linkedin.com/in/luis10",
                    Email = "luisfernandez@gmail.com",
                    Name = "Luis",
                    Surname = "Fernandez",
                    MinimalDescription = "Experienced in cloud computing and DevOps practices.",
                    BirthDate = new DateOnly(1985, 1, 17),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad"),
                    CityId = 60274,
                    DNI = "307977777",
                    Phone = "54-1115281456",
                    Linkedin = "https://www.linkedin.com/in/marta34",
                    Email = "martarivera@gmail.com",
                    Name = "Marta",
                    Surname = "Rivera",
                    MinimalDescription = "Proficient in machine learning and AI development.",
                    BirthDate = new DateOnly(1993, 9, 10),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9"),
                    CityId = 60274,
                    DNI = "307977778",
                    Phone = "54-1115281457",
                    Linkedin = "https://www.linkedin.com/in/miguel67",
                    Email = "miguelsanchez@gmail.com",
                    Name = "Miguel",
                    Surname = "Sanchez",
                    MinimalDescription = "Skilled in database management and SQL.",
                    BirthDate = new DateOnly(1987, 4, 28),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978"),
                    CityId = 60274,
                    DNI = "307977779",
                    Phone = "54-1115281458",
                    Linkedin = "https://www.linkedin.com/in/laura12",
                    Email = "laurahernandez@gmail.com",
                    Name = "Laura",
                    Surname = "Hernandez",
                    MinimalDescription = "Expert in cybersecurity and network security protocols.",
                    BirthDate = new DateOnly(1990, 6, 5),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f"),
                    CityId = 60274,
                    DNI = "307977780",
                    Phone = "54-1115281459",
                    Linkedin = "https://www.linkedin.com/in/david89",
                    Email = "davidmartin@gmail.com",
                    Name = "David",
                    Surname = "Martin",
                    MinimalDescription = "Developer with extensive experience in Agile methodologies.",
                    BirthDate = new DateOnly(1994, 2, 14),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675"),
                    CityId = 60274,
                    DNI = "307977781",
                    Phone = "54-1115281460",
                    Linkedin = "https://www.linkedin.com/in/sara56",
                    Email = "saraperez@gmail.com",
                    Name = "Sara",
                    Surname = "Perez",
                    MinimalDescription = "Software developer with extensive experience in backend systems.",
                    BirthDate = new DateOnly(1991, 4, 10),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8"),
                    CityId = 60274,
                    DNI = "307977782",
                    Phone = "54-1115281461",
                    Linkedin = "https://www.linkedin.com/in/juancarlos",
                    Email = "juancarlos@gmail.com",
                    Name = "Juan",
                    Surname = "Carlos",
                    MinimalDescription = "Frontend engineer specializing in React and modern JavaScript.",
                    BirthDate = new DateOnly(1989, 6, 24),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36"),
                    CityId = 60274,
                    DNI = "307977783",
                    Phone = "54-1115281462",
                    Linkedin = "https://www.linkedin.com/in/carmen78",
                    Email = "carmenlopez@gmail.com",
                    Name = "Carmen",
                    Surname = "Lopez",
                    MinimalDescription = "Data scientist with a strong background in machine learning.",
                    BirthDate = new DateOnly(1987, 11, 5),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754"),
                    CityId = 60274,
                    DNI = "307977784",
                    Phone = "54-1115281463",
                    Linkedin = "https://www.linkedin.com/in/pablo43",
                    Email = "pablomartinez@gmail.com",
                    Name = "Pablo",
                    Surname = "Martinez",
                    MinimalDescription = "Full stack developer with expertise in cloud-based solutions.",
                    BirthDate = new DateOnly(1992, 2, 14),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f"),
                    CityId = 60274,
                    DNI = "307977785",
                    Phone = "54-1115281464",
                    Linkedin = "https://www.linkedin.com/in/gloria22",
                    Email = "gloriaramos@gmail.com",
                    Name = "Gloria",
                    Surname = "Ramos",
                    MinimalDescription = "Cybersecurity expert with over 10 years of experience.",
                    BirthDate = new DateOnly(1990, 12, 1),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6"),
                    CityId = 60274,
                    DNI = "307977786",
                    Phone = "54-1115281465",
                    Linkedin = "https://www.linkedin.com/in/antonio65",
                    Email = "antonioalvarez@gmail.com",
                    Name = "Antonio",
                    Surname = "Alvarez",
                    MinimalDescription = "DevOps engineer with a focus on automation and CI/CD.",
                    BirthDate = new DateOnly(1985, 8, 19),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26"),
                    CityId = 60274,
                    DNI = "307977787",
                    Phone = "54-1115281466",
                    Linkedin = "https://www.linkedin.com/in/patricia98",
                    Email = "patriciaflores@gmail.com",
                    Name = "Patricia",
                    Surname = "Flores",
                    MinimalDescription = "Mobile application developer with a passion for UI/UX design.",
                    BirthDate = new DateOnly(1993, 5, 22),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090"),
                    CityId = 60274,
                    DNI = "307977788",
                    Phone = "54-1115281467",
                    Linkedin = "https://www.linkedin.com/in/andres55",
                    Email = "andresromero@gmail.com",
                    Name = "Andres",
                    Surname = "Romero",
                    MinimalDescription = "Backend developer with expertise in databases and microservices.",
                    BirthDate = new DateOnly(1988, 7, 9),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729"),
                    CityId = 60274,
                    DNI = "307977789",
                    Phone = "54-1115281468",
                    Linkedin = "https://www.linkedin.com/in/elena31",
                    Email = "elenadiaz@gmail.com",
                    Name = "Elena",
                    Surname = "Diaz",
                    MinimalDescription = "Software engineer specializing in AI and machine learning.",
                    BirthDate = new DateOnly(1994, 3, 18),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414"),
                    CityId = 60274,
                    DNI = "307977790",
                    Phone = "54-1115281469",
                    Linkedin = "https://www.linkedin.com/in/roberto44",
                    Email = "robertohidalgo@gmail.com",
                    Name = "Roberto",
                    Surname = "Hidalgo",
                    MinimalDescription = "Front-end developer with a strong background in design.",
                    BirthDate = new DateOnly(1992, 6, 28),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439"),
                    CityId = 60274,
                    DNI = "307977791",
                    Phone = "54-1115281470",
                    Linkedin = "https://www.linkedin.com/in/pedrogomez",
                    Email = "pedrogomez@hotmail.com",
                    Name = "Pedro",
                    Surname = "Gomez",
                    MinimalDescription = "Experienced software developer with strong C# skills.",
                    BirthDate = new DateOnly(1985, 5, 10),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82"),
                    CityId = 60274,
                    DNI = "307977792",
                    Phone = "54-1115281471",
                    Linkedin = "https://www.linkedin.com/in/isabelhernandez",
                    Email = "isabelhernandez@hotmail.com",
                    Name = "Isabel",
                    Surname = "Hernandez",
                    MinimalDescription = "Full-stack developer specializing in .NET and Angular.",
                    BirthDate = new DateOnly(1988, 7, 15),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7"),
                    CityId = 60274,
                    DNI = "307977793",
                    Phone = "54-1115281472",
                    Linkedin = "https://www.linkedin.com/in/rafaelmartinez",
                    Email = "rafaelmartinez@hotmail.com",
                    Name = "Rafael",
                    Surname = "Martinez",
                    MinimalDescription = "Backend developer with expertise in microservices architecture.",
                    BirthDate = new DateOnly(1990, 3, 20),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1"),
                    CityId = 60274,
                    DNI = "307977794",
                    Phone = "54-1115281473",
                    Linkedin = "https://www.linkedin.com/in/anamaria",
                    Email = "anamaria@hotmail.com",
                    Name = "Ana Maria",
                    Surname = "Gonzalez",
                    MinimalDescription = "Frontend developer passionate about creating intuitive user experiences.",
                    BirthDate = new DateOnly(1993, 9, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb"),
                    CityId = 60274,
                    DNI = "307977795",
                    Phone = "54-1115281474",
                    Linkedin = "https://www.linkedin.com/in/juanantonio89",
                    Email = "juanantonio@hotmail.com",
                    Name = "Juan Antonio",
                    Surname = "Fernandez",
                    MinimalDescription = "DevOps engineer focused on continuous integration and deployment.",
                    BirthDate = new DateOnly(1984, 12, 5),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1"),
                    CityId = 60274,
                    DNI = "307977796",
                    Phone = "54-1115281475",
                    Linkedin = "https://www.linkedin.com/in/sofia34",
                    Email = "sofiagonzalez@hotmail.com",
                    Name = "Sofia",
                    Surname = "Gonzalez",
                    MinimalDescription = "Mobile app developer specializing in Android and iOS platforms.",
                    BirthDate = new DateOnly(1992, 8, 12),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f"),
                    CityId = 60274,
                    DNI = "307977797",
                    Phone = "54-1115281476",
                    Linkedin = "https://www.linkedin.com/in/alejandro22",
                    Email = "alejandro@hotmail.com",
                    Name = "Alejandro",
                    Surname = "Martinez",
                    MinimalDescription = "Data scientist with a strong background in machine learning.",
                    BirthDate = new DateOnly(1995, 10, 20),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f"),
                    CityId = 60274,
                    DNI = "307977798",
                    Phone = "54-1115281477",
                    Linkedin = "https://www.linkedin.com/in/lucia56",
                    Email = "luciaramos@hotmail.com",
                    Name = "Lucia",
                    Surname = "Ramos",
                    MinimalDescription = "Cybersecurity expert with extensive experience in network security.",
                    BirthDate = new DateOnly(1989, 1, 17),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f"),
                    CityId = 60274,
                    DNI = "307977799",
                    Phone = "54-1115281478",
                    Linkedin = "https://www.linkedin.com/in/diego12",
                    Email = "diegolopez@hotmail.com",
                    Name = "Diego",
                    Surname = "Lopez",
                    MinimalDescription = "Software engineer specializing in AI and deep learning.",
                    BirthDate = new DateOnly(1994, 4, 22),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206"),
                    CityId = 60274,
                    DNI = "307977800",
                    Phone = "54-1115281479",
                    Linkedin = "https://www.linkedin.com/in/paula31",
                    Email = "paulaperez@hotmail.com",
                    Name = "Paula",
                    Surname = "Perez",
                    MinimalDescription = "Backend developer with expertise in cloud-based applications.",
                    BirthDate = new DateOnly(1991, 6, 11),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7"),
                    CityId = 60274,
                    DNI = "307977801",
                    Phone = "54-1115281480",
                    Linkedin = "https://www.linkedin.com/in/roberto67",
                    Email = "robertomorales@hotmail.com",
                    Name = "Roberto",
                    Surname = "Morales",
                    MinimalDescription = "Project manager with over 10 years of experience in the tech industry.",
                    BirthDate = new DateOnly(1980, 2, 5),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9"),
                    CityId = 60274,
                    DNI = "307977802",
                    Phone = "54-1115281481",
                    Linkedin = "https://www.linkedin.com/in/teresadiaz",
                    Email = "teresadiaz@hotmail.com",
                    Name = "Teresa",
                    Surname = "Diaz",
                    MinimalDescription = "Marketing specialist with a focus on digital campaigns.",
                    BirthDate = new DateOnly(1985, 3, 15),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b"),
                    CityId = 60274,
                    DNI = "307977803",
                    Phone = "54-1115281482",
                    Linkedin = "https://www.linkedin.com/in/josemanuel78",
                    Email = "josemanuel@hotmail.com",
                    Name = "Jose Manuel",
                    Surname = "Lopez",
                    MinimalDescription = "System analyst with extensive experience in business process optimization.",
                    BirthDate = new DateOnly(1978, 11, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5"),
                    CityId = 60274,
                    DNI = "307977804",
                    Phone = "54-1115281483",
                    Linkedin = "https://www.linkedin.com/in/adriana65",
                    Email = "adrianaperez@hotmail.com",
                    Name = "Adriana",
                    Surname = "Perez",
                    MinimalDescription = "Human resources manager with a knack for talent acquisition.",
                    BirthDate = new DateOnly(1965, 4, 18),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4"),
                    CityId = 60274,
                    DNI = "307977805",
                    Phone = "54-1115281484",
                    Linkedin = "https://www.linkedin.com/in/francisco99",
                    Email = "francisco@hotmail.com",
                    Name = "Francisco",
                    Surname = "Gonzalez",
                    MinimalDescription = "Financial analyst with a focus on market trends and investment strategies.",
                    BirthDate = new DateOnly(1999, 6, 12),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2"),
                    CityId = 60274,
                    DNI = "307977806",
                    Phone = "54-1115281485",
                    Linkedin = "https://www.linkedin.com/in/monica43",
                    Email = "monicagarcia@hotmail.com",
                    Name = "Monica",
                    Surname = "Garcia",
                    MinimalDescription = "Graphic designer with a passion for branding and visual communication.",
                    BirthDate = new DateOnly(1981, 7, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3"),
                    CityId = 60274,
                    DNI = "307977807",
                    Phone = "54-1115281486",
                    Linkedin = "https://www.linkedin.com/in/victor87",
                    Email = "victormorales@hotmail.com",
                    Name = "Victor",
                    Surname = "Morales",
                    MinimalDescription = "Sales executive with expertise in B2B sales and client relations.",
                    BirthDate = new DateOnly(1987, 10, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae"),
                    CityId = 60274,
                    DNI = "307977808",
                    Phone = "54-1115281487",
                    Linkedin = "https://www.linkedin.com/in/carmen56",
                    Email = "carmenflores@hotmail.com",
                    Name = "Carmen",
                    Surname = "Flores",
                    MinimalDescription = "Content creator with a strong following on social media platforms.",
                    BirthDate = new DateOnly(1956, 8, 19),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903"),
                    CityId = 60274,
                    DNI = "307977809",
                    Phone = "54-1115281488",
                    Linkedin = "https://www.linkedin.com/in/luismiguel",
                    Email = "luismiguel@hotmail.com",
                    Name = "Luis Miguel",
                    Surname = "Hernandez",
                    MinimalDescription = "Network engineer with extensive knowledge of Cisco systems.",
                    BirthDate = new DateOnly(1975, 1, 22),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd"),
                    CityId = 60274,
                    DNI = "307977810",
                    Phone = "54-1115281489",
                    Linkedin = "https://www.linkedin.com/in/beatriz12",
                    Email = "beatriz@hotmail.com",
                    Name = "Beatriz",
                    Surname = "Lopez",
                    MinimalDescription = "HR specialist with a focus on employee engagement and development.",
                    BirthDate = new DateOnly(1989, 12, 3),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b"),
                    CityId = 60274,
                    DNI = "307977811",
                    Phone = "54-1115281490",
                    Linkedin = "https://www.linkedin.com/in/jorge77",
                    Email = "jorge@hotmail.com",
                    Name = "Jorge",
                    Surname = "Perez",
                    MinimalDescription = "Software developer with experience in full-stack development.",
                    BirthDate = new DateOnly(1977, 7, 15),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c"),
                    CityId = 60274,
                    DNI = "307977812",
                    Phone = "54-1115281491",
                    Linkedin = "https://www.linkedin.com/in/fernando78",
                    Email = "fernandogomez@outlook.com",
                    Name = "Fernando",
                    Surname = "Gomez",
                    MinimalDescription = "IT consultant specializing in cloud solutions.",
                    BirthDate = new DateOnly(1978, 8, 22),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df"),
                    CityId = 60274,
                    DNI = "307977813",
                    Phone = "54-1115281492",
                    Linkedin = "https://www.linkedin.com/in/alejandra45",
                    Email = "alejandrahernandez@outlook.com",
                    Name = "Alejandra",
                    Surname = "Hernandez",
                    MinimalDescription = "Product manager with a focus on consumer electronics.",
                    BirthDate = new DateOnly(1985, 5, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b"),
                    CityId = 60274,
                    DNI = "307977814",
                    Phone = "54-1115281493",
                    Linkedin = "https://www.linkedin.com/in/gustavo23",
                    Email = "gustavomartinez@outlook.com",
                    Name = "Gustavo",
                    Surname = "Martinez",
                    MinimalDescription = "Electrical engineer with a passion for renewable energy.",
                    BirthDate = new DateOnly(1988, 9, 10),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3"),
                    CityId = 60274,
                    DNI = "307977815",
                    Phone = "54-1115281494",
                    Linkedin = "https://www.linkedin.com/in/valeria67",
                    Email = "valeriagonzalez@outlook.com",
                    Name = "Valeria",
                    Surname = "Gonzalez",
                    MinimalDescription = "Civil engineer with expertise in large infrastructure projects.",
                    BirthDate = new DateOnly(1967, 6, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c"),
                    CityId = 60274,
                    DNI = "307977816",
                    Phone = "54-1115281495",
                    Linkedin = "https://www.linkedin.com/in/raul89",
                    Email = "raulperez@outlook.com",
                    Name = "Raul",
                    Surname = "Perez",
                    MinimalDescription = "Mechanical engineer with a focus on automotive design.",
                    BirthDate = new DateOnly(1989, 10, 5),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633"),
                    CityId = 60274,
                    DNI = "307977817",
                    Phone = "54-1115281496",
                    Linkedin = "https://www.linkedin.com/in/camila34",
                    Email = "camilasanchez@outlook.com",
                    Name = "Camila",
                    Surname = "Sanchez",
                    MinimalDescription = "Chemical engineer specializing in pharmaceutical processes.",
                    BirthDate = new DateOnly(1987, 3, 14),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a"),
                    CityId = 60274,
                    DNI = "307977818",
                    Phone = "54-1115281497",
                    Linkedin = "https://www.linkedin.com/in/felipe22",
                    Email = "felipelopez@outlook.com",
                    Name = "Felipe",
                    Surname = "Lopez",
                    MinimalDescription = "Software engineer with a focus on AI and machine learning.",
                    BirthDate = new DateOnly(1992, 5, 20),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44"),
                    CityId = 60274,
                    DNI = "307977819",
                    Phone = "54-1115281498",
                    Linkedin = "https://www.linkedin.com/in/natalia56",
                    Email = "nataliaramirez@outlook.com",
                    Name = "Natalia",
                    Surname = "Ramirez",
                    MinimalDescription = "Biomedical engineer with experience in medical device design.",
                    BirthDate = new DateOnly(1968, 8, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2"),
                    CityId = 60274,
                    DNI = "307977820",
                    Phone = "54-1115281499",
                    Linkedin = "https://www.linkedin.com/in/alberto12",
                    Email = "albertogarcia@outlook.com",
                    Name = "Alberto",
                    Surname = "Garcia",
                    MinimalDescription = "Civil engineer with expertise in urban development projects.",
                    BirthDate = new DateOnly(1985, 6, 15),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7"),
                    CityId = 60274,
                    DNI = "307977821",
                    Phone = "54-1115281500",
                    Linkedin = "https://www.linkedin.com/in/paola31",
                    Email = "paoladiaz@outlook.com",
                    Name = "Paola",
                    Surname = "Diaz",
                    MinimalDescription = "Environmental scientist with a focus on climate change mitigation.",
                    BirthDate = new DateOnly(1990, 9, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e"),
                    CityId = 60274,
                    DNI = "307977822",
                    Phone = "54-1115281501",
                    Linkedin = "https://www.linkedin.com/in/claudia67",
                    Email = "claudiaramirez@outlook.com",
                    Name = "Claudia",
                    Surname = "Ramirez",
                    MinimalDescription = "Marketing specialist with over 20 years of experience in digital campaigns.",
                    BirthDate = new DateOnly(1976, 12, 5),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d"),
                    CityId = 60274,
                    DNI = "307977823",
                    Phone = "54-1115281502",
                    Linkedin = "https://www.linkedin.com/in/ricardo44",
                    Email = "ricardomorales@outlook.com",
                    Name = "Ricardo",
                    Surname = "Morales",
                    MinimalDescription = "Mechanical engineer with a passion for automotive design.",
                    BirthDate = new DateOnly(1983, 3, 10),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f"),
                    CityId = 60274,
                    DNI = "307977824",
                    Phone = "54-1115281503",
                    Linkedin = "https://www.linkedin.com/in/rosa78",
                    Email = "rosagonzalez@outlook.com",
                    Name = "Rosa",
                    Surname = "Gonzalez",
                    MinimalDescription = "Biotechnologist with extensive research experience in genetic engineering.",
                    BirthDate = new DateOnly(1978, 11, 22),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea"),
                    CityId = 60274,
                    DNI = "307977825",
                    Phone = "54-1115281504",
                    Linkedin = "https://www.linkedin.com/in/ignacio99",
                    Email = "ignacio@outlook.com",
                    Name = "Ignacio",
                    Surname = "Romero",
                    MinimalDescription = "Ingeniero en sistemas con experiencia en desarrollo web y aplicaciones móviles.",
                    BirthDate = new DateOnly(1990, 4, 12),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819"),
                    CityId = 60274,
                    DNI = "307977826",
                    Phone = "54-1115281505",
                    Linkedin = "https://www.linkedin.com/in/andrea43",
                    Email = "andrearamirez@outlook.com",
                    Name = "Andrea",
                    Surname = "Ramirez",
                    MinimalDescription = "Contadora pública con experiencia en auditoría y consultoría financiera.",
                    BirthDate = new DateOnly(1985, 9, 8),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21"),
                    CityId = 60274,
                    DNI = "307977827",
                    Phone = "54-1115281506",
                    Linkedin = "https://www.linkedin.com/in/victor88",
                    Email = "victorgarcia@outlook.com",
                    Name = "Victor",
                    Surname = "Garcia",
                    MinimalDescription = "Licenciado en administración de empresas con especialización en gestión de proyectos.",
                    BirthDate = new DateOnly(1988, 12, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2"),
                    CityId = 60274,
                    DNI = "307977828",
                    Phone = "54-1115281507",
                    Linkedin = "https://www.linkedin.com/in/lorena56",
                    Email = "lorenadiaz@outlook.com",
                    Name = "Lorena",
                    Surname = "Diaz",
                    MinimalDescription = "Diseñadora gráfica con experiencia en branding y diseño de interfaces.",
                    BirthDate = new DateOnly(1983, 7, 18),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49"),
                    CityId = 60274,
                    DNI = "307977829",
                    Phone = "54-1115281508",
                    Linkedin = "https://www.linkedin.com/in/carlos77",
                    Email = "carloshernandez@outlook.com",
                    Name = "Carlos",
                    Surname = "Hernandez",
                    MinimalDescription = "Ingeniero industrial con experiencia en gestión de la cadena de suministro.",
                    BirthDate = new DateOnly(1980, 5, 29),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e"),
                    CityId = 60274,
                    DNI = "307977830",
                    Phone = "54-1115281509",
                    Linkedin = "https://www.linkedin.com/in/miriam12",
                    Email = "miriamlopez@outlook.com",
                    Name = "Miriam",
                    Surname = "Lopez",
                    MinimalDescription = "Psicóloga clínica con experiencia en terapia cognitivo-conductual.",
                    BirthDate = new DateOnly(1987, 11, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2"),
                    CityId = 60274,
                    DNI = "307977831",
                    Phone = "54-1115281510",
                    Linkedin = "https://www.linkedin.com/in/marcos43",
                    Email = "marcosperez@outlook.com",
                    Name = "Marcos",
                    Surname = "Perez",
                    MinimalDescription = "Abogado especializado en derecho penal y procesal penal.",
                    BirthDate = new DateOnly(1982, 8, 17),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885"),
                    CityId = 60274,
                    DNI = "307977832",
                    Phone = "54-1115281511",
                    Linkedin = "https://www.linkedin.com/in/patricia99",
                    Email = "patriciaflores@outlook.com",
                    Name = "Patricia",
                    Surname = "Flores",
                    MinimalDescription = "Enfermera con experiencia en cuidados intensivos y emergencias médicas.",
                    BirthDate = new DateOnly(1989, 3, 7),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb"),
                    CityId = 60274,
                    DNI = "307977833",
                    Phone = "54-1115281512",
                    Linkedin = "https://www.linkedin.com/in/juliana78",
                    Email = "julianagonzalez@yahoo.com",
                    Name = "Juliana",
                    Surname = "Gonzalez",
                    MinimalDescription = "Profesora de educación primaria con enfoque en enseñanza de matemáticas.",
                    BirthDate = new DateOnly(1984, 5, 12),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241"),
                    CityId = 60274,
                    DNI = "307977834",
                    Phone = "54-1115281513",
                    Linkedin = "https://www.linkedin.com/in/roberto45",
                    Email = "robertolopez@yahoo.com",
                    Name = "Roberto",
                    Surname = "Lopez",
                    MinimalDescription = "Ingeniero civil con experiencia en diseño y supervisión de obras públicas.",
                    BirthDate = new DateOnly(1980, 10, 3),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e"),
                    CityId = 60274,
                    DNI = "307977835",
                    Phone = "54-1115281514",
                    Linkedin = "https://www.linkedin.com/in/maria33",
                    Email = "maria33@gmail.com",
                    Name = "Maria",
                    Surname = "Bogado",
                    MinimalDescription = "Apasionada por la innovación y el desarrollo de software.",
                    BirthDate = new DateOnly(1990, 4, 18),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("80120fd9-ade7-4cd0-9dda-7b733e02d7cd"),
                    CityId = 60274,
                    DNI = "307977836",
                    Phone = "54-1115281515",
                    Linkedin = "https://www.linkedin.com/in/carlos22",
                    Email = "carlos22@hotmail.com",
                    Name = "Carlos",
                    Surname = "Pérez",
                    MinimalDescription = "Apasionado por la tecnología, con experiencia en desarrollo web.",
                    BirthDate = new DateOnly(1985, 10, 29),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("0e5a9aab-eb68-4ca9-8b80-ea7bef076946"),
                    CityId = 60274,
                    DNI = "307977837",
                    Phone = "54-1115281516",
                    Linkedin = "https://www.linkedin.com/in/laura11",
                    Email = "laura11@yahoo.com",
                    Name = "Laura",
                    Surname = "González",
                    MinimalDescription = "Desarrolladora de software con pasión por la innovación tecnológica.",
                    BirthDate = new DateOnly(1982, 12, 8),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("0b450794-1b65-4d42-8df7-05b57b970454"),
                    CityId = 60274,
                    DNI = "307977838",
                    Phone = "54-1115281517",
                    Linkedin = "https://www.linkedin.com/in/jose99",
                    Email = "jose99@gmail.com",
                    Name = "Jose",
                    Surname = "Martínez",
                    MinimalDescription = "Apasionado por la programación y la resolución de problemas.",
                    BirthDate = new DateOnly(1995, 7, 3),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730"),
                    CityId = 60274,
                    DNI = "307977839",
                    Phone = "54-1115281518",
                    Linkedin = "https://www.linkedin.com/in/ana88",
                    Email = "ana88@hotmail.com",
                    Name = "Ana",
                    Surname = "Rodríguez",
                    MinimalDescription = "Desarrolladora web con experiencia en proyectos innovadores.",
                    BirthDate = new DateOnly(1988, 5, 21),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd"),
                    CityId = 60274,
                    DNI = "307977840",
                    Phone = "54-1115281519",
                    Linkedin = "https://www.linkedin.com/in/pedro77",
                    Email = "pedro77@yahoo.com",
                    Name = "Pedro",
                    Surname = "Gómez",
                    MinimalDescription = "Desarrollador de software con habilidades en diseño de interfaces.",
                    BirthDate = new DateOnly(1980, 9, 12),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9"),
                    CityId = 60274,
                    DNI = "307977841",
                    Phone = "54-1115281520",
                    Linkedin = "https://www.linkedin.com/in/isabel66",
                    Email = "isabel66@gmail.com",
                    Name = "Isabel",
                    Surname = "García",
                    MinimalDescription = "Ingeniera de software con experiencia en desarrollo ágil.",
                    BirthDate = new DateOnly(1977, 5, 7),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16"),
                    CityId = 60274,
                    DNI = "307977842",
                    Phone = "54-1115281521",
                    Linkedin = "https://www.linkedin.com/in/david55",
                    Email = "david55@hotmail.com",
                    Name = "David",
                    Surname = "Gutiérrez",
                    MinimalDescription = "Desarrollador full-stack con experiencia en tecnologías modernas.",
                    BirthDate = new DateOnly(1992, 11, 30),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da"),
                    CityId = 60274,
                    DNI = "307977843",
                    Phone = "54-1115281522",
                    Linkedin = "https://www.linkedin.com/in/monica44",
                    Email = "monica44@yahoo.com",
                    Name = "Monica",
                    Surname = "Martínez",
                    MinimalDescription = "Ingeniera de software con experiencia en análisis de datos.",
                    BirthDate = new DateOnly(1988, 3, 18),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423"),
                    CityId = 60274,
                    DNI = "307977844",
                    Phone = "54-1115281523",
                    Linkedin = "https://www.linkedin.com/in/fernando33",
                    Email = "fernando33@gmail.com",
                    Name = "Fernando",
                    Surname = "López",
                    MinimalDescription = "Desarrollador web especializado en aplicaciones móviles.",
                    BirthDate = new DateOnly(1985, 7, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9"),
                    CityId = 60274,
                    DNI = "307977845",
                    Phone = "54-1115281524",
                    Linkedin = "https://www.linkedin.com/in/luis22",
                    Email = "luis22@hotmail.com",
                    Name = "Luis",
                    Surname = "Martínez",
                    MinimalDescription = "Ingeniero de software apasionado por la inteligencia artificial.",
                    BirthDate = new DateOnly(1990, 12, 3),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6"),
                    CityId = 60274,
                    DNI = "307977846",
                    Phone = "54-1115281525",
                    Linkedin = "https://www.linkedin.com/in/carmen11",
                    Email = "carmen11@yahoo.com",
                    Name = "Carmen",
                    Surname = "Sánchez",
                    MinimalDescription = "Desarrolladora de software con experiencia en sistemas distribuidos.",
                    BirthDate = new DateOnly(1985, 6, 17),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7"),
                    CityId = 60274,
                    DNI = "307977847",
                    Phone = "54-1115281526",
                    Linkedin = "https://www.linkedin.com/in/pablo99",
                    Email = "pablo99@gmail.com",
                    Name = "Pablo",
                    Surname = "González",
                    MinimalDescription = "Desarrollador de software con experiencia en proyectos de e-commerce.",
                    BirthDate = new DateOnly(1989, 8, 25),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002"),
                    CityId = 60274,
                    DNI = "307977848",
                    Phone = "54-1115281527",
                    Linkedin = "https://www.linkedin.com/in/elena88",
                    Email = "elena88@hotmail.com",
                    Name = "Elena",
                    Surname = "Gómez",
                    MinimalDescription = "Desarrolladora de software con experiencia en front-end.",
                    BirthDate = new DateOnly(1983, 4, 9),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("153ff2f4-ccb7-43b1-b163-8f995adb1d13"),
                    CityId = 60274,
                    DNI = "307977849",
                    Phone = "54-1115281528",
                    Linkedin = "https://www.linkedin.com/in/diego77",
                    Email = "diego77@yahoo.com",
                    Name = "Diego",
                    Surname = "Hernández",
                    MinimalDescription = "Ingeniero de software especializado en seguridad informática.",
                    BirthDate = new DateOnly(1987, 11, 21),
                    Status = true
                },
                new Applicant
                {
                    UserId = Guid.Parse("7c5891f9-9fac-4dbf-9afd-2c9e01759e20"),
                    CityId = 60274,
                    DNI = "307977850",
                    Phone = "54-1115281529",
                    Linkedin = "https://www.linkedin.com/in/alejandra66",
                    Email = "alejandra66@gmail.com",
                    Name = "Alejandra",
                    Surname = "García",
                    MinimalDescription = "Desarrolladora full-stack con experiencia en aplicaciones web.",
                    BirthDate = new DateOnly(1992, 5, 8),
                    Status = true
                });
        }
    }
}
