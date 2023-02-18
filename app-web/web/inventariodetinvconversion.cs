/*
               File: InventariodetInvConversion
        Description: Conversion for table InventariodetInv
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 8/30/2022 23:5:32.10
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
   public class inventariodetinvconversion : GXProcedure
   {
      public inventariodetinvconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public inventariodetinvconversion( IGxContext context )
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
         inventariodetinvconversion objinventariodetinvconversion;
         objinventariodetinvconversion = new inventariodetinvconversion();
         objinventariodetinvconversion.context.SetSubmitInitialConfig(context);
         objinventariodetinvconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objinventariodetinvconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((inventariodetinvconversion)stateInfo).executePrivate();
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
         /* Using cursor INVENTARIO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31tipoProdID = INVENTARIO2_A31tipoProdID[0];
            A280detInvStock = INVENTARIO2_A280detInvStock[0];
            n280detInvStock = INVENTARIO2_n280detInvStock[0];
            A279detInvPeriodo = INVENTARIO2_A279detInvPeriodo[0];
            n279detInvPeriodo = INVENTARIO2_n279detInvPeriodo[0];
            A278detInvAnio = INVENTARIO2_A278detInvAnio[0];
            n278detInvAnio = INVENTARIO2_n278detInvAnio[0];
            A275detInvCosto = INVENTARIO2_A275detInvCosto[0];
            n275detInvCosto = INVENTARIO2_n275detInvCosto[0];
            A274detInvCant = INVENTARIO2_A274detInvCant[0];
            n274detInvCant = INVENTARIO2_n274detInvCant[0];
            A33subCatID = INVENTARIO2_A33subCatID[0];
            A32categID = INVENTARIO2_A32categID[0];
            A273detInvId = INVENTARIO2_A273detInvId[0];
            A264invCod = INVENTARIO2_A264invCod[0];
            A42BodCod = INVENTARIO2_A42BodCod[0];
            A2AgeID = INVENTARIO2_A2AgeID[0];
            A1EmpID = INVENTARIO2_A1EmpID[0];
            A31tipoProdID = INVENTARIO2_A31tipoProdID[0];
            /*
               INSERT RECORD ON TABLE GXA0051

            */
            AV2EmpID = A1EmpID;
            AV3AgeID = A2AgeID;
            AV4BodCod = A42BodCod;
            AV5invCod = A264invCod;
            AV6detInvId = A273detInvId;
            AV7categID = A32categID;
            AV8subCatID = A33subCatID;
            if ( INVENTARIO2_n274detInvCant[0] )
            {
               AV9detInvCant = 0;
               nV9detInvCant = false;
               nV9detInvCant = true;
            }
            else
            {
               AV9detInvCant = A274detInvCant;
               nV9detInvCant = false;
            }
            if ( INVENTARIO2_n275detInvCosto[0] )
            {
               AV10detInvCosto = 0;
               nV10detInvCosto = false;
               nV10detInvCosto = true;
            }
            else
            {
               AV10detInvCosto = A275detInvCosto;
               nV10detInvCosto = false;
            }
            if ( INVENTARIO2_n278detInvAnio[0] )
            {
               AV11detInvAnio = 0;
               nV11detInvAnio = false;
               nV11detInvAnio = true;
            }
            else
            {
               AV11detInvAnio = A278detInvAnio;
               nV11detInvAnio = false;
            }
            if ( INVENTARIO2_n279detInvPeriodo[0] )
            {
               AV12detInvPeriodo = 0;
               nV12detInvPeriodo = false;
               nV12detInvPeriodo = true;
            }
            else
            {
               AV12detInvPeriodo = A279detInvPeriodo;
               nV12detInvPeriodo = false;
            }
            if ( INVENTARIO2_n280detInvStock[0] )
            {
               AV13detInvStock = 0;
               nV13detInvStock = false;
               nV13detInvStock = true;
            }
            else
            {
               AV13detInvStock = A280detInvStock;
               nV13detInvStock = false;
            }
            if ( INVENTARIO2_n31tipoProdID[0] )
            {
               AV14detTipoProdID = 0;
            }
            else
            {
               AV14detTipoProdID = A31tipoProdID;
            }
            /* Using cursor INVENTARIO3 */
            pr_default.execute(1, new Object[] {AV2EmpID, AV3AgeID, AV4BodCod, AV5invCod, AV6detInvId, AV7categID, AV8subCatID, nV9detInvCant, AV9detInvCant, nV10detInvCosto, AV10detInvCosto, nV11detInvAnio, AV11detInvAnio, nV12detInvPeriodo, AV12detInvPeriodo, nV13detInvStock, AV13detInvStock, AV14detTipoProdID});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0051") ;
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
         INVENTARIO2_A31tipoProdID = new short[1] ;
         INVENTARIO2_A280detInvStock = new int[1] ;
         INVENTARIO2_n280detInvStock = new bool[] {false} ;
         INVENTARIO2_A279detInvPeriodo = new short[1] ;
         INVENTARIO2_n279detInvPeriodo = new bool[] {false} ;
         INVENTARIO2_A278detInvAnio = new short[1] ;
         INVENTARIO2_n278detInvAnio = new bool[] {false} ;
         INVENTARIO2_A275detInvCosto = new decimal[1] ;
         INVENTARIO2_n275detInvCosto = new bool[] {false} ;
         INVENTARIO2_A274detInvCant = new int[1] ;
         INVENTARIO2_n274detInvCant = new bool[] {false} ;
         INVENTARIO2_A33subCatID = new short[1] ;
         INVENTARIO2_A32categID = new short[1] ;
         INVENTARIO2_A273detInvId = new short[1] ;
         INVENTARIO2_A264invCod = new short[1] ;
         INVENTARIO2_A42BodCod = new short[1] ;
         INVENTARIO2_A2AgeID = new short[1] ;
         INVENTARIO2_A1EmpID = new short[1] ;
         INVENTARIO2_n31tipoProdID = new bool[] {false} ;
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.inventariodetinvconversion__default(),
            new Object[][] {
                new Object[] {
               INVENTARIO2_A31tipoProdID, INVENTARIO2_A280detInvStock, INVENTARIO2_n280detInvStock, INVENTARIO2_A279detInvPeriodo, INVENTARIO2_n279detInvPeriodo, INVENTARIO2_A278detInvAnio, INVENTARIO2_n278detInvAnio, INVENTARIO2_A275detInvCosto, INVENTARIO2_n275detInvCosto, INVENTARIO2_A274detInvCant,
               INVENTARIO2_n274detInvCant, INVENTARIO2_A33subCatID, INVENTARIO2_A32categID, INVENTARIO2_A273detInvId, INVENTARIO2_A264invCod, INVENTARIO2_A42BodCod, INVENTARIO2_A2AgeID, INVENTARIO2_A1EmpID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A31tipoProdID ;
      private short A279detInvPeriodo ;
      private short A278detInvAnio ;
      private short A33subCatID ;
      private short A32categID ;
      private short A273detInvId ;
      private short A264invCod ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short AV2EmpID ;
      private short AV3AgeID ;
      private short AV4BodCod ;
      private short AV5invCod ;
      private short AV6detInvId ;
      private short AV7categID ;
      private short AV8subCatID ;
      private short AV11detInvAnio ;
      private short AV12detInvPeriodo ;
      private short AV14detTipoProdID ;
      private int A280detInvStock ;
      private int A274detInvCant ;
      private int GIGXA0051 ;
      private int AV9detInvCant ;
      private int AV13detInvStock ;
      private decimal A275detInvCosto ;
      private decimal AV10detInvCosto ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool n280detInvStock ;
      private bool n279detInvPeriodo ;
      private bool n278detInvAnio ;
      private bool n275detInvCosto ;
      private bool n274detInvCant ;
      private bool nV9detInvCant ;
      private bool nV10detInvCosto ;
      private bool nV11detInvAnio ;
      private bool nV12detInvPeriodo ;
      private bool nV13detInvStock ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] INVENTARIO2_A31tipoProdID ;
      private int[] INVENTARIO2_A280detInvStock ;
      private bool[] INVENTARIO2_n280detInvStock ;
      private short[] INVENTARIO2_A279detInvPeriodo ;
      private bool[] INVENTARIO2_n279detInvPeriodo ;
      private short[] INVENTARIO2_A278detInvAnio ;
      private bool[] INVENTARIO2_n278detInvAnio ;
      private decimal[] INVENTARIO2_A275detInvCosto ;
      private bool[] INVENTARIO2_n275detInvCosto ;
      private int[] INVENTARIO2_A274detInvCant ;
      private bool[] INVENTARIO2_n274detInvCant ;
      private short[] INVENTARIO2_A33subCatID ;
      private short[] INVENTARIO2_A32categID ;
      private short[] INVENTARIO2_A273detInvId ;
      private short[] INVENTARIO2_A264invCod ;
      private short[] INVENTARIO2_A42BodCod ;
      private short[] INVENTARIO2_A2AgeID ;
      private short[] INVENTARIO2_A1EmpID ;
      private bool[] INVENTARIO2_n31tipoProdID ;
   }

   public class inventariodetinvconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmINVENTARIO2 ;
          prmINVENTARIO2 = new Object[] {
          } ;
          Object[] prmINVENTARIO3 ;
          prmINVENTARIO3 = new Object[] {
          new Object[] {"@AV2EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5invCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6detInvId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9detInvCant",SqlDbType.Int,8,0} ,
          new Object[] {"@AV10detInvCosto",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV11detInvAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12detInvPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV13detInvStock",SqlDbType.Int,8,0} ,
          new Object[] {"@AV14detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("INVENTARIO2", "SELECT T2.[tipoProdID], T1.[detInvStock], T1.[detInvPeriodo], T1.[detInvAnio], T1.[detInvCosto], T1.[detInvCant], T1.[subCatID], T1.[categID], T1.[detInvId], T1.[invCod], T1.[BodCod], T1.[AgeID], T1.[EmpID] FROM ([InventariodetInv] T1 INNER JOIN [Categorias] T2 ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) ORDER BY T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[invCod], T1.[detInvId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmINVENTARIO2,100,0,true,false )
             ,new CursorDef("INVENTARIO3", "INSERT INTO [GXA0051]([EmpID], [AgeID], [BodCod], [invCod], [detInvId], [categID], [subCatID], [detInvCant], [detInvCosto], [detInvAnio], [detInvPeriodo], [detInvStock], [detTipoProdID]) VALUES(@AV2EmpID, @AV3AgeID, @AV4BodCod, @AV5invCod, @AV6detInvId, @AV7categID, @AV8subCatID, @AV9detInvCant, @AV10detInvCosto, @AV11detInvAnio, @AV12detInvPeriodo, @AV13detInvStock, @AV14detTipoProdID)", GxErrorMask.GX_NOMASK,prmINVENTARIO3)
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((short[]) buf[11])[0] = rslt.getShort(7) ;
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((short[]) buf[13])[0] = rslt.getShort(9) ;
                ((short[]) buf[14])[0] = rslt.getShort(10) ;
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((short[]) buf[16])[0] = rslt.getShort(12) ;
                ((short[]) buf[17])[0] = rslt.getShort(13) ;
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
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 11 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(11, (short)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 12 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(12, (int)parms[16]);
                }
                stmt.SetParameter(13, (short)parms[17]);
                return;
       }
    }

 }

}
