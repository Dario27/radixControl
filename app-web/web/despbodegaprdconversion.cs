/*
               File: DespBodegaprdConversion
        Description: Conversion for table DespBodegaprd
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/19/2023 22:33:6.13
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
   public class despbodegaprdconversion : GXProcedure
   {
      public despbodegaprdconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public despbodegaprdconversion( IGxContext context )
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
         despbodegaprdconversion objdespbodegaprdconversion;
         objdespbodegaprdconversion = new despbodegaprdconversion();
         objdespbodegaprdconversion.context.SetSubmitInitialConfig(context);
         objdespbodegaprdconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objdespbodegaprdconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((despbodegaprdconversion)stateInfo).executePrivate();
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
            A361DespBodCatId = DESPBODEGA2_A361DespBodCatId[0];
            n361DespBodCatId = DESPBODEGA2_n361DespBodCatId[0];
            A376DespBodDetalle = DESPBODEGA2_A376DespBodDetalle[0];
            n376DespBodDetalle = DESPBODEGA2_n376DespBodDetalle[0];
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
            A400nroReg = DESPBODEGA2_A400nroReg[0];
            A5ClienteID = DESPBODEGA2_A5ClienteID[0];
            A22OrdenID = DESPBODEGA2_A22OrdenID[0];
            A353DespBodNro = DESPBODEGA2_A353DespBodNro[0];
            A2AgeID = DESPBODEGA2_A2AgeID[0];
            A1EmpID = DESPBODEGA2_A1EmpID[0];
            A5ClienteID = DESPBODEGA2_A5ClienteID[0];
            /*
               INSERT RECORD ON TABLE GXA0094

            */
            AV2EmpID = A1EmpID;
            AV3AgeID = A2AgeID;
            AV4DespBodNro = A353DespBodNro;
            AV5OrdenID = A22OrdenID;
            AV6ClienteID = A5ClienteID;
            AV7nroReg = A400nroReg;
            if ( DESPBODEGA2_n355DespBodCodPrd[0] )
            {
               AV8DespBodCodPrd = 0;
               nV8DespBodCodPrd = false;
               nV8DespBodCodPrd = true;
            }
            else
            {
               AV8DespBodCodPrd = A355DespBodCodPrd;
               nV8DespBodCodPrd = false;
            }
            if ( DESPBODEGA2_n356DespBodPrdNombre[0] )
            {
               AV9DespBodPrdNombre = "";
               nV9DespBodPrdNombre = false;
               nV9DespBodPrdNombre = true;
            }
            else
            {
               AV9DespBodPrdNombre = A356DespBodPrdNombre;
               nV9DespBodPrdNombre = false;
            }
            if ( DESPBODEGA2_n357DespBodCant[0] )
            {
               AV10DespBodCant = 0;
               nV10DespBodCant = false;
               nV10DespBodCant = true;
            }
            else
            {
               AV10DespBodCant = A357DespBodCant;
               nV10DespBodCant = false;
            }
            if ( DESPBODEGA2_n358DespBodValor[0] )
            {
               AV11DespBodValor = 0;
               nV11DespBodValor = false;
               nV11DespBodValor = true;
            }
            else
            {
               AV11DespBodValor = A358DespBodValor;
               nV11DespBodValor = false;
            }
            if ( DESPBODEGA2_n359DespBodADesp[0] )
            {
               AV12DespBodADesp = 0;
               nV12DespBodADesp = false;
               nV12DespBodADesp = true;
            }
            else
            {
               AV12DespBodADesp = A359DespBodADesp;
               nV12DespBodADesp = false;
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
            if ( DESPBODEGA2_n361DespBodCatId[0] )
            {
               AV14DespBodCatId = 0;
               nV14DespBodCatId = false;
               nV14DespBodCatId = true;
            }
            else
            {
               AV14DespBodCatId = A361DespBodCatId;
               nV14DespBodCatId = false;
            }
            if ( DESPBODEGA2_n392DespBodOK[0] )
            {
               AV15DespBodOK = "";
               nV15DespBodOK = false;
               nV15DespBodOK = true;
            }
            else
            {
               AV15DespBodOK = A392DespBodOK;
               nV15DespBodOK = false;
            }
            /* Using cursor DESPBODEGA3 */
            pr_default.execute(1, new Object[] {AV2EmpID, AV3AgeID, AV4DespBodNro, AV5OrdenID, AV6ClienteID, AV7nroReg, nV8DespBodCodPrd, AV8DespBodCodPrd, nV9DespBodPrdNombre, AV9DespBodPrdNombre, nV10DespBodCant, AV10DespBodCant, nV11DespBodValor, AV11DespBodValor, nV12DespBodADesp, AV12DespBodADesp, nV13DespBodDetalle, AV13DespBodDetalle, nV14DespBodCatId, AV14DespBodCatId, nV15DespBodOK, AV15DespBodOK});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0094") ;
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
         DESPBODEGA2_A361DespBodCatId = new short[1] ;
         DESPBODEGA2_n361DespBodCatId = new bool[] {false} ;
         DESPBODEGA2_A376DespBodDetalle = new String[] {""} ;
         DESPBODEGA2_n376DespBodDetalle = new bool[] {false} ;
         DESPBODEGA2_A359DespBodADesp = new decimal[1] ;
         DESPBODEGA2_n359DespBodADesp = new bool[] {false} ;
         DESPBODEGA2_A358DespBodValor = new decimal[1] ;
         DESPBODEGA2_n358DespBodValor = new bool[] {false} ;
         DESPBODEGA2_A357DespBodCant = new decimal[1] ;
         DESPBODEGA2_n357DespBodCant = new bool[] {false} ;
         DESPBODEGA2_A356DespBodPrdNombre = new String[] {""} ;
         DESPBODEGA2_n356DespBodPrdNombre = new bool[] {false} ;
         DESPBODEGA2_A355DespBodCodPrd = new short[1] ;
         DESPBODEGA2_n355DespBodCodPrd = new bool[] {false} ;
         DESPBODEGA2_A400nroReg = new int[1] ;
         DESPBODEGA2_A5ClienteID = new short[1] ;
         DESPBODEGA2_A22OrdenID = new short[1] ;
         DESPBODEGA2_A353DespBodNro = new short[1] ;
         DESPBODEGA2_A2AgeID = new short[1] ;
         DESPBODEGA2_A1EmpID = new short[1] ;
         A392DespBodOK = "";
         A376DespBodDetalle = "";
         A356DespBodPrdNombre = "";
         AV9DespBodPrdNombre = "";
         AV13DespBodDetalle = "";
         AV15DespBodOK = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.despbodegaprdconversion__default(),
            new Object[][] {
                new Object[] {
               DESPBODEGA2_A392DespBodOK, DESPBODEGA2_n392DespBodOK, DESPBODEGA2_A361DespBodCatId, DESPBODEGA2_n361DespBodCatId, DESPBODEGA2_A376DespBodDetalle, DESPBODEGA2_n376DespBodDetalle, DESPBODEGA2_A359DespBodADesp, DESPBODEGA2_n359DespBodADesp, DESPBODEGA2_A358DespBodValor, DESPBODEGA2_n358DespBodValor,
               DESPBODEGA2_A357DespBodCant, DESPBODEGA2_n357DespBodCant, DESPBODEGA2_A356DespBodPrdNombre, DESPBODEGA2_n356DespBodPrdNombre, DESPBODEGA2_A355DespBodCodPrd, DESPBODEGA2_n355DespBodCodPrd, DESPBODEGA2_A400nroReg, DESPBODEGA2_A5ClienteID, DESPBODEGA2_A22OrdenID, DESPBODEGA2_A353DespBodNro,
               DESPBODEGA2_A2AgeID, DESPBODEGA2_A1EmpID
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
      private short A5ClienteID ;
      private short A22OrdenID ;
      private short A353DespBodNro ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short AV2EmpID ;
      private short AV3AgeID ;
      private short AV4DespBodNro ;
      private short AV5OrdenID ;
      private short AV6ClienteID ;
      private short AV8DespBodCodPrd ;
      private short AV14DespBodCatId ;
      private int A400nroReg ;
      private int GIGXA0094 ;
      private int AV7nroReg ;
      private decimal A359DespBodADesp ;
      private decimal A358DespBodValor ;
      private decimal A357DespBodCant ;
      private decimal AV10DespBodCant ;
      private decimal AV11DespBodValor ;
      private decimal AV12DespBodADesp ;
      private String scmdbuf ;
      private String A392DespBodOK ;
      private String A376DespBodDetalle ;
      private String A356DespBodPrdNombre ;
      private String AV9DespBodPrdNombre ;
      private String AV13DespBodDetalle ;
      private String AV15DespBodOK ;
      private String Gx_emsg ;
      private bool n392DespBodOK ;
      private bool n361DespBodCatId ;
      private bool n376DespBodDetalle ;
      private bool n359DespBodADesp ;
      private bool n358DespBodValor ;
      private bool n357DespBodCant ;
      private bool n356DespBodPrdNombre ;
      private bool n355DespBodCodPrd ;
      private bool nV8DespBodCodPrd ;
      private bool nV9DespBodPrdNombre ;
      private bool nV10DespBodCant ;
      private bool nV11DespBodValor ;
      private bool nV12DespBodADesp ;
      private bool nV13DespBodDetalle ;
      private bool nV14DespBodCatId ;
      private bool nV15DespBodOK ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] DESPBODEGA2_A392DespBodOK ;
      private bool[] DESPBODEGA2_n392DespBodOK ;
      private short[] DESPBODEGA2_A361DespBodCatId ;
      private bool[] DESPBODEGA2_n361DespBodCatId ;
      private String[] DESPBODEGA2_A376DespBodDetalle ;
      private bool[] DESPBODEGA2_n376DespBodDetalle ;
      private decimal[] DESPBODEGA2_A359DespBodADesp ;
      private bool[] DESPBODEGA2_n359DespBodADesp ;
      private decimal[] DESPBODEGA2_A358DespBodValor ;
      private bool[] DESPBODEGA2_n358DespBodValor ;
      private decimal[] DESPBODEGA2_A357DespBodCant ;
      private bool[] DESPBODEGA2_n357DespBodCant ;
      private String[] DESPBODEGA2_A356DespBodPrdNombre ;
      private bool[] DESPBODEGA2_n356DespBodPrdNombre ;
      private short[] DESPBODEGA2_A355DespBodCodPrd ;
      private bool[] DESPBODEGA2_n355DespBodCodPrd ;
      private int[] DESPBODEGA2_A400nroReg ;
      private short[] DESPBODEGA2_A5ClienteID ;
      private short[] DESPBODEGA2_A22OrdenID ;
      private short[] DESPBODEGA2_A353DespBodNro ;
      private short[] DESPBODEGA2_A2AgeID ;
      private short[] DESPBODEGA2_A1EmpID ;
   }

   public class despbodegaprdconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV5OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7nroReg",SqlDbType.Int,6,0} ,
          new Object[] {"@AV8DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@AV10DespBodCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV11DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV12DespBodADesp",SqlDbType.Decimal,8,2} ,
          new Object[] {"@AV13DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@AV14DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15DespBodOK",SqlDbType.Char,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("DESPBODEGA2", "SELECT T1.[DespBodOK], T1.[DespBodCatId], T1.[DespBodDetalle], T1.[DespBodADesp], T1.[DespBodValor], T1.[DespBodCant], T1.[DespBodPrdNombre], T1.[DespBodCodPrd], T1.[nroReg], T2.[ClienteID], T1.[OrdenID], T1.[DespBodNro], T1.[AgeID], T1.[EmpID] FROM ([DespBodegaprd] T1 INNER JOIN [DespBodega] T2 ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[DespBodNro] = T1.[DespBodNro] AND T2.[OrdenID] = T1.[OrdenID]) WHERE Not T2.[ClienteID] IS NULL ORDER BY T1.[EmpID], T1.[AgeID], T1.[DespBodNro], T1.[OrdenID], T1.[nroReg] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmDESPBODEGA2,100,0,true,false )
             ,new CursorDef("DESPBODEGA3", "INSERT INTO [GXA0094]([EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodDetalle], [DespBodCatId], [DespBodOK]) VALUES(@AV2EmpID, @AV3AgeID, @AV4DespBodNro, @AV5OrdenID, @AV6ClienteID, @AV7nroReg, @AV8DespBodCodPrd, @AV9DespBodPrdNombre, @AV10DespBodCant, @AV11DespBodValor, @AV12DespBodADesp, @AV13DespBodDetalle, @AV14DespBodCatId, @AV15DespBodOK)", GxErrorMask.GX_NOMASK,prmDESPBODEGA3)
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
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((short[]) buf[14])[0] = rslt.getShort(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((int[]) buf[16])[0] = rslt.getInt(9) ;
                ((short[]) buf[17])[0] = rslt.getShort(10) ;
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((short[]) buf[19])[0] = rslt.getShort(12) ;
                ((short[]) buf[20])[0] = rslt.getShort(13) ;
                ((short[]) buf[21])[0] = rslt.getShort(14) ;
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
                stmt.SetParameter(6, (int)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(11, (decimal)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 13 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(13, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 14 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[21]);
                }
                return;
       }
    }

 }

}
