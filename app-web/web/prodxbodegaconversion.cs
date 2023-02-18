/*
               File: ProdxBodegaConversion
        Description: Conversion for table ProdxBodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/28/2022 1:27:3.85
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
   public class prodxbodegaconversion : GXProcedure
   {
      public prodxbodegaconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prodxbodegaconversion( IGxContext context )
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
         prodxbodegaconversion objprodxbodegaconversion;
         objprodxbodegaconversion = new prodxbodegaconversion();
         objprodxbodegaconversion.context.SetSubmitInitialConfig(context);
         objprodxbodegaconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprodxbodegaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prodxbodegaconversion)stateInfo).executePrivate();
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
         /* Using cursor PRODXBODEG2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A293invFisico = PRODXBODEG2_A293invFisico[0];
            n293invFisico = PRODXBODEG2_n293invFisico[0];
            A307prdStockDsc = PRODXBODEG2_A307prdStockDsc[0];
            n307prdStockDsc = PRODXBODEG2_n307prdStockDsc[0];
            A42BodCod = PRODXBODEG2_A42BodCod[0];
            A2AgeID = PRODXBODEG2_A2AgeID[0];
            A1EmpID = PRODXBODEG2_A1EmpID[0];
            A291stockMes = PRODXBODEG2_A291stockMes[0];
            A290stockAnio = PRODXBODEG2_A290stockAnio[0];
            AV10GXV43 = "";
            /* Using cursor PRODXBODEG3 */
            pr_default.execute(1, new Object[] {A290stockAnio, A291stockMes, A1EmpID, A2AgeID, A42BodCod});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A43TipoInv = PRODXBODEG3_A43TipoInv[0];
               AV10GXV43 = A43TipoInv;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0070

            */
            AV2stockAnio = A290stockAnio;
            AV3stockMes = A291stockMes;
            AV4EmpID = A1EmpID;
            AV5AgeID = A2AgeID;
            AV6BodCod = A42BodCod;
            if ( PRODXBODEG2_n307prdStockDsc[0] )
            {
               AV7prdStockDsc = "";
               nV7prdStockDsc = false;
               nV7prdStockDsc = true;
            }
            else
            {
               AV7prdStockDsc = A307prdStockDsc;
               nV7prdStockDsc = false;
            }
            if ( PRODXBODEG2_n293invFisico[0] )
            {
               AV8invFisico = 0;
               nV8invFisico = false;
               nV8invFisico = true;
            }
            else
            {
               AV8invFisico = A293invFisico;
               nV8invFisico = false;
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV10GXV43)) )
            {
               AV9TipoInv = " ";
            }
            else
            {
               AV9TipoInv = AV10GXV43;
            }
            /* Using cursor PRODXBODEG4 */
            pr_default.execute(2, new Object[] {AV2stockAnio, AV3stockMes, AV4EmpID, AV5AgeID, AV6BodCod, nV7prdStockDsc, AV7prdStockDsc, nV8invFisico, AV8invFisico, AV9TipoInv});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0070") ;
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
         PRODXBODEG2_A293invFisico = new int[1] ;
         PRODXBODEG2_n293invFisico = new bool[] {false} ;
         PRODXBODEG2_A307prdStockDsc = new String[] {""} ;
         PRODXBODEG2_n307prdStockDsc = new bool[] {false} ;
         PRODXBODEG2_A42BodCod = new short[1] ;
         PRODXBODEG2_A2AgeID = new short[1] ;
         PRODXBODEG2_A1EmpID = new short[1] ;
         PRODXBODEG2_A291stockMes = new short[1] ;
         PRODXBODEG2_A290stockAnio = new short[1] ;
         A307prdStockDsc = "";
         AV10GXV43 = "";
         PRODXBODEG3_A290stockAnio = new short[1] ;
         PRODXBODEG3_A291stockMes = new short[1] ;
         PRODXBODEG3_A1EmpID = new short[1] ;
         PRODXBODEG3_A2AgeID = new short[1] ;
         PRODXBODEG3_A42BodCod = new short[1] ;
         PRODXBODEG3_A43TipoInv = new String[] {""} ;
         A43TipoInv = "";
         AV7prdStockDsc = "";
         AV9TipoInv = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prodxbodegaconversion__default(),
            new Object[][] {
                new Object[] {
               PRODXBODEG2_A293invFisico, PRODXBODEG2_n293invFisico, PRODXBODEG2_A307prdStockDsc, PRODXBODEG2_n307prdStockDsc, PRODXBODEG2_A42BodCod, PRODXBODEG2_A2AgeID, PRODXBODEG2_A1EmpID, PRODXBODEG2_A291stockMes, PRODXBODEG2_A290stockAnio
               }
               , new Object[] {
               PRODXBODEG3_A290stockAnio, PRODXBODEG3_A291stockMes, PRODXBODEG3_A1EmpID, PRODXBODEG3_A2AgeID, PRODXBODEG3_A42BodCod, PRODXBODEG3_A43TipoInv
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A42BodCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A291stockMes ;
      private short A290stockAnio ;
      private short AV2stockAnio ;
      private short AV3stockMes ;
      private short AV4EmpID ;
      private short AV5AgeID ;
      private short AV6BodCod ;
      private int A293invFisico ;
      private int GIGXA0070 ;
      private int AV8invFisico ;
      private String scmdbuf ;
      private String AV10GXV43 ;
      private String A43TipoInv ;
      private String AV9TipoInv ;
      private String Gx_emsg ;
      private bool n293invFisico ;
      private bool n307prdStockDsc ;
      private bool nV7prdStockDsc ;
      private bool nV8invFisico ;
      private String A307prdStockDsc ;
      private String AV7prdStockDsc ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] PRODXBODEG2_A293invFisico ;
      private bool[] PRODXBODEG2_n293invFisico ;
      private String[] PRODXBODEG2_A307prdStockDsc ;
      private bool[] PRODXBODEG2_n307prdStockDsc ;
      private short[] PRODXBODEG2_A42BodCod ;
      private short[] PRODXBODEG2_A2AgeID ;
      private short[] PRODXBODEG2_A1EmpID ;
      private short[] PRODXBODEG2_A291stockMes ;
      private short[] PRODXBODEG2_A290stockAnio ;
      private short[] PRODXBODEG3_A290stockAnio ;
      private short[] PRODXBODEG3_A291stockMes ;
      private short[] PRODXBODEG3_A1EmpID ;
      private short[] PRODXBODEG3_A2AgeID ;
      private short[] PRODXBODEG3_A42BodCod ;
      private String[] PRODXBODEG3_A43TipoInv ;
   }

   public class prodxbodegaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmPRODXBODEG2 ;
          prmPRODXBODEG2 = new Object[] {
          } ;
          Object[] prmPRODXBODEG3 ;
          prmPRODXBODEG3 = new Object[] {
          new Object[] {"@stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmPRODXBODEG4 ;
          prmPRODXBODEG4 = new Object[] {
          new Object[] {"@AV2stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV4EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7prdStockDsc",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV8invFisico",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9TipoInv",SqlDbType.Char,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PRODXBODEG2", "SELECT [invFisico], [prdStockDsc], [BodCod], [AgeID], [EmpID], [stockMes], [stockAnio] FROM [ProdxBodega] ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODXBODEG2,100,0,true,false )
             ,new CursorDef("PRODXBODEG3", "SELECT TOP 1 [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv] FROM [ProdxBodegaTipo] WHERE [stockAnio] = @stockAnio and [stockMes] = @stockMes and [EmpID] = @EmpID and [AgeID] = @AgeID and [BodCod] = @BodCod ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [BodCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODXBODEG3,1,0,false,true )
             ,new CursorDef("PRODXBODEG4", "INSERT INTO [GXA0070]([stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [prdStockDsc], [invFisico], [TipoInv]) VALUES(@AV2stockAnio, @AV3stockMes, @AV4EmpID, @AV5AgeID, @AV6BodCod, @AV7prdStockDsc, @AV8invFisico, @AV9TipoInv)", GxErrorMask.GX_NOMASK,prmPRODXBODEG4)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 4) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[8]);
                }
                stmt.SetParameter(8, (String)parms[9]);
                return;
       }
    }

 }

}
