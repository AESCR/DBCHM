﻿using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using Top._51Try.Data;

namespace DBCHM
{
    public static class FormUtils
    {
        static FormUtils()
        {
            DictDBType = EnumExt<DBType>.All();

            DictDBType.Remove(DBType.OracleDDTek.ToString());
            DictDBType.Remove(DBType.SQLite.ToString());

        }
        /// <summary>
        /// 所有数据库类型 对应的端口
        /// </summary>
        public static readonly Dictionary<string, string> DictPort = new Dictionary<string, string>()
        {
            { DBType.SqlServer.ToString(),"1433"},
             { DBType.MySql.ToString(),"3306"},
                { DBType.Oracle.ToString(),"1521"},
                    //{ DBType.OracleDDTek.ToString(),"1521"},            
                { DBType.PostgreSql.ToString(),"5432"},
        };

        /// <summary>
        /// 所有数据库类型
        /// </summary>
        public static Dictionary<string, DBType> DictDBType
        {
            get; private set;
        }


        /// <summary>
        /// 是否正常的Close
        /// </summary>
        public static bool IsOK_Close { get; set; } = false;


        public static ProgressArg ProgArg { get; set; }



        /// <summary>
        ///为文件夹添加users，everyone用户组的完全控制权限
        /// </summary>
        /// <param name="dirPath"></param>
        public static void AddSecurityControll2Folder(string dirPath)
        {
            //获取文件夹信息
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if (dir.Exists)
            {
                //获得该文件夹的所有访问权限
                System.Security.AccessControl.DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.All);
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                //添加ereryone用户组的访问权限规则 完全控制权限
                FileSystemAccessRule everyoneFileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                //添加Users用户组的访问权限规则 完全控制权限
                FileSystemAccessRule usersFileSystemAccessRule = new FileSystemAccessRule("Users", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                bool isModified = false;
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, everyoneFileSystemAccessRule, out isModified);
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, usersFileSystemAccessRule, out isModified);
                //设置访问权限
                dir.SetAccessControl(dirSecurity);
            }
        }


        /// <summary>
        /// 判断磁盘路径下是否安装存在某个文件，最后返回存在某个文件的路径
        /// </summary>
        /// <param name="installPaths"></param>
        /// <param name="installPath"></param>
        /// <returns></returns>
        public static bool IsInstall(string[] installPaths, out string installPath)
        {
            installPath = string.Empty;
            var driInfos = DriveInfo.GetDrives();
            foreach (DriveInfo dInfo in driInfos)
            {
                if (dInfo.DriveType == DriveType.Fixed)
                {
                    foreach (string ipath in installPaths)
                    {
                        string path = Path.Combine(dInfo.Name, ipath);
                        if (File.Exists(path))
                        {
                            installPath = path;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
