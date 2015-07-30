using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Summary description for CheckE
/// </summary>
public class CheckE
{
	public CheckE()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool checkstringnull(string n)
    {
        if (n == "" || n == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool checkstring(string n,int i)
    {
        if (n.Length<=i)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool checknumber(string n)
    {
        try
        {
            float i = float.Parse(n);
            if (i > 0 && i<=10000)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool checkQuanlity(string n)
    {
        try
        {
            int i = int.Parse(n);
            if (i > 0 && i <=10000)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    public bool checkEmail(string n)
    {
        string pattern = @"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$";
        Match match = Regex.Match(n.Trim(), pattern, RegexOptions.IgnoreCase);

        if (match.Success && n.Length<50)
            return true;
        else
            return false;
    }
    public bool CheckFileType(string fileName)
    {

        string ext = Path.GetExtension(fileName);
        if (fileName.Length < 100)
        {
            switch (ext.ToLower())
            {

                case ".gif":

                    return true;

                case ".png":

                    return true;

                case ".jpg":

                    return true;

                case ".jpeg":

                    return true;

                default:

                    return false;

            }
        }
        else
        {
            return false;
        }
       

    }
}