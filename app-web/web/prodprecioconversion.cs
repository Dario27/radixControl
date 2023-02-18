/*
               File: ProdPrecioConversion
        Description: Conversion for table ProdPrecio
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 9/11/2022 0:38:22.2
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
   public class prodprecioconversion : GXProcedure
   {
      public prodprecioconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prodprecioconversion( IGxContext context )
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
         prodprecioconversion objprodprecioconversion;
         objprodprecioconversion = new prodprecioconversion();
         objprodprecioconversion.context.SetSubmitInitialConfig(context);
         objprodprecioconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprodprecioconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prodprecioconversion)stateInfo).executePrivate();
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
         /* Using cursor PRODPRECIO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3UsuCod = PRODPRECIO2_A3UsuCod[0];
            A304valoAct = PRODPRECIO2_A304valoAct[0];
            n304valoAct = PRODPRECIO2_n304valoAct[0];
            A303valAnt = PRODPRECIO2_A303valAnt[0];
            n303valAnt = PRODPRECIO2_n303valAnt[0];
            A302fecha = PRODPRECIO2_A302fecha[0];
            n302fecha = PRODPRECIO2_n302fecha[0];
            A286PrdCod = PRODPRECIO2_A286PrdCod[0];
            A2AgeID = PRODPRECIO2_A2AgeID[0];
            A1EmpID = PRODPRECIO2_A1EmpID[0];
            AV10GXV305 = "";
            /* Using cursor PRODPRECIO3 */
            pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A286PrdCod});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A305PrdDescp = PRODPRECIO3_A305PrdDescp[0];
               n305PrdDescp = PRODPRECIO3_n305PrdDescp[0];
               A32categID = PRODPRECIO3_A32categID[0];
               AV10GXV305 = A305PrdDescp;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0069

            */
            AV2EmpID = A1EmpID;
            AV3AgeID = A2AgeID;
            AV4PrdCod = A286PrdCod;
            if ( PRODPRECIO2_n302fecha[0] )
            {
               AV5fecha = DateTime.MinValue;
               nV5fecha = false;
               nV5fecha = true;
            }
            else
            {
               AV5fecha = A302fecha;
               nV5fecha = false;
            }
            if ( PRODPRECIO2_n303valAnt[0] )
            {
               AV6valAnt = 0;
               nV6valAnt = false;
               nV6valAnt = true;
            }
            else
            {
               AV6valAnt = A303valAnt;
               nV6valAnt = false;
            }
            if ( PRODPRECIO2_n304valoAct[0] )
            {
               AV7valoAct = 0;
               nV7valoAct = false;
               nV7valoAct = true;
            }
            else
            {
               AV7valoAct = A304valoAct;
               nV7valoAct = false;
            }
            AV8UsuCod = A3UsuCod;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV10GXV305)) )
            {
               AV9PrdDescp = " ";
            }
            else
            {
               AV9PrdDescp = AV10GXV305;
            }
            /* Using cursor PRODPRECIO4 */
            pr_default.execute(2, new Object[] {AV2EmpID, AV3AgeID, AV4PrdCod, nV5fecha, AV5fecha, nV6valAnt, AV6valAnt, nV7valoAct, AV7valoAct, AV8UsuCod, AV9PrdDescp});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0069") ;
            if ( (pr_default.getStatus(2) == 1) )
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
         PRODPRECIO2_A3UsuCod = new String[] {""} ;
         PRODPRECIO2_A304valoAct = new decimal[1] ;
         PRODPRECIO2_n304valoAct = new bool[] {false} ;
         PRODPRECIO2_A303valAnt = new decimal[1] ;
         PRODPRECIO2_n303valAnt = new bool[] {false} ;
         PRODPRECIO2_A302fecha = new DateTime[] {DateTime.MinValue} ;
         PRODPRECIO2_n302fecha = new bool[] {false} ;
         PRODPRECIO2_A286PrdCod = new short[1] ;
         PRODPRECIO2_A2AgeID = new short[1] ;
         PRODPRECIO2_A1EmpID = new short[1] ;
         A3UsuCod = "";
         A302fecha = DateTime.MinValue;
         AV10GXV305 = "";
         PRODPRECIO3_A1EmpID = new short[1] ;
         PRODPRECIO3_A2AgeID = new short[1] ;
         PRODPRECIO3_A286PrdCod = new short[1] ;
         PRODPRECIO3_A305PrdDescp = new String[] {""} ;
         PRODPRECIO3_n305PrdDescp = new bool[] {false} ;
         PRODPRECIO3_A32categID = new short[1] ;
         A305PrdDescp = "";
         AV5fecha = DateTime.MinValue;
         AV8UsuCod = "";
         AV9PrdDescp = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prodprecioconversion__default(),
            new Object[][] {
                new Object[] {
               PRODPRECIO2_A3UsuCod, PRODPRECIO2_A304valoAct, PRODPRECIO2_n304valoAct, PRODPRECIO2_A303valAnt, PRODPRECIO2_n303valAnt, PRODPRECIO2_A302fecha, PRODPRECIO2_n302fecha, PRODPRECIO2_A286PrdCod, PRODPRECIO2_A2AgeID, PRODPRECIO2_A1EmpID
               }
               , new Object[] {
               PRODPRECIO3_A1EmpID, PRODPRECIO3_A2AgeID, PRODPRECIO3_A286PrdCod, PRODPRECIO3_A305PrdDescp, PRODPRECIO3_n305PrdDescp, PRODPRECIO3_A32categID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A286PrdCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A32categID ;
      private short AV2EmpID ;
      private short AV3AgeID ;
      private short AV4PrdCod ;
      private int GIGXA0069 ;
      private decimal A304valoAct ;
      private decimal A303valAnt ;
      private decimal AV6valAnt ;
      private decimal AV7valoAct ;
      private String scmdbuf ;
      private String A3UsuCod ;
      private String AV8UsuCod ;
      private String Gx_emsg ;
      private DateTime A302fecha ;
      private DateTime AV5fecha ;
      private bool n304valoAct ;
      private bool n303valAnt ;
      private bool n302fecha ;
      private bool n305PrdDescp ;
      private bool nV5fecha ;
      private bool nV6valAnt ;
      private bool nV7valoAct ;
      private String AV10GXV305 ;
      private String A305PrdDescp ;
      private String AV9PrdDescp ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] PRODPRECIO2_A3UsuCod ;
      private decimal[] PRODPRECIO2_A304valoAct ;
      private bool[] PRODPRECIO2_n304valoAct ;
      private decimal[] PRODPRECIO2_A303valAnt ;
      private bool[] PRODPRECIO2_n303valAnt ;
      private DateTime[] PRODPRECIO2_A302fecha ;
      private bool[] PRODPRECIO2_n302fecha ;
      private short[] PRODPRECIO2_A286PrdCod ;
      private short[] PRODPRECIO2_A2AgeID ;
      private short[] PRODPRECIO2_A1EmpID ;
      private short[] PRODPRECIO3_A1EmpID ;
      private short[] PRODPRECIO3_A2AgeID ;
      private short[] PRODPRECIO3_A286PrdCod ;
      private String[] PRODPRECIO3_A305PrdDescp ;
      private bool[] PRODPRECIO3_n305PrdDescp ;
      private short[] PRODPRECIO3_A32categID ;
   }

   public class prodprecioconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmPRODPRECIO2 ;
          prmPRODPRECIO2 = new Object[] {
          } ;
          Object[] prmPRODPRECIO3 ;
          prmPRODPRECIO3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmPRODPRECIO4 ;
          prmPRODPRECIO4 = new Object[] {
          new Object[] {"@AV2EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5fecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV6valAnt",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV7valoAct",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV8UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV9PrdDescp",SqlDbType.VarChar,80,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PRODPRECIO2", "SELECT [UsuCod], [valoAct], [valAnt], [fecha], [PrdCod], [AgeID], [EmpID] FROM [ProdPrecio] ORDER BY [EmpID], [AgeID], [PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODPRECIO2,100,0,true,false )
             ,new CursorDef("PRODPRECIO3", "SELECT TOP 1 [EmpID], [AgeID], [PrdCod], [PrdDescp], [categID] FROM [Productos] WHERE [EmpID] = @EmpID and [AgeID] = @AgeID and [PrdCod] = @PrdCod ORDER BY [EmpID], [AgeID], [PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODPRECIO3,1,0,false,true )
             ,new CursorDef("PRODPRECIO4", "INSERT INTO [GXA0069]([EmpID], [AgeID], [PrdCod], [fecha], [valAnt], [valoAct], [UsuCod], [PrdDescp]) VALUES(@AV2EmpID, @AV3AgeID, @AV4PrdCod, @AV5fecha, @AV6valAnt, @AV7valoAct, @AV8UsuCod, @AV9PrdDescp)", GxErrorMask.GX_NOMASK,prmPRODPRECIO4)
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[8]);
                }
                stmt.SetParameter(7, (String)parms[9]);
                stmt.SetParameter(8, (String)parms[10]);
                return;
       }
    }

 }

}
