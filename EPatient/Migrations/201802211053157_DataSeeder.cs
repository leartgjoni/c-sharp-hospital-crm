namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataSeeder : DbMigration
    {
        public override void Up()
        {
            //Create pavilions
            Sql(@"INSERT INTO [dbo].[Pavilions] ([Name]) VALUES ('Pediatria')");
            Sql(@"INSERT INTO [dbo].[Pavilions] ([Name]) VALUES ('Otorinolaringologjia')");
            Sql(@"INSERT INTO [dbo].[Pavilions] ([Name]) VALUES ('Stomatologjia')");
            Sql(@"INSERT INTO [dbo].[Pavilions] ([Name]) VALUES ('Oftamologjia')");

            //Create users with timetables
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId]) VALUES ('Operator', 'Operator', 'operator', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 2)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('John', 'Doe', 'johndoe', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 1)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Roman', 'Petermen', 'romanpetermen', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 1)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Wanda', 'Hans', 'wandahans', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 4, 1)");

            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Joseph', 'Smith', 'josephsmith', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 2)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Hector', 'Orum', 'hectororum', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 2)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Marcus', 'Kula', 'marcuskula', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 4, 2)");

            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Iliana', 'Rizzi', 'ilianarizzi', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 3)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Kisha', 'File', 'kishafile', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 3)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Erick', 'Lightle', 'ericklightle', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 4, 3)");

            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Angila', 'Kuo', 'angilakuo', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 4)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Kris', 'Larson', 'krislarson', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 3, 4)");
            Sql(@"INSERT INTO [dbo].[Users] ([Name],[Surname],[Username],[Password],[RoleId],[PavilionId]) VALUES ('Emily', 'Walson', 'emilywalson', 'jbdGxQpaiR93MPnkhe8cE4PblcMUYYy+3ke4FYJjR4Xlms+V', 4, 4)");

            for (int i = 3; i <= 14; i++)
            {
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (1, '08:00', '16:00', 0, " + i + ")");
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (2, '08:00', '16:00', 0, " + i + ")");
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (3, '08:00', '16:00', 0, " + i + ")");
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (4, '08:00', '16:00', 0, " + i + ")");
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (5, '08:00', '16:00', 0, " + i + ")");
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (6, '00:00', '00:00', 1, " + i + ")");
                Sql(@"INSERT INTO [dbo].[Timetables] ([DayOfTheWeek],[StartTime],[EndTime],[DayOff],[UserId]) VALUES (7, '00:00', '00:00', 1, " + i + ")");

            }

            //Create Services
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Konsulte', 1500, 20, 1)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Vizite viroze', 2500, 35, 1)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Analize gjaku femije', 2000, 20, 1)");

            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Konsulte', 1500, 20, 2)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Analize fyti', 2500, 30, 2)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Eko', 2000, 30, 2)");

            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Kontroll dhembesh', 5000, 20, 3)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Grafi', 1800, 15, 3)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Mbushje dhemballe', 2500, 45, 3)");

            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Vizite per syte', 4300, 20, 4)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Nderhyrje me lazer', 50000, 35, 4)");
            Sql(@"INSERT INTO [dbo].[Services] ([Name], [Price], [Duration], [PavilionId]) VALUES ('Trajtim te Cornea', 6500, 50, 4)");

            //Create Patients with reservations.
            Sql(@"INSERT INTO [dbo].[Patients] ([Name],[Surname],[Birthday],[Gender],[Phone],[Email],[Allergies]) VALUES ('Dex', 'Sandy', '1998-03-02', 0, '06845231', 'dexsandy@gmail.com', 'Latex, Gluten')");
            Sql(@"INSERT INTO [dbo].[Patients] ([Name],[Surname],[Birthday],[Gender],[Phone],[Email],[Allergies]) VALUES ('Meryl', 'Walter', '2015-03-08', 1, '0698447521', 'merylwalter@gmail.com', 'Tetracycline')");
            Sql(@"INSERT INTO [dbo].[Patients] ([Name],[Surname],[Birthday],[Gender],[Phone],[Email]) VALUES ('Jony', 'Kay', '1996-12-09', 1, '06712547', 'jonykay@gmail.com')");
            Sql(@"INSERT INTO [dbo].[Patients] ([Name],[Surname],[Birthday],[Gender],[Phone],[Email]) VALUES ('Velma', 'Doe', '1970-03-06', 0, '068784512', 'velmadoe@gmail.com')");
            Sql(@"INSERT INTO [dbo].[Patients] ([Name],[Surname],[Birthday],[Gender],[Phone],[Email],[Allergies]) VALUES ('Caleb', 'Prue', '1991-10-06', 1, '0698447521', 'calebprue@gmail.com', 'Penicillin')");

            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-21 08:00', '2018-02-21 08:30', 1, 6, 6, 0)");
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-22 12:00', '2018-02-22 12:20', 1, 7, 9, 0)");
                                                                                                          
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-21 08:00', '2018-02-21 08:30', 2, 1, 3, 0)");
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-22 12:00', '2018-02-22 12:30', 2, 2, 4, 0)");
                                                                                                          
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-21 08:00', '2018-02-21 08:30', 3, 10, 6, 0)");
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-22 12:00', '2018-02-22 12:30', 3, 8, 13, 0)");
                                                                                                          
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-21 08:00', '2018-02-21 08:30', 4, 10, 11, 0)");
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-22 12:00', '2018-02-22 12:30', 4, 12, 12, 0)");
                                                                                                          
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-21 08:00', '2018-02-21 08:30', 5, 4, 7, 0)");
            Sql(@"INSERT INTO [dbo].[Reservations] ([StartTime],[EndTime],[PatientId],[ServiceId],[UserId], [Paid]) VALUES ('2018-02-22 12:00', '2018-02-22 12:30', 5, 5, 8, 0)");

        }

        public override void Down()
        {
        }
    }
}
