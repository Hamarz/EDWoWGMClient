/*
          _______ _____  _______ _______ _______ 
         |    ___|     \|    ___|   |   |   |   |
         |    ___|  --  |    ___|       |   |   |
         |_______|_____/|_______|__|_|__|_______| 
     Copyright (C) 2014 EmuDevs <http://www.emudevs.com/>
 
  This program is free software; you can redistribute it and/or modify it
  under the terms of the GNU General Public License as published by the
  Free Software Foundation; either version 2 of the License, or (at your
  option) any later version.
 
  This program is distributed in the hope that it will be useful, but WITHOUT
  ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
  FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
  more details.
 
  You should have received a copy of the GNU General Public License along
  with this program. If not, see <http://www.gnu.org/licenses/>.
*/
namespace Essentials
{
    public class ConfigOptions
    {
        public static Config OptionConfig = new Config("Options.conf");

        public static int LogonPort = OptionConfig.GetIntValue("Logon.Port", 3724);
        public static int WorldPort = OptionConfig.GetIntValue("World.Port", 8085);
        public static int MySQLPort = OptionConfig.GetIntValue("MySql.Port", 3306);
        public static string Host = OptionConfig.GetStringValue("Server.Host", "127.0.0.1");
        public static string CharDBHost = OptionConfig.GetStringValue("DB.Host", "127.0.0.1");
        public static string CharDBUser = OptionConfig.GetStringValue("DB.Username", "root");
        public static string CharDBPass = OptionConfig.GetStringValue("DB.Password", "root");
        public static string CharDBName = OptionConfig.GetStringValue("DB.Database", "characters");
    }
}
