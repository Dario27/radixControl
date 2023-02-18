/*
               File: DespBodegaConversion
        Description: Conversion for table DespBodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/9/2023 12:19:14.78
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
   public class despbodegaconversion : GXProcedure
   {
      public despbodegaconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public despbodegaconversion( IGxContext context )
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
         despbodegaconversion objdespbodegaconversion;
         objdespbodegaconversion = new despbodegaconversion();
         objdespbodegaconversion.context.SetSubmitInitialConfig(context);
         objdespbodegaconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objdespbodegaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((despbodegaconversion)stateInfo).executePrivate();
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
         /* Using cursor DESPBODEGA2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A392DespBodOK = DESPBODEGA2_A392DespBodOK[0];
            n392DespBodOK = DESPBODEGA2_n392DespBodOK[0];
            A376DespBodDetalle = DESPBODEGA2_A376DespBodDetalle[0];
            n376DespBodDetalle = DESPBODEGA2_n376DespBodDetalle[0];
            A361DespBodCatId = DESPBODEGA2_A361DespBodCatId[0];
            n361DespBodCatId = DESPBODEGA2_n361DespBodCatId[0];
            A359DespBodADesp = DESPBODEGA2_A359DespBodADesp[0];
            n359DespBodADesp = DESPBODEGA2_n359DespBodADesp[0];
            A358DespBodValor = DESPBODEGA2_A358DespBodValor[0];
            n358DespBodValor = DESPBODEGA2_n358DespBodValor[0];
            A357DespBodCant = DESPBODEGA2_A357DespBodCant[0];
            n357DespBodCant = DESPBODEGA2_n357DespBodCant[0];
            A356DespBodPrdNombre = DESPBODEGA2_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = DESPBODEGA2_n356DespBodPrdNombre[0];
            A355DespBodCodPrd = DESPBODEGA2_A355DespBodCodPrd[0];
            n355DespBodCodPrd = DESPBODEGA2_n355DespBodCodPrd[0];
            A42BodCod = DESPBODEGA2_A42BodCod[0];
            A354DespBodOpId = DESPBODEGA2_A354DespBodOpId[0];
            A353DespBodNro = DESPBODEGA2_A353DespBodNro[0];
            A2AgeID = DESPBODEGA2_A2AgeID[0];
            A1EmpID = DESPBODEGA2_A1EmpID[0];
            /*
               INSERT RECORD ON TABLE GXA0086

            */
            AV2EmpID = A1EmpID;
            AV3AgeID = A2AgeID;
            AV4DespBodNro = A353DespBodNro;
            AV5DespBodOpId = A354DespBodOpId;
            AV6BodCod = A42BodCod;
            if ( DESPBODEGA2_n355DespBodCodPrd[0] )
            {
               AV7DespBodCodPrd = 0;
               nV7DespBodCodPrd = false;
               nV7DespBodCodPrd = true;
            }
            else
            {
               AV7DespBodCodPrd = A355DespBodCodPrd;
               nV7DespBodCodPrd = false;
            }
            if ( DESPBODEGA2_n356DespBodPrdNombre[0] )
            {
               AV8DespBodPrdNombre = "";
               nV8DespBodPrdNombre = false;
               nV8DespBodPrdNombre = true;
            }
            else
            {
               AV8DespBodPrdNombre = A356DespBodPrdNombre;
               nV8DespBodPrdNombre = false;
            }
            if ( DESPBODEGA2_n357DespBodCant[0] )
            {
               AV9DespBodCant = 0;
               nV9DespBodCant = false;
               nV9DespBodCant = true;
            }
            else
            {
               AV9DespBodCant = A357DespBodCant;
               nV9DespBodCant = false;
            }
            if ( DESPBODEGA2_n358DespBodValor[0] )
            {
               AV10DespBodValor = 0;
               nV10DespBodValor = false;
               nV10DespBodValor = true;
            }
            else
            {
               AV10DespBodValor = A358DespBodValor;
               nV10DespBodValor = false;
            }
            if ( DESPBODEGA2_n359DespBodADesp[0] )
            {
               AV11DespBodADesp = 0;
               nV11DespBodADesp = false;
               nV11DespBodADesp = true;
            }
            else
            {
               AV11DespBodADesp = (decimal)(A359DespBodADesp);
               nV11DespBodADesp = false;
            }
            if ( DESPBODEGA2_n361DespBodCatId[0] )
            {
               AV12DespBodCatId = 0;
               nV12DespBodCatId = false;
               nV12DespBodCatId = true;
            }
            else
            {
               AV12DespBodCatId = A361DespBodCatId;
               nV12DespBodCatId = false;
            }
            if ( DESPBODEGA2_n376DespBodDetalle[0] )
            {
               AV13DespBodDetalle = "";
               nV13DespBodDetalle = false;
               nV13DespBodDetalle = true;
            }
            else
            {
               AV13DespBodDetalle = A376DespBodDetalle;
               nV13DespBodDetalle = false;
            }
            if ( DESPBODEGA2_n392DespBodOK[0] )
            {
               AV14DespBodOK = "";
               nV14DespBodOK = false;
               nV14DespBodOK = true;
            }
            else
            {
               AV14DespBodOK = A392DespBodOK;
               nV14DespBodOK = false;
            }
            /* Using cursor DESPBODEGA3 */
            pr_default.execute(1, new Object[] {AV2EmpID, AV3AgeID, AV4DespBodNro, AV5DespBodOpId, AV6BodCod, nV7DespBodCodPrd, AV7DespBodCodPrd, nV8DespBodPrdNombre, AV8DespBodPrdNombre, nV9DespBodCant, AV9DespBodCant, nV10DespBodValor, AV10DespBodValor, nV11DespBodADesp, AV11DespBodADesp, nV12DespBodCatId, AV12DespBodCatId, nV13DespBodDetalle, AV13DespBodDetalle, nV14DespBodOK, AV14DespBodOK});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0086") ;
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
         DESPBODEGA2_A392DespBodOK = new String[] {""} ;
         DESPBODEGA2_n392DespBodOK = new bool[] {false} ;
         DESPBODEGA2_A376DespBodDetalle = new String[] {""} ;
         DESPBODEGA2_n376DespBodDetalle = new bool[] {false} ;
         DESPBODEGA2_A361DespBodCatId = new short[1] ;
         DESPBODEGA2_n361DespBodCatId = new bool[] {false} ;
         DESPBODEGA2_A359DespBodADesp = new int[1] ;
         DESPBODEGA2_n359DespBodADesp = new bool[] {false} ;
         DESPBODEGA2_A358DespBodValor = new decimal[1] ;
         DESPBODEGA2_n358DespBodValor = new bool[] {false} ;
         DESPBODEGA2_A357DespBodCant = new int[1] ;
         DESPBODEGA2_n357DespBodCant = new bool[] {false} ;
         DESPBODEGA2_A356DespBodPrdNombre = new String[] {""} ;
         DESPBODEGA2_n356DespBodPrdNombre = new bool[] {false} ;
         DESPBODEGA2_A355DespBodCodPrd = new short[1] ;
         DESPBODEGA2_n355DespBodCodPrd = new bool[] {false} ;
         DESPBODEGA2_A42BodCod = new short[1] ;
         DESPBODEGA2_A354DespBodOpId = new short[1] ;
         DESPBODEGA2_A353DespBodNro = new short[1] ;
         DESPBODEGA2_A2AgeID = new short[1] ;
         DESPBODEGA2_A1EmpID = new short[1] ;
         A392DespBodOK = "";
         A376DespBodDetalle = "";
         A356DespBodPrdNombre = "";
         AV8DespBodPrdNombre = "";
         AV13DespBodDetalle = "";
         AV14DespBodOK = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.despbodegaconversion__default(),
            new Object[][] {
                new Object[] {
               DESPBODEGA2_A392DespBodOK, DESPBODEGA2_n392DespBodOK, DESPBODEGA2_A376DespBodDetalle, DESPBODEGA2_n376DespBodDetalle, DESPBODEGA2_A361DespBodCatId, DESPBODEGA2_n361DespBodCatId, DESPBODEGA2_A359DespBodADesp, DESPBODEGA2_n359DespBodADesp, DESPBODEGA2_A358DespBodValor, DESPBODEGA2_n358DespBodValor,
               DESPBODEGA2_A357DespBodCant, DESPBODEGA2_n357DespBodCant, DESPBODEGA2_A356DespBodPrdNombre, DESPBODEGA2_n356DespBodPrdNombre, DESPBODEGA2_A355DespBodCodPrd, DESPBODEGA2_n355DespBodCodPrd, DESPBODEGA2_A42BodCod, DESPBODEGA2_A354DespBodOpId, DESPBODEGA2_A353DespBodNro, DESPBODEGA2_A2AgeID,
               DESPBODEGA2_A1EmpID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A361DespBodCatId ;
      private short A355DespBodCodPrd ;
      private short A42BodCod ;
      private short A354DespBodOpId ;
      private short A353DespBodNro ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short AV2EmpID ;
      private short AV3AgeID ;
      private short AV4DespBodNro ;
      private short AV5DespBodOpId ;
      private short AV6BodCod ;
      private short AV7DespBodCodPrd ;
      private short AV12DespBodCatId ;
      private int A359DespBodADesp ;
      private int A357DespBodCant ;
      private int GIGXA0086 ;
      private int AV9DespBodCant ;
      private decimal A358DespBodValor ;
      private decimal AV10DespBodValor ;
      private decimal AV11DespBodADesp ;
      private String scmdbuf ;
      private String A392DespBodOK ;
      private String A376DespBodDetalle ;
      private String A356DespBodPrdNombre ;
      private String AV8DespBodPrdNombre ;
      private String AV13DespBodDetalle ;
      private String AV14DespBodOK ;
      private String Gx_emsg ;
      private bool n392DespBodOK ;
      private bool n376DespBodDetalle ;
      private bool n361DespBodCatId ;
      private bool n359DespBodADesp ;
      private bool n358DespBodValor ;
      private bool n357DespBodCant ;
      private bool n356DespBodPrdNombre ;
      private bool n355DespBodCodPrd ;
      private bool nV7DespBodCodPrd ;
      private bool nV8DespBodPrdNombre ;
      private bool nV9DespBodCant ;
      private bool nV10DespBodValor ;
      private bool nV11DespBodADesp ;
      private bool nV12DespBodCatId ;
      private bool nV13DespBodDetalle ;
      private bool nV14DespBodOK ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] DESPBODEGA2_A392DespBodOK ;
      private bool[] DESPBODEGA2_n392DespBodOK ;
      private String[] DESPBODEGA2_A376DespBodDetalle ;
      private bool[] DESPBODEGA2_n376DespBodDetalle ;
      private short[] DESPBODEGA2_A361DespBodCatId ;
      private bool[] DESPBODEGA2_n361DespBodCatId ;
      private int[] DESPBODEGA2_A359DespBodADesp ;
      private bool[] DESPBODEGA2_n359DespBodADesp ;
      private decimal[] DESPBODEGA2_A358DespBodValor ;
      private bool[] DESPBODEGA2_n358DespBodValor ;
      private int[] DESPBODEGA2_A357DespBodCant ;
      private bool[] DESPBODEGA2_n357DespBodCant ;
      private String[] DESPBODEGA2_A356DespBodPrdNombre ;
      private bool[] DESPBODEGA2_n356DespBodPrdNombre ;
      private short[] DESPBODEGA2_A355DespBodCodPrd ;
      private bool[] DESPBODEGA2_n355DespBodCodPrd ;
      private short[] DESPBODEGA2_A42BodCod ;
      private short[] DESPBODEGA2_A354DespBodOpId ;
      private short[] DESPBODEGA2_A353DespBodNro ;
      private short[] DESPBODEGA2_A2AgeID ;
      private short[] DESPBODEGA2_A1EmpID ;
   }

   public class despbodegaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmDESPBODEGA2 ;
          prmDESPBODEGA2 = new Object[] {
          } ;
          Object[] prmDESPBODEGA3 ;
          prmDESPBODEGA3 = new Object[] {
          new Object[] {"@AV2EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@AV9DespBodCant",SqlDbType.Int,6,0} ,
          new Object[] {"@AV10DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV11DespBodADesp",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV12DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV13DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@AV14DespBodOK",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("DESPBODEGA2", "SELECT [DespBodOK], [DespBodDetalle], [DespBodCatId], [DespBodADesp], [DespBodValor], [DespBodCant], [DespBodPrdNombre], [DespBodCodPrd], [BodCod], [DespBodOpId], [DespBodNro], [AgeID], [EmpID] FROM [DespBodega] ORDER BY [EmpID], [AgeID], [DespBodNro], [DespBodOpId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmDESPBODEGA2,100,0,true,false )
             ,new CursorDef("DESPBODEGA3", "INSERT INTO [GXA0086]([EmpID], [AgeID], [DespBodNro], [DespBodOpId], [BodCod], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodCatId], [DespBodDetalle], [DespBodOK]) VALUES(@AV2EmpID, @AV3AgeID, @AV4DespBodNro, @AV5DespBodOpId, @AV6BodCod, @AV7DespBodCodPrd, @AV8DespBodPrdNombre, @AV9DespBodCant, @AV10DespBodValor, @AV11DespBodADesp, @AV12DespBodCatId, @AV13DespBodDetalle, @AV14DespBodOK)", GxErrorMask.GX_NOMASK,prmDESPBODEGA3)
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
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((short[]) buf[14])[0] = rslt.getShort(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((short[]) buf[16])[0] = rslt.getShort(9) ;
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
                ((short[]) buf[20])[0] = rslt.getShort(13) ;
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
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(6, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 11 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(11, (short)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 13 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[20]);
                }
                return;
       }
    }

 }

}
