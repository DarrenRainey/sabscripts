﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Movies
{
    class Program
    {
        private static DirectoryInfo _logDir;
        private static string _logFile;
        private static DirectoryInfo _movieDir;
        private static string _xbmcMoviePath;
        private static DirectoryInfo _hdMovieDir;
        private static string _xbmcHdMoviePath;
        private static DirectoryInfo _ipodMovieDir;
        private static string _xbmcHost;
        private static int _xbmcPort = 9777;
        private static bool _updateXbmc;
        private static bool _notifyXbmc;
        private static bool _cleanLibrary;
        private static bool _xbmcOsWindows;
        private static bool _deleteFolder;

        static void Main(string[] args)
        {
            LoadConfig();

            string moviePath = args[0]; //Get moviePath from first CMD Line argument
            string movieNameSab = args[2]; //Get movieName from third CMD Line argument


            string movieFilename = _movieDir + "\\" + movieNameSab + ".avi";
                //Create movieFilename from movieDir + movieName
            string hdMovieMkvFilename = _hdMovieDir + "\\" + movieNameSab + ".mkv";
                //Create hdMovieMkvFilename from hdMovieDir + movieName
            string hdMovieWmvFilename = _hdMovieDir + "\\" + movieNameSab + ".wmv";
                //Create hdMovieWmvFilename from hdMovieDir + movieName
            string ipodMovieFilename = _ipodMovieDir + "\\" + movieNameSab + ". mp4";
                //Create ipodMovieFilename from ipodMovieDir + movieName
            string mencoderOptions = "-forceidx -ovc copy -oac copy -o"; //Options for mencoder (static)

            DirectoryInfo moviePathInfo = new DirectoryInfo(moviePath);

            string movieName = movieNameSab;
            string patternYear = @"(?<Year>\d{4})";

            Match titleMatchYear = Regex.Match(movieNameSab, patternYear);

            if (titleMatchYear.Success)
            {
                int year = 0;
                Int32.TryParse(titleMatchYear.Groups["Year"].Value, out year);

                string[] titleSplit = Regex.Split(movieNameSab, patternYear);

                movieName = titleSplit[0].TrimEnd(' ', '(', '.').Replace('.', ' ') + " (" + year + ")";
            }

            string[] filesSizeTest = Directory.GetFiles(moviePath, "*.*", SearchOption.AllDirectories);
                //Search moviePath for all Files, including sub-folders
            Array.Sort(filesSizeTest); //Sort Array :)

            foreach (string fileSizeTest in filesSizeTest) //Check for sample files that SAB may have missed
            {
                FileInfo fileSizeTestInfo = new FileInfo(fileSizeTest); //Create FileInfo
                if (fileSizeTestInfo.Length < 140000000)
                    //If File is less than 140MB consider it a sample (For HD Samples)
                {
                    File.Delete(fileSizeTest); //Delete the sample file
                }
            }

            string[] aviFiles = Directory.GetFiles(moviePath, "*.avi", SearchOption.AllDirectories);
                //Search moviePath for AVI Files, including sub-folders
            Array.Sort(aviFiles); //Sort Array :)

            if (aviFiles.Length == 1) //If Only one AVI was found rename and move file
            {
                string aviFile = aviFiles[0]; //Set aviFile to first & only file in aviFiles Array
                FileInfo aviFileInfo = new FileInfo(aviFile); //Create file info for getting file size
                long aviSize = aviFileInfo.Length; //Create long to store AVI File Size
                if (aviSize > 150000000) //If avi is greater than 150MB then continue
                {
                    if (_deleteFolder)
                    {
                        //File.Move(aviFile, movieFilename); //Move/Rename File
                        aviFileInfo.MoveTo(movieFilename);
                        Directory.Delete(moviePath, true); //Delete directory + all files
                    }

                    else
                    {
                        string aviMovieDir = _movieDir + "\\" + movieName;
                        string aviMovieDirFilename = aviMovieDir + "\\" + movieName + ".avi";
                        Directory.CreateDirectory(aviMovieDir);
                        aviFileInfo.MoveTo(aviMovieDirFilename);
                        Directory.Delete(moviePath, true); //Delete old directory + all files
                    }

                    if (_updateXbmc)
                    {
                        string xbmcUpdate = UpdateXbmc(_movieDir.ToString(), movieName, "standard");
                        //string xbmcUpdate = UpdateXbmc();
                    }
                    return; //Exit
                }
            }

            else if (aviFiles.Length == 2) //If two AVIs were found
            {
                string aviFileOne = aviFiles[0]; //Name aviFileOne to first file in Array
                string aviFileTwo = aviFiles[1]; //Name aviFileTwo to second file in Array
                FileInfo aviFileOneInfo = new FileInfo(aviFileOne); //Create FileInfo for aviFileOne
                FileInfo aviFileTwoInfo = new FileInfo(aviFileTwo); //Create FileInfo for aviFileTwo

                long aviOneSize = aviFileOneInfo.Length; //Create long to store file size
                long aviTwoSize = aviFileTwoInfo.Length; //Create long to store file size

                if (aviOneSize > 150000000 && aviTwoSize > 150000000) //Ensure that both files are actually
                {
                    if (_deleteFolder)
                    {
                        string mencoderCommand = mencoderOptions + " \"" + movieFilename + "\" \"" + aviFileOne +
                                                 "\" \"" + aviFileTwoInfo + "\"";
                            //Create string to hold commands to pass to mencoder
                        Process.Start("mencoder.exe", mencoderCommand).WaitForExit();
                            //Run mencoder on the two AVIs & wait for finish
                        Directory.Delete(moviePath, true); //Delete directory + all files
                    }

                    else
                    {
                        string aviMovieDir = _movieDir + "\\" + movieName;
                        movieFilename = aviMovieDir + "\\" + movieName + ".avi";
                        Directory.CreateDirectory(aviMovieDir);

                        Console.WriteLine(movieFilename);
                        Console.ReadKey();

                        string mencoderCommand = mencoderOptions + " \"" + movieFilename + "\" \"" + aviFileOne +
                                                 "\" \"" + aviFileTwoInfo + "\"";
                            //Create string to hold commands to pass to mencoder
                        Process.Start("mencoder.exe", mencoderCommand).WaitForExit();
                            //Run mencoder on the two AVIs & wait for finish
                        Directory.Delete(moviePath, true); //Delete old directory + all files
                    }
                    if (_updateXbmc)
                    {
                        string xbmcUpdate = UpdateXbmc(_movieDir.ToString(), movieName, "standard");
                        //string xbmcUpdate = UpdateXbmc();
                    }
                    return; //Exit
                }

                else
                {
                    //Too many AVI Files found - will have to manually check...
                }
            }

            else
            {
                //Too Many Files... abort!
            }

            string[] mkvFiles = Directory.GetFiles(moviePath, "*.mkv", SearchOption.AllDirectories);
                //Search moviePath for MKV Files, including sub-folders
            Array.Sort(mkvFiles); //Sort Array :)

            if (mkvFiles.Length == 1) //Ensure only one MKV was found
            {
                string mkvFile = mkvFiles[0]; //Create mkvFile from first & only string in Array
                FileInfo mkvFileInfo = new FileInfo(mkvFile); //Create FileInfo

                if (mkvFileInfo.Length > 120000000) //Ensure MKV is over 1200MB in size
                {
                    if (_deleteFolder)
                    {
                        //File.Move(mkvFile, hdMovieMkvFilename); //Move/Rename File
                        mkvFileInfo.MoveTo(hdMovieMkvFilename);
                        Directory.Delete(moviePath, true); //Delete directory + all files
                    }

                    else
                    {
                        string mkvMovieDir = _hdMovieDir + "\\" + movieName;
                        string mkvMovieDirFilename = mkvMovieDir + "\\" + movieName + ".mkv";
                        Directory.CreateDirectory(mkvMovieDir);
                        mkvFileInfo.MoveTo(mkvMovieDirFilename);
                        Directory.Delete(moviePath, true); //Delete old directory + all files
                        //}

                        if (_updateXbmc)
                        {
                            string xbmcUpdate = UpdateXbmc(_hdMovieDir.ToString(), movieName, "highdef");
                        }
                        return; //Exit
                    }
                }

                else
                {
                    //Too Many MKVs! Abort!
                }

                string[] wmvFiles = Directory.GetFiles(moviePath, "*.wmv", SearchOption.AllDirectories);
                    //Search moviePath for WMV Files, including sub-folders
                Array.Sort(wmvFiles); //Sort Array :)

                if (wmvFiles.Length == 1) //Ensure only one WMV was found
                {
                    string wmvFile = wmvFiles[0]; //Create wmvFile from first & only string in Array
                    FileInfo wmvFileInfo = new FileInfo(wmvFile); //Create FileInfo

                    if (wmvFileInfo.Length > 120000000) //Ensure WMV is over 1200MB in size
                    {
                        if (_deleteFolder)
                        {
                            //File.Move(wmvFile, hdMovieWmvFilename); //Move/Rename File
                            wmvFileInfo.MoveTo(hdMovieWmvFilename);
                            Directory.Delete(moviePath, true); //Delete directory + all files
                        }

                        else
                        {
                            string wmvMovieDir = _hdMovieDir + "\\" + movieName;
                            string wmvMovieDirFilename = wmvMovieDir + "\\" + movieName + ".wmv";
                            Directory.CreateDirectory(wmvMovieDir);
                            wmvFileInfo.MoveTo(wmvMovieDirFilename);
                            Directory.Delete(moviePath, true);
                        }


                        if (_updateXbmc)
                        {
                            string xbmcUpdate = UpdateXbmc(_hdMovieDir.ToString(), movieName, "highdef");
                        }
                        return; //Exit
                    }
                }

                else
                {
                    //Too Many WMVs! Abort!
                }

                string[] mp4Files = Directory.GetFiles(moviePath, "*.mp4", SearchOption.AllDirectories);
                    //Search moviePath for MP4 Files, including sub-folders
                Array.Sort(mp4Files); //Sort Array :)

                if (mp4Files.Length == 1) //Ensure only one MP4 was found
                {
                    string mp4File = mp4Files[0]; //Create wmvFile from first & only string in Array
                    FileInfo mp4FileInfo = new FileInfo(mp4File); //Create FileInfo

                    if (mp4FileInfo.Length > 100000000) //Ensure MP4 is over 100MB in size
                    {
                        if (_deleteFolder)
                        {
                            //File.Move(mp4File, ipodMovieFilename); //Move/Rename File
                            mp4FileInfo.MoveTo(ipodMovieFilename);
                            Directory.Delete(moviePath, true); //Delete directory + all files
                        }

                        else
                        {
                            ipodMovieFilename = moviePath + "\\" + movieName + ".mp4";
                            File.Move(mp4File, ipodMovieFilename);

                            string mp4MovieDir = _ipodMovieDir + "\\" + movieName;
                            string mp4MovieDirFilename = mp4MovieDir + "\\" + movieName + ".mp4";
                            Directory.CreateDirectory(mp4MovieDir);
                            mp4FileInfo.MoveTo(mp4MovieDirFilename);
                            Directory.Delete(moviePath, true);
                        }
                        return; //Exit
                    }
                }

                else
                {
                    //Too Many MP4s! Abort!
                }
            }
        }

        private static void LoadConfig()
        {
            _logDir = new DirectoryInfo(ConfigurationManager.AppSettings["logDir"]); //Get logDir from app.config
            _logFile = _logDir + @"\Movies.txt"; // Log File 

            _movieDir = new DirectoryInfo(ConfigurationManager.AppSettings["movieDir"]);
            _hdMovieDir = new DirectoryInfo(ConfigurationManager.AppSettings["HdMovieDir"]);
            _ipodMovieDir = new DirectoryInfo(ConfigurationManager.AppSettings["ipodMovieDir"]);

            _xbmcMoviePath = ConfigurationManager.AppSettings["xbmcMoviePath"];
            _xbmcHdMoviePath = ConfigurationManager.AppSettings["xbmcHdMoviePath"];

            _xbmcHost = ConfigurationManager.AppSettings["xbmcHost"];
            string xbmcPortS = ConfigurationManager.AppSettings["xbmcPort"];
            int.TryParse(xbmcPortS, out _xbmcPort);

            _updateXbmc = Convert.ToBoolean(ConfigurationManager.AppSettings["updateXbmc"]);
            _notifyXbmc = Convert.ToBoolean(ConfigurationManager.AppSettings["notifyXbmc"]);
            _cleanLibrary = Convert.ToBoolean(ConfigurationManager.AppSettings["cleanLibrary"]);

            _xbmcOsWindows = Convert.ToBoolean(ConfigurationManager.AppSettings["xbmcOsWindows"]);

            _deleteFolder = Convert.ToBoolean(ConfigurationManager.AppSettings["deleteFolder"]);
        }

        private static string UpdateXbmc()
        {
            string movieDir = ConfigurationManager.AppSettings["movieDir"];
            string xbmcMoviePath = ConfigurationManager.AppSettings["xbmcMoviePath"];
            string xbmcInfo = ConfigurationManager.AppSettings["xbmcInfo"];
            string xbmcUsername = ConfigurationManager.AppSettings["xbmcUsername"];
            string xbmcPassword = ConfigurationManager.AppSettings["xbmcPassword"];
            string xbmcPath = null;

            if (movieDir.ToLower() != xbmcMoviePath.ToLower())
            {
                xbmcPath = movieDir.Replace(movieDir, xbmcMoviePath);
                xbmcPath = xbmcPath.Replace('\\', '/');
            }

            else
            {
                xbmcPath = movieDir;
            }

            try
            {
                string xbmcUrl = "http://" + xbmcInfo + "/xbmcCmds/xbmcHttp?command=ExecBuiltIn&parameter=XBMC.updatelibrary(video)";

                HttpWebRequest xbmcRequest = (HttpWebRequest)WebRequest.Create(xbmcUrl);
                xbmcRequest.Timeout = 10000;
                xbmcRequest.Credentials = new NetworkCredential(xbmcUsername, xbmcPassword);
                xbmcRequest.PreAuthenticate = true;

                HttpWebResponse xbmcRepsonse = (HttpWebResponse)xbmcRequest.GetResponse();
                xbmcRepsonse.Close();
            }
            catch
            {
                string errorMsg = "An error occured connecting to XBMC";
                return errorMsg;
            }

            string xbmcUpdating = "XBMC is Updating";
            return xbmcUpdating;
        }

        private static string UpdateXbmc(string moviePath)
        {
            string downloadMoviePath = moviePath;
            string xbmcHdMoviePath = ConfigurationManager.AppSettings["xbmcHdMoviePath"];
            string xbmcInfo = ConfigurationManager.AppSettings["xbmcInfo"];
            string xbmcUsername = ConfigurationManager.AppSettings["xbmcUsername"];
            string xbmcPassword = ConfigurationManager.AppSettings["xbmcPassword"];
            string xbmcPath = null;

            if (downloadMoviePath.ToLower() != xbmcHdMoviePath.ToLower())
            {
                xbmcPath = moviePath.Replace(downloadMoviePath, xbmcHdMoviePath);
                xbmcPath = xbmcPath.Replace('\\', '/');
            }

            else
            {
                xbmcPath = moviePath;
            }

            try
            {
                string xbmcUrl = "http://" + xbmcInfo + "/xbmcCmds/xbmcHttp?command=ExecBuiltIn&parameter=XBMC.updatelibrary(video," + xbmcPath + ")";

                HttpWebRequest xbmcRequest = (HttpWebRequest)WebRequest.Create(xbmcUrl);
                xbmcRequest.Timeout = 10000;
                xbmcRequest.Credentials = new NetworkCredential(xbmcUsername, xbmcPassword);
                xbmcRequest.PreAuthenticate = true;

                HttpWebResponse xbmcRepsonse = (HttpWebResponse)xbmcRequest.GetResponse();
                xbmcRepsonse.Close();
            }
            catch
            {
                string errorMsg = "An error occured connecting to XBMC";
                return errorMsg;
            }

            string xbmcUpdating = "XBMC is Updating";
            return xbmcUpdating;
        }

        private static string UpdateXbmc(string moviePath, string movieName, string category)
        {
            string xbmcUpdating = null;
            string xbmcPath = null;

            if (category == "standard")
            {

                if (_movieDir.ToString().ToLower() != _xbmcMoviePath.ToLower())
                {
                    xbmcPath = _movieDir.ToString().Replace(_movieDir.ToString(), _xbmcMoviePath);

                    if (!_xbmcOsWindows)
                        xbmcPath = xbmcPath.Replace('\\', '/');
                }

                else
                {
                    xbmcPath = moviePath;
                }
            }

            else if (category == "highdef")
            {

                if (_hdMovieDir.ToString().ToLower() != _xbmcHdMoviePath.ToLower())
                {
                    xbmcPath = _hdMovieDir.ToString().Replace(_hdMovieDir.ToString(), _xbmcHdMoviePath);

                    if (!_xbmcOsWindows)
                        xbmcPath = xbmcPath.Replace('\\', '/');
                }

                else
                {
                    xbmcPath = moviePath;
                }
            }

            else
            {
                Console.WriteLine("Format is unknown... Code Fail");
            }

            if (!XBMC.EventClient.Current.Connected)
                XBMC.EventClient.Current.Connect(_xbmcHost, _xbmcPort);

            if (XBMC.EventClient.Current.Connected)
            {
                string xbmcLibraryUpdate = "UpdateLibrary(video," + xbmcPath + ")";

                XBMC.EventClient.Current.SendAction(xbmcLibraryUpdate, "");
                if (_notifyXbmc)
                    XBMC.EventClient.Current.SendNotification("Movie Downloaded", movieName, XBMC.IconType.ICON_PNG, "sabnzbd");
                if (_cleanLibrary)
                    XBMC.EventClient.Current.SendAction("CleanLibrary(video)", "");
                xbmcUpdating = "XBMC is Updating";
                return xbmcUpdating;
            }

            xbmcUpdating = "Could not connect to XBMC";
            return xbmcUpdating;
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
            File.AppendAllText(_logFile, message + "\n");
        }
    }
}
