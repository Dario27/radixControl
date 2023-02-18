/*
               File: ObrerosConversion
        Description: Conversion for table Obreros
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 7/7/2022 21:51:3.45
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class obrerosconversion : GXProcedure
   {
      public obrerosconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obrerosconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         obrerosconversion objobrerosconversion;
         objobrerosconversion = new obrerosconversion();
         objobrerosconversion.context.SetSubmitInitialConfig(context);
         objobrerosconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobrerosconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obrerosconversion)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor OBREROSCON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A248ObreTelf = OBREROSCON2_A248ObreTelf[0];
            n248ObreTelf = OBREROSCON2_n248ObreTelf[0];
            A247ObreDir = OBREROSCON2_A247ObreDir[0];
            n247ObreDir = OBREROSCON2_n247ObreDir[0];
            A245ObreFchNac = OBREROSCON2_A245ObreFchNac[0];
            n245ObreFchNac = OBREROSCON2_n245ObreFchNac[0];
            A243ObreSegApellido = OBREROSCON2_A243ObreSegApellido[0];
            n243ObreSegApellido = OBREROSCON2_n243ObreSegApellido[0];
            A242ObrePrApellido = OBREROSCON2_A242ObrePrApellido[0];
            n242ObrePrApellido = OBREROSCON2_n242ObrePrApellido[0];
            A241ObreSegNombre = OBREROSCON2_A241ObreSegNombre[0];
            n241ObreSegNombre = OBREROSCON2_n241ObreSegNombre[0];
            A240ObrePrNombre = OBREROSCON2_A240ObrePrNombre[0];
            n240ObrePrNombre = OBREROSCON2_n240ObrePrNombre[0];
            A239ObreCedula = OBREROSCON2_A239ObreCedula[0];
            n239ObreCedula = OBREROSCON2_n239ObreCedula[0];
            A238ObreID = OBREROSCON2_A238ObreID[0];
            /*
               INSERT RECORD ON TABLE GXA0042

            */
            AV2ObreID = A238ObreID;
            if ( OBREROSCON2_n239ObreCedula[0] )
            {
               AV3ObreCedula = " ";
            }
            else
            {
               AV3ObreCedula = A239ObreCedula;
            }
            if ( OBREROSCON2_n240ObrePrNombre[0] )
            {
               AV4ObrePrNombre = "";
               nV4ObrePrNombre = false;
               nV4ObrePrNombre = true;
            }
            else
            {
               AV4ObrePrNombre = A240ObrePrNombre;
               nV4ObrePrNombre = false;
            }
            if ( OBREROSCON2_n241ObreSegNombre[0] )
            {
               AV5ObreSegNombre = "";
               nV5ObreSegNombre = false;
               nV5ObreSegNombre = true;
            }
            else
            {
               AV5ObreSegNombre = A241ObreSegNombre;
               nV5ObreSegNombre = false;
            }
            if ( OBREROSCON2_n242ObrePrApellido[0] )
            {
               AV6ObrePrApellido = "";
               nV6ObrePrApellido = false;
               nV6ObrePrApellido = true;
            }
            else
            {
               AV6ObrePrApellido = A242ObrePrApellido;
               nV6ObrePrApellido = false;
            }
            if ( OBREROSCON2_n243ObreSegApellido[0] )
            {
               AV7ObreSegApellido = "";
               nV7ObreSegApellido = false;
               nV7ObreSegApellido = true;
            }
            else
            {
               AV7ObreSegApellido = A243ObreSegApellido;
               nV7ObreSegApellido = false;
            }
            if ( OBREROSCON2_n245ObreFchNac[0] )
            {
               AV8ObreFchNac = DateTime.MinValue;
               nV8ObreFchNac = false;
               nV8ObreFchNac = true;
            }
            else
            {
               AV8ObreFchNac = A245ObreFchNac;
               nV8ObreFchNac = false;
            }
            if ( OBREROSCON2_n247ObreDir[0] )
            {
               AV9ObreDir = "";
               nV9ObreDir = false;
               nV9ObreDir = true;
            }
            else
            {
               AV9ObreDir = A247ObreDir;
               nV9ObreDir = false;
            }
            if ( OBREROSCON2_n248ObreTelf[0] )
            {
               AV10ObreTelf = "";
               nV10ObreTelf = false;
               nV10ObreTelf = true;
            }
            else
            {
               AV10ObreTelf = A248ObreTelf;
               nV10ObreTelf = false;
            }
            AV11ObreEst = "";
            nV11ObreEst = false;
            nV11ObreEst = true;
            AV12ObreEmail = "";
            nV12ObreEmail = false;
            nV12ObreEmail = true;
            /* Using cursor OBREROSCON3 */
            pr_default.execute(1, new Object[] {AV2ObreID, AV3ObreCedula, nV4ObrePrNombre, AV4ObrePrNombre, nV5ObreSegNombre, AV5ObreSegNombre, nV6ObrePrApellido, AV6ObrePrApellido, nV7ObreSegApellido, AV7ObreSegApellido, nV8ObreFchNac, AV8ObreFchNac, nV9ObreDir, AV9ObreDir, nV10ObreTelf, AV10ObreTelf, nV11ObreEst, AV11ObreEst, nV12ObreEmail, AV12ObreEmail});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0042") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         OBREROSCON2_A248ObreTelf = new String[] {""} ;
         OBREROSCON2_n248ObreTelf = new bool[] {false} ;
         OBREROSCON2_A247ObreDir = new String[] {""} ;
         OBREROSCON2_n247ObreDir = new bool[] {false} ;
         OBREROSCON2_A245ObreFchNac = new DateTime[] {DateTime.MinValue} ;
         OBREROSCON2_n245ObreFchNac = new bool[] {false} ;
         OBREROSCON2_A243ObreSegApellido = new String[] {""} ;
         OBREROSCON2_n243ObreSegApellido = new bool[] {false} ;
         OBREROSCON2_A242ObrePrApellido = new String[] {""} ;
         OBREROSCON2_n242ObrePrApellido = new bool[] {false} ;
         OBREROSCON2_A241ObreSegNombre = new String[] {""} ;
         OBREROSCON2_n241ObreSegNombre = new bool[] {false} ;
         OBREROSCON2_A240ObrePrNombre = new String[] {""} ;
         OBREROSCON2_n240ObrePrNombre = new bool[] {false} ;
         OBREROSCON2_A239ObreCedula = new String[] {""} ;
         OBREROSCON2_n239ObreCedula = new bool[] {false} ;
         OBREROSCON2_A238ObreID = new short[1] ;
         A248ObreTelf = "";
         A247ObreDir = "";
         A245ObreFchNac = DateTime.MinValue;
         A243ObreSegApellido = "";
         A242ObrePrApellido = "";
         A241ObreSegNombre = "";
         A240ObrePrNombre = "";
         A239ObreCedula = "";
         AV3ObreCedula = "";
         AV4ObrePrNombre = "";
         AV5ObreSegNombre = "";
         AV6ObrePrApellido = "";
         AV7ObreSegApellido = "";
         AV8ObreFchNac = DateTime.MinValue;
         AV9ObreDir = "";
         AV10ObreTelf = "";
         AV11ObreEst = "";
         AV12ObreEmail = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obrerosconversion__default(),
            new Object[][] {
                new Object[] {
               OBREROSCON2_A248ObreTelf, OBREROSCON2_n248ObreTelf, OBREROSCON2_A247ObreDir, OBREROSCON2_n247ObreDir, OBREROSCON2_A245ObreFchNac, OBREROSCON2_n245ObreFchNac, OBREROSCON2_A243ObreSegApellido, OBREROSCON2_n243ObreSegApellido, OBREROSCON2_A242ObrePrApellido, OBREROSCON2_n242ObrePrApellido,
               OBREROSCON2_A241ObreSegNombre, OBREROSCON2_n241ObreSegNombre, OBREROSCON2_A240ObrePrNombre, OBREROSCON2_n240ObrePrNombre, OBREROSCON2_A239ObreCedula, OBREROSCON2_n239ObreCedula, OBREROSCON2_A238ObreID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A238ObreID ;
      private short AV2ObreID ;
      private int GIGXA0042 ;
      private String scmdbuf ;
      private String A248ObreTelf ;
      private String A239ObreCedula ;
      private String AV3ObreCedula ;
      private String AV10ObreTelf ;
      private String AV11ObreEst ;
      private String Gx_emsg ;
      private DateTime A245ObreFchNac ;
      private DateTime AV8ObreFchNac ;
      private bool n248ObreTelf ;
      private bool n247ObreDir ;
      private bool n245ObreFchNac ;
      private bool n243ObreSegApellido ;
      private bool n242ObrePrApellido ;
      private bool n241ObreSegNombre ;
      private bool n240ObrePrNombre ;
      private bool n239ObreCedula ;
      private bool nV4ObrePrNombre ;
      private bool nV5ObreSegNombre ;
      private bool nV6ObrePrApellido ;
      private bool nV7ObreSegApellido ;
      private bool nV8ObreFchNac ;
      private bool nV9ObreDir ;
      private bool nV10ObreTelf ;
      private bool nV11ObreEst ;
      private bool nV12ObreEmail ;
      private String A247ObreDir ;
      private String A243ObreSegApellido ;
      private String A242ObrePrApellido ;
      private String A241ObreSegNombre ;
      private String A240ObrePrNombre ;
      private String AV4ObrePrNombre ;
      private String AV5ObreSegNombre ;
      private String AV6ObrePrApellido ;
      private String AV7ObreSegApellido ;
      private String AV9ObreDir ;
      private String AV12ObreEmail ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] OBREROSCON2_A248ObreTelf ;
      private bool[] OBREROSCON2_n248ObreTelf ;
      private String[] OBREROSCON2_A247ObreDir ;
      private bool[] OBREROSCON2_n247ObreDir ;
      private DateTime[] OBREROSCON2_A245ObreFchNac ;
      private bool[] OBREROSCON2_n245ObreFchNac ;
      private String[] OBREROSCON2_A243ObreSegApellido ;
      private bool[] OBREROSCON2_n243ObreSegApellido ;
      private String[] OBREROSCON2_A242ObrePrApellido ;
      private bool[] OBREROSCON2_n242ObrePrApellido ;
      private String[] OBREROSCON2_A241ObreSegNombre ;
      private bool[] OBREROSCON2_n241ObreSegNombre ;
      private String[] OBREROSCON2_A240ObrePrNombre ;
      private bool[] OBREROSCON2_n240ObrePrNombre ;
      private String[] OBREROSCON2_A239ObreCedula ;
      private bool[] OBREROSCON2_n239ObreCedula ;
      private short[] OBREROSCON2_A238ObreID ;
   }

   public class obrerosconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmOBREROSCON2 ;
          prmOBREROSCON2 = new Object[] {
          } ;
          Object[] prmOBREROSCON3 ;
          prmOBREROSCON3 = new Object[] {
          new Object[] {"@AV2ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3ObreCedula",SqlDbType.Char,13,0} ,
          new Object[] {"@AV4ObrePrNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV5ObreSegNombre",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV6ObrePrApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV7ObreSegApellido",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV8ObreFchNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV9ObreDir",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10ObreTelf",SqlDbType.Char,20,0} ,
          new Object[] {"@AV11ObreEst",SqlDbType.Char,1,0} ,
          new Object[] {"@AV12ObreEmail",SqlDbType.VarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("OBREROSCON2", "SELECT [ObreTelf], [ObreDir], [ObreFchNac], [ObreSegApellido], [ObrePrApellido], [ObreSegNombre], [ObrePrNombre], [ObreCedula], [ObreID] FROM [Obreros] ORDER BY [ObreID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmOBREROSCON2,100,0,true,false )
             ,new CursorDef("OBREROSCON3", "INSERT INTO [GXA0042]([ObreID], [ObreCedula], [ObrePrNombre], [ObreSegNombre], [ObrePrApellido], [ObreSegApellido], [ObreFchNac], [ObreDir], [ObreTelf], [ObreEst], [ObreEmail]) VALUES(@AV2ObreID, @AV3ObreCedula, @AV4ObrePrNombre, @AV5ObreSegNombre, @AV6ObrePrApellido, @AV7ObreSegApellido, @AV8ObreFchNac, @AV9ObreDir, @AV10ObreTelf, @AV11ObreEst, @AV12ObreEmail)", GxErrorMask.GX_NOMASK,prmOBREROSCON3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getString(8, 13) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((short[]) buf[16])[0] = rslt.getShort(9) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 10 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[19]);
                }
                return;
       }
    }

 }

}
