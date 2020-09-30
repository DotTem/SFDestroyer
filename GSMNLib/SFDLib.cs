using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GSMNLib
{
    public class SFDLib
    {
        public static void Scanner(string mainPath, List<string> tempFilesList, List<string> mainFilesList, List<string> dirsList, DateTimePicker dateTimePickerFrom, DateTimePicker dateTimePickerTo)
        {
            try
            {
                int countFilesForDir = 5;
                //Get files and dirs in folder
                string[] root = Directory.GetFileSystemEntries(mainPath);
                //scanning place from a to z
                foreach (var curElement in root)
                {
                    //if dir
                    if (Directory.Exists(curElement))
                        Scanner(curElement, tempFilesList, mainFilesList, dirsList, dateTimePickerFrom, dateTimePickerTo);
                    //if file
                    else if (File.Exists(curElement) && tempFilesList.Count <= countFilesForDir && dateTimePickerFrom.Value.Ticks < Convert.ToInt64(File.GetLastWriteTime(curElement).Ticks) && Convert.ToInt64(File.GetLastWriteTime(curElement).Ticks) < dateTimePickerTo.Value.Ticks)
                        tempFilesList.Add(curElement);
                    else if (tempFilesList.Count > countFilesForDir)
                    {
                        dirsList.Add(mainPath);
                        tempFilesList.Clear();
                        break;
                    }
                }
                if (tempFilesList.Count > 0)
                {
                    foreach (string tempfiles in tempFilesList)
                    {
                        mainFilesList.Add(tempfiles);
                        tempFilesList.Clear();
                    }
                }
            }
            catch { }
        }

        public static void FilteredScanner(string mainPath, List<string> tempFilesList, List<string> mainFilesList, List<string> dirsList, string[] filter, DateTimePicker dateTimePickerFrom, DateTimePicker dateTimePickerTo)
        {
            try
            {
                int countFilesForDir = 5;
                //Get files and dirs in folder
                string[] root = Directory.GetFileSystemEntries(mainPath);

                foreach (string curElement in root)
                {
                    //if Dir
                    if (Directory.Exists(curElement))
                        FilteredScanner(curElement, tempFilesList, mainFilesList, dirsList, filter, dateTimePickerFrom, dateTimePickerTo);
                    //if File
                    else if (File.Exists(curElement) && tempFilesList.Count <= countFilesForDir && dateTimePickerFrom.Value.Ticks < Convert.ToInt64(File.GetLastWriteTime(curElement).Ticks) && Convert.ToInt64(File.GetLastWriteTime(curElement).Ticks) < dateTimePickerTo.Value.Ticks)
                    {
                        for (int elemCount = 0; elemCount < filter.Length; elemCount++)
                        {
                            if (Path.GetExtension(curElement) == filter[elemCount])
                            {
                                tempFilesList.Add(curElement);
                            }
                        }
                    }
                    else if (tempFilesList.Count > countFilesForDir)
                    {
                        dirsList.Add(mainPath);
                        tempFilesList.Clear();
                        break;
                    }
                }
                if (tempFilesList.Count > 0)
                    {
                    foreach (string tempfiles in tempFilesList)
                    {
                            mainFilesList.Add(tempfiles);
                            tempFilesList.Clear();
                    }
                }
            }
            catch { }
        }

        public static TreeNode CreateDirectoryNode(string path)
        {
            TreeNode node = new TreeNode();
            node.Nodes.Add(path);
            return node;
        }

    }
}
