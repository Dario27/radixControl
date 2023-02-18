/*
               File: ProductosConversion
        Description: Conversion for table Productos
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 9/20/2022 23:16:3.87
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
   public class productosconversion : GXProcedure
   {
      public productosconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public productosconversion( IGxContext context )
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
         productosconversion objproductosconversion;
         objproductosconversion = new productosconversion();
         objproductosconversion.context.SetSubmitInitialConfig(context);
         objproductosconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objproductosconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((productosconversion)stateInfo).executePrivate();
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
         /* Using cursor PRODUCTOSC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A36detTipoProdID = PRODUCTOSC2_A36detTipoProdID[0];
            A309prdNombre = PRODUCTOSC2_A309prdNombre[0];
            n309prdNombre = PRODUCTOSC2_n309prdNombre[0];
            A308PrdTipPrd = PRODUCTOSC2_A308PrdTipPrd[0];
            n308PrdTipPrd = PRODUCTOSC2_n308PrdTipPrd[0];
            A306PrdDescCorta = PRODUCTOSC2_A306PrdDescCorta[0];
            n306PrdDescCorta = PRODUCTOSC2_n306PrdDescCorta[0];
            A289PrdEstado = PRODUCTOSC2_A289PrdEstado[0];
            n289PrdEstado = PRODUCTOSC2_n289PrdEstado[0];
            A288PrdPres = PRODUCTOSC2_A288PrdPres[0];
            n288PrdPres = PRODUCTOSC2_n288PrdPres[0];
            A32categID = PRODUCTOSC2_A32categID[0];
            A286PrdCod = PRODUCTOSC2_A286PrdCod[0];
            A2AgeID = PRODUCTOSC2_A2AgeID[0];
            A1EmpID = PRODUCTOSC2_A1EmpID[0];
            /* Using cursor PRODUCTOSC3 */
            pr_default.execute(1, new Object[] {A1EmpID, A36detTipoProdID});
            A144tipoProdDsc = PRODUCTOSC3_A144tipoProdDsc[0];
            n144tipoProdDsc = PRODUCTOSC3_n144tipoProdDsc[0];
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0072

            */
            AV2EmpID = A1EmpID;
            AV3AgeID = A2AgeID;
            AV4PrdCod = A286PrdCod;
            AV5categID = A32categID;
            if ( PRODUCTOSC2_n288PrdPres[0] )
            {
               AV6PrdPres = 0;
               nV6PrdPres = false;
               nV6PrdPres = true;
            }
            else
            {
               AV6PrdPres = A288PrdPres;
               nV6PrdPres = false;
            }
            if ( PRODUCTOSC2_n289PrdEstado[0] )
            {
               AV7PrdEstado = "";
               nV7PrdEstado = false;
               nV7PrdEstado = true;
            }
            else
            {
               AV7PrdEstado = A289PrdEstado;
               nV7PrdEstado = false;
            }
            if ( PRODUCTOSC2_n306PrdDescCorta[0] )
            {
               AV8PrdDescCorta = "";
               nV8PrdDescCorta = false;
               nV8PrdDescCorta = true;
            }
            else
            {
               AV8PrdDescCorta = A306PrdDescCorta;
               nV8PrdDescCorta = false;
            }
            if ( PRODUCTOSC2_n308PrdTipPrd[0] )
            {
               AV9PrdTipPrd = 0;
               nV9PrdTipPrd = false;
               nV9PrdTipPrd = true;
            }
            else
            {
               AV9PrdTipPrd = A308PrdTipPrd;
               nV9PrdTipPrd = false;
            }
            if ( PRODUCTOSC2_n309prdNombre[0] )
            {
               AV10prdNombre = "";
               nV10prdNombre = false;
               nV10prdNombre = true;
            }
            else
            {
               AV10prdNombre = A309prdNombre;
               nV10prdNombre = false;
            }
            AV11detTipoProdID = A36detTipoProdID;
            if ( PRODUCTOSC3_n144tipoProdDsc[0] )
            {
               AV12detTipoProdDsc = " ";
            }
            else
            {
               AV12detTipoProdDsc = A144tipoProdDsc;
            }
            /* Using cursor PRODUCTOSC4 */
            pr_default.execute(2, new Object[] {AV2EmpID, AV3AgeID, AV4PrdCod, AV5categID, nV6PrdPres, AV6PrdPres, nV7PrdEstado, AV7PrdEstado, nV8PrdDescCorta, AV8PrdDescCorta, nV9PrdTipPrd, AV9PrdTipPrd, nV10prdNombre, AV10prdNombre, AV11detTipoProdID, AV12detTipoProdDsc});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0072") ;
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
         pr_default.close(1);
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
         PRODUCTOSC2_A36detTipoProdID = new short[1] ;
         PRODUCTOSC2_A309prdNombre = new String[] {""} ;
         PRODUCTOSC2_n309prdNombre = new bool[] {false} ;
         PRODUCTOSC2_A308PrdTipPrd = new short[1] ;
         PRODUCTOSC2_n308PrdTipPrd = new bool[] {false} ;
         PRODUCTOSC2_A306PrdDescCorta = new String[] {""} ;
         PRODUCTOSC2_n306PrdDescCorta = new bool[] {false} ;
         PRODUCTOSC2_A289PrdEstado = new String[] {""} ;
         PRODUCTOSC2_n289PrdEstado = new bool[] {false} ;
         PRODUCTOSC2_A288PrdPres = new short[1] ;
         PRODUCTOSC2_n288PrdPres = new bool[] {false} ;
         PRODUCTOSC2_A32categID = new short[1] ;
         PRODUCTOSC2_A286PrdCod = new short[1] ;
         PRODUCTOSC2_A2AgeID = new short[1] ;
         PRODUCTOSC2_A1EmpID = new short[1] ;
         A309prdNombre = "";
         A306PrdDescCorta = "";
         A289PrdEstado = "";
         PRODUCTOSC3_A144tipoProdDsc = new String[] {""} ;
         PRODUCTOSC3_n144tipoProdDsc = new bool[] {false} ;
         A144tipoProdDsc = "";
         AV7PrdEstado = "";
         AV8PrdDescCorta = "";
         AV10prdNombre = "";
         AV12detTipoProdDsc = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.productosconversion__default(),
            new Object[][] {
                new Object[] {
               PRODUCTOSC2_A36detTipoProdID, PRODUCTOSC2_A309prdNombre, PRODUCTOSC2_n309prdNombre, PRODUCTOSC2_A308PrdTipPrd, PRODUCTOSC2_n308PrdTipPrd, PRODUCTOSC2_A306PrdDescCorta, PRODUCTOSC2_n306PrdDescCorta, PRODUCTOSC2_A289PrdEstado, PRODUCTOSC2_n289PrdEstado, PRODUCTOSC2_A288PrdPres,
               PRODUCTOSC2_n288PrdPres, PRODUCTOSC2_A32categID, PRODUCTOSC2_A286PrdCod, PRODUCTOSC2_A2AgeID, PRODUCTOSC2_A1EmpID
               }
               , new Object[] {
               PRODUCTOSC3_A144tipoProdDsc, PRODUCTOSC3_n144tipoProdDsc
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A36detTipoProdID ;
      private short A308PrdTipPrd ;
      private short A288PrdPres ;
      private short A32categID ;
      private short A286PrdCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short AV2EmpID ;
      private short AV3AgeID ;
      private short AV4PrdCod ;
      private short AV5categID ;
      private short AV6PrdPres ;
      private short AV9PrdTipPrd ;
      private short AV11detTipoProdID ;
      private int GIGXA0072 ;
      private String scmdbuf ;
      private String A289PrdEstado ;
      private String A144tipoProdDsc ;
      private String AV7PrdEstado ;
      private String AV12detTipoProdDsc ;
      private String Gx_emsg ;
      private bool n309prdNombre ;
      private bool n308PrdTipPrd ;
      private bool n306PrdDescCorta ;
      private bool n289PrdEstado ;
      private bool n288PrdPres ;
      private bool n144tipoProdDsc ;
      private bool nV6PrdPres ;
      private bool nV7PrdEstado ;
      private bool nV8PrdDescCorta ;
      private bool nV9PrdTipPrd ;
      private bool nV10prdNombre ;
      private String A309prdNombre ;
      private String A306PrdDescCorta ;
      private String AV8PrdDescCorta ;
      private String AV10prdNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] PRODUCTOSC2_A36detTipoProdID ;
      private String[] PRODUCTOSC2_A309prdNombre ;
      private bool[] PRODUCTOSC2_n309prdNombre ;
      private short[] PRODUCTOSC2_A308PrdTipPrd ;
      private bool[] PRODUCTOSC2_n308PrdTipPrd ;
      private String[] PRODUCTOSC2_A306PrdDescCorta ;
      private bool[] PRODUCTOSC2_n306PrdDescCorta ;
      private String[] PRODUCTOSC2_A289PrdEstado ;
      private bool[] PRODUCTOSC2_n289PrdEstado ;
      private short[] PRODUCTOSC2_A288PrdPres ;
      private bool[] PRODUCTOSC2_n288PrdPres ;
      private short[] PRODUCTOSC2_A32categID ;
      private short[] PRODUCTOSC2_A286PrdCod ;
      private short[] PRODUCTOSC2_A2AgeID ;
      private short[] PRODUCTOSC2_A1EmpID ;
      private String[] PRODUCTOSC3_A144tipoProdDsc ;
      private bool[] PRODUCTOSC3_n144tipoProdDsc ;
   }

   public class productosconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmPRODUCTOSC2 ;
          prmPRODUCTOSC2 = new Object[] {
          } ;
          Object[] prmPRODUCTOSC3 ;
          prmPRODUCTOSC3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmPRODUCTOSC4 ;
          prmPRODUCTOSC4 = new Object[] {
          new Object[] {"@AV2EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6PrdPres",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV7PrdEstado",SqlDbType.Char,1,0} ,
          new Object[] {"@AV8PrdDescCorta",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV9PrdTipPrd",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10prdNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV11detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12detTipoProdDsc",SqlDbType.Char,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PRODUCTOSC2", "SELECT T1.[detTipoProdID], T1.[prdNombre], T1.[PrdTipPrd], T1.[PrdDescCorta], T1.[PrdEstado], T1.[PrdPres], T1.[categID], T1.[PrdCod], T1.[AgeID], T1.[EmpID] FROM ([Productos] T1 INNER JOIN [Categorias] T2 ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) ORDER BY T1.[EmpID], T1.[AgeID], T1.[PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODUCTOSC2,100,0,true,false )
             ,new CursorDef("PRODUCTOSC3", "SELECT [tipoProdDsc] FROM [TipoProducto] WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODUCTOSC3,1,0,true,false )
             ,new CursorDef("PRODUCTOSC4", "INSERT INTO [GXA0072]([EmpID], [AgeID], [PrdCod], [categID], [PrdPres], [PrdEstado], [PrdDescCorta], [PrdTipPrd], [prdNombre], [detTipoProdID], [detTipoProdDsc]) VALUES(@AV2EmpID, @AV3AgeID, @AV4PrdCod, @AV5categID, @AV6PrdPres, @AV7PrdEstado, @AV8PrdDescCorta, @AV9PrdTipPrd, @AV10prdNombre, @AV11detTipoProdID, @AV12detTipoProdDsc)", GxErrorMask.GX_NOMASK,prmPRODUCTOSC4)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(5, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(8, (short)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[13]);
                }
                stmt.SetParameter(10, (short)parms[14]);
                stmt.SetParameter(11, (String)parms[15]);
                return;
       }
    }

 }

}
