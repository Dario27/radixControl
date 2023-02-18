/*
               File: sw_position
        Description: sw_position
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/23/2023 0:52:41.58
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class gxdomainsw_position
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomainsw_position ()
      {
         domain["top"] = "top";
         domain["top-start"] = "top_start";
         domain["top-end"] = "top_end";
         domain["center"] = "center";
         domain["center-start"] = "center_start";
         domain["center-end"] = "center_end";
         domain["bottom"] = "bottom";
         domain["bottom-start"] = "bottom_start";
         domain["bottom-end"] = "bottom_end";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection<String> getValues( )
      {
         GxSimpleCollection<String> value = new GxSimpleCollection<String>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static String getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["top"] = "top";
            domainMap["top_start"] = "top-start";
            domainMap["top_end"] = "top-end";
            domainMap["center"] = "center";
            domainMap["center_start"] = "center-start";
            domainMap["center_end"] = "center-end";
            domainMap["bottom"] = "bottom";
            domainMap["bottom_start"] = "bottom-start";
            domainMap["bottom_end"] = "bottom-end";
         }
         return (String)domainMap[key] ;
      }

   }

}
