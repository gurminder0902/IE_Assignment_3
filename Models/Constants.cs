﻿using System;

namespace CSV.Models
{
    public class Constants
    {

        public readonly Student Student = new Student { StudentId = "200450635", FirstName = "Gurminder", LastName = "Singh" };

        public class Locations
        {
            public readonly static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            public readonly static string ExePath = Environment.CurrentDirectory;

            public readonly static string ContentFolder = $"{ExePath}\\..\\..\\..\\Content";
            public readonly static string DataFolder = $"{ContentFolder}\\Data";
            public readonly static string ImagesFolder = $"{ContentFolder}\\Images";
            public readonly static string FilesFolder = $"{ContentFolder}\\Files";

            public const string InfoFile = "info.csv";
            public const string ImageFile = "myimage.jpg";
       

            public readonly static string StudentCSVFile = "/Users/gurmindersingh/Downloads/assignment3/Content/Data/students.csv";
            public readonly static string StudentJSONFile = "/Users/gurmindersingh/Downloads/assignment3/Content/Data/students.json";
            public static readonly string StudentXMLFile = "/Users/gurmindersingh/Downloads/assignment3/Content/Data/students.xml";

           

        }

        public class FTP
        {
            public const string Username = @"bdat100119f\bdat1001";
            public const string Password = "bdat1001";

            public const string BaseUrl = "ftp://waws-prod-dm1-127.ftp.azurewebsites.windows.net/bdat1001-20914";
            public const string MyDirectory = "/200450635 Gurminder Singh";
            public const string CSVUploadLocation = BaseUrl + MyDirectory + "/students.csv";
            public const string JSONUploadLocation = BaseUrl + MyDirectory + "/students.json";
            public const string XMLUploadLocation = BaseUrl + MyDirectory + "/students.xml";

            public const int OperationPauseTime = 10000;

        }
    }
}
