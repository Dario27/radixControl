/*
               File: excExportOPDet
        Description: exc Export OPDet
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:52:51.85
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
using GeneXus.Office;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class excexportopdet : GXProcedure
   {
      public excexportopdet( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public excexportopdet( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_ClienteID ,
                           short aP2_OrdenPeriodo ,
                           short aP3_OrdenAnio ,
                           short aP4_OrdenID ,
                           out String aP5_archivo )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9ClienteID = aP1_ClienteID;
         this.AV10OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV11OrdenAnio = aP3_OrdenAnio;
         this.AV12OrdenID = aP4_OrdenID;
         this.AV22archivo = "" ;
         initialize();
         executePrivate();
         aP5_archivo=this.AV22archivo;
      }

      public String executeUdp( short aP0_EmpID ,
                                short aP1_ClienteID ,
                                short aP2_OrdenPeriodo ,
                                short aP3_OrdenAnio ,
                                short aP4_OrdenID )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9ClienteID = aP1_ClienteID;
         this.AV10OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV11OrdenAnio = aP3_OrdenAnio;
         this.AV12OrdenID = aP4_OrdenID;
         this.AV22archivo = "" ;
         initialize();
         executePrivate();
         aP5_archivo=this.AV22archivo;
         return AV22archivo ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_ClienteID ,
                                 short aP2_OrdenPeriodo ,
                                 short aP3_OrdenAnio ,
                                 short aP4_OrdenID ,
                                 out String aP5_archivo )
      {
         excexportopdet objexcexportopdet;
         objexcexportopdet = new excexportopdet();
         objexcexportopdet.AV8EmpID = aP0_EmpID;
         objexcexportopdet.AV9ClienteID = aP1_ClienteID;
         objexcexportopdet.AV10OrdenPeriodo = aP2_OrdenPeriodo;
         objexcexportopdet.AV11OrdenAnio = aP3_OrdenAnio;
         objexcexportopdet.AV12OrdenID = aP4_OrdenID;
         objexcexportopdet.AV22archivo = "" ;
         objexcexportopdet.context.SetSubmitInitialConfig(context);
         objexcexportopdet.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objexcexportopdet);
         aP5_archivo=this.AV22archivo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((excexportopdet)stateInfo).executePrivate();
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
         AV13nombre = "RequisicionDetalles";
         AV22archivo = AV13nombre + ".xlsx";
         AV14Hoja.Open(AV22archivo);
         AV14Hoja.Clear();
         /* Execute user subroutine: 'EMPDSC' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV16fila = 2;
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Text = AV17emp;
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Size = 14;
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Bold = 1;
         AV16fila = 3;
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Text = "Requision Detalles - Items";
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Size = 12;
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Bold = 1;
         AV16fila = 4;
         AV14Hoja.get_Cells(AV16fila, 1, 1, 1).Text = "Nro.";
         AV14Hoja.get_Cells(AV16fila, 2, 1, 1).Text = "Tipo";
         AV14Hoja.get_Cells(AV16fila, 3, 1, 1).Text = "Categoria";
         AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Text = "Producto";
         AV14Hoja.get_Cells(AV16fila, 5, 1, 1).Text = "Precio";
         AV14Hoja.get_Cells(AV16fila, 6, 1, 1).Text = "Cantidad";
         AV14Hoja.get_Cells(AV16fila, 7, 1, 1).Text = "Valor";
         AV14Hoja.get_Cells(AV16fila, 8, 1, 1).Text = "Detalle";
         AV15i = 1;
         while ( AV15i <= 8 )
         {
            AV14Hoja.get_Cells(AV16fila, AV15i, 1, 1).Bold = 1;
            AV15i = (short)(AV15i+1);
         }
         AV16fila = (short)(AV16fila+1);
         /* Using cursor P00112 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV9ClienteID, AV10OrdenPeriodo, AV11OrdenAnio, AV12OrdenID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A32categID = P00112_A32categID[0];
            A33subCatID = P00112_A33subCatID[0];
            A22OrdenID = P00112_A22OrdenID[0];
            A25OrdenAnio = P00112_A25OrdenAnio[0];
            A24OrdenPeriodo = P00112_A24OrdenPeriodo[0];
            A5ClienteID = P00112_A5ClienteID[0];
            A1EmpID = P00112_A1EmpID[0];
            A36detTipoProdID = P00112_A36detTipoProdID[0];
            A41OrdenSecId = P00112_A41OrdenSecId[0];
            A146categDsc = P00112_A146categDsc[0];
            n146categDsc = P00112_n146categDsc[0];
            A148subCatDsc = P00112_A148subCatDsc[0];
            n148subCatDsc = P00112_n148subCatDsc[0];
            A251OrdenDetDetalle = P00112_A251OrdenDetDetalle[0];
            n251OrdenDetDetalle = P00112_n251OrdenDetDetalle[0];
            A150subCatPrec = P00112_A150subCatPrec[0];
            n150subCatPrec = P00112_n150subCatPrec[0];
            A208OrdenDetCant = P00112_A208OrdenDetCant[0];
            n208OrdenDetCant = P00112_n208OrdenDetCant[0];
            A146categDsc = P00112_A146categDsc[0];
            n146categDsc = P00112_n146categDsc[0];
            A148subCatDsc = P00112_A148subCatDsc[0];
            n148subCatDsc = P00112_n148subCatDsc[0];
            A150subCatPrec = P00112_A150subCatPrec[0];
            n150subCatPrec = P00112_n150subCatPrec[0];
            A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
            AV20tipId = A36detTipoProdID;
            /* Execute user subroutine: 'TIPOPRODDSC' */
            S131 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV14Hoja.get_Cells(AV16fila, 1, 1, 1).Number = A41OrdenSecId;
            AV14Hoja.get_Cells(AV16fila, 2, 1, 1).Text = AV19tipoProd;
            AV14Hoja.get_Cells(AV16fila, 3, 1, 1).Text = StringUtil.Trim( A146categDsc);
            AV14Hoja.get_Cells(AV16fila, 4, 1, 1).Text = StringUtil.Trim( A148subCatDsc);
            AV14Hoja.get_Cells(AV16fila, 5, 1, 1).Number = (double)(A150subCatPrec);
            AV14Hoja.get_Cells(AV16fila, 6, 1, 1).Number = (double)(A208OrdenDetCant);
            AV14Hoja.get_Cells(AV16fila, 7, 1, 1).Number = (double)(A209OrdenDetVal);
            AV14Hoja.get_Cells(AV16fila, 8, 1, 1).Text = A251OrdenDetDetalle;
            AV16fila = (short)(AV16fila+1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV14Hoja.Save();
         /* Execute user subroutine: 'CHECKSTATUS' */
         S121 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV14Hoja.Close();
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'EMPDSC' Routine */
         /* Using cursor P00113 */
         pr_default.execute(1, new Object[] {AV8EmpID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1EmpID = P00113_A1EmpID[0];
            A45EmpEst = P00113_A45EmpEst[0];
            n45EmpEst = P00113_n45EmpEst[0];
            A44empdsc = P00113_A44empdsc[0];
            n44empdsc = P00113_n44empdsc[0];
            AV17emp = StringUtil.Trim( A44empdsc);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void S121( )
      {
         /* 'CHECKSTATUS' Routine */
         if ( AV14Hoja.ErrCode != 0 )
         {
            AV22archivo = "";
            AV21ErrorMessage = AV14Hoja.ErrDescription;
            AV14Hoja.Close();
            returnInSub = true;
            if (true) return;
         }
      }

      protected void S131( )
      {
         /* 'TIPOPRODDSC' Routine */
         /* Using cursor P00114 */
         pr_default.execute(2, new Object[] {AV20tipId});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A31tipoProdID = P00114_A31tipoProdID[0];
            A145tipoProdEst = P00114_A145tipoProdEst[0];
            n145tipoProdEst = P00114_n145tipoProdEst[0];
            A144tipoProdDsc = P00114_A144tipoProdDsc[0];
            n144tipoProdDsc = P00114_n144tipoProdDsc[0];
            A1EmpID = P00114_A1EmpID[0];
            AV19tipoProd = A144tipoProdDsc;
            pr_default.readNext(2);
         }
         pr_default.close(2);
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
         AV13nombre = "";
         AV14Hoja = new ExcelDocumentI();
         AV17emp = "";
         scmdbuf = "";
         P00112_A32categID = new short[1] ;
         P00112_A33subCatID = new short[1] ;
         P00112_A22OrdenID = new short[1] ;
         P00112_A25OrdenAnio = new short[1] ;
         P00112_A24OrdenPeriodo = new short[1] ;
         P00112_A5ClienteID = new short[1] ;
         P00112_A1EmpID = new short[1] ;
         P00112_A36detTipoProdID = new short[1] ;
         P00112_A41OrdenSecId = new short[1] ;
         P00112_A146categDsc = new String[] {""} ;
         P00112_n146categDsc = new bool[] {false} ;
         P00112_A148subCatDsc = new String[] {""} ;
         P00112_n148subCatDsc = new bool[] {false} ;
         P00112_A251OrdenDetDetalle = new String[] {""} ;
         P00112_n251OrdenDetDetalle = new bool[] {false} ;
         P00112_A150subCatPrec = new decimal[1] ;
         P00112_n150subCatPrec = new bool[] {false} ;
         P00112_A208OrdenDetCant = new decimal[1] ;
         P00112_n208OrdenDetCant = new bool[] {false} ;
         A146categDsc = "";
         A148subCatDsc = "";
         A251OrdenDetDetalle = "";
         AV19tipoProd = "";
         P00113_A1EmpID = new short[1] ;
         P00113_A45EmpEst = new String[] {""} ;
         P00113_n45EmpEst = new bool[] {false} ;
         P00113_A44empdsc = new String[] {""} ;
         P00113_n44empdsc = new bool[] {false} ;
         A45EmpEst = "";
         A44empdsc = "";
         AV21ErrorMessage = "";
         P00114_A31tipoProdID = new short[1] ;
         P00114_A145tipoProdEst = new String[] {""} ;
         P00114_n145tipoProdEst = new bool[] {false} ;
         P00114_A144tipoProdDsc = new String[] {""} ;
         P00114_n144tipoProdDsc = new bool[] {false} ;
         P00114_A1EmpID = new short[1] ;
         A145tipoProdEst = "";
         A144tipoProdDsc = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.excexportopdet__default(),
            new Object[][] {
                new Object[] {
               P00112_A32categID, P00112_A33subCatID, P00112_A22OrdenID, P00112_A25OrdenAnio, P00112_A24OrdenPeriodo, P00112_A5ClienteID, P00112_A1EmpID, P00112_A36detTipoProdID, P00112_A41OrdenSecId, P00112_A146categDsc,
               P00112_n146categDsc, P00112_A148subCatDsc, P00112_n148subCatDsc, P00112_A251OrdenDetDetalle, P00112_n251OrdenDetDetalle, P00112_A150subCatPrec, P00112_n150subCatPrec, P00112_A208OrdenDetCant, P00112_n208OrdenDetCant
               }
               , new Object[] {
               P00113_A1EmpID, P00113_A45EmpEst, P00113_n45EmpEst, P00113_A44empdsc, P00113_n44empdsc
               }
               , new Object[] {
               P00114_A31tipoProdID, P00114_A145tipoProdEst, P00114_n145tipoProdEst, P00114_A144tipoProdDsc, P00114_n144tipoProdDsc, P00114_A1EmpID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9ClienteID ;
      private short AV10OrdenPeriodo ;
      private short AV11OrdenAnio ;
      private short AV12OrdenID ;
      private short AV16fila ;
      private short AV15i ;
      private short A32categID ;
      private short A33subCatID ;
      private short A22OrdenID ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short A5ClienteID ;
      private short A1EmpID ;
      private short A36detTipoProdID ;
      private short A41OrdenSecId ;
      private short AV20tipId ;
      private short A31tipoProdID ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private String scmdbuf ;
      private String A146categDsc ;
      private String A148subCatDsc ;
      private String A45EmpEst ;
      private String A145tipoProdEst ;
      private String A144tipoProdDsc ;
      private bool returnInSub ;
      private bool n146categDsc ;
      private bool n148subCatDsc ;
      private bool n251OrdenDetDetalle ;
      private bool n150subCatPrec ;
      private bool n208OrdenDetCant ;
      private bool n45EmpEst ;
      private bool n44empdsc ;
      private bool n145tipoProdEst ;
      private bool n144tipoProdDsc ;
      private String AV22archivo ;
      private String AV13nombre ;
      private String AV17emp ;
      private String A251OrdenDetDetalle ;
      private String AV19tipoProd ;
      private String A44empdsc ;
      private String AV21ErrorMessage ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00112_A32categID ;
      private short[] P00112_A33subCatID ;
      private short[] P00112_A22OrdenID ;
      private short[] P00112_A25OrdenAnio ;
      private short[] P00112_A24OrdenPeriodo ;
      private short[] P00112_A5ClienteID ;
      private short[] P00112_A1EmpID ;
      private short[] P00112_A36detTipoProdID ;
      private short[] P00112_A41OrdenSecId ;
      private String[] P00112_A146categDsc ;
      private bool[] P00112_n146categDsc ;
      private String[] P00112_A148subCatDsc ;
      private bool[] P00112_n148subCatDsc ;
      private String[] P00112_A251OrdenDetDetalle ;
      private bool[] P00112_n251OrdenDetDetalle ;
      private decimal[] P00112_A150subCatPrec ;
      private bool[] P00112_n150subCatPrec ;
      private decimal[] P00112_A208OrdenDetCant ;
      private bool[] P00112_n208OrdenDetCant ;
      private short[] P00113_A1EmpID ;
      private String[] P00113_A45EmpEst ;
      private bool[] P00113_n45EmpEst ;
      private String[] P00113_A44empdsc ;
      private bool[] P00113_n44empdsc ;
      private short[] P00114_A31tipoProdID ;
      private String[] P00114_A145tipoProdEst ;
      private bool[] P00114_n145tipoProdEst ;
      private String[] P00114_A144tipoProdDsc ;
      private bool[] P00114_n144tipoProdDsc ;
      private short[] P00114_A1EmpID ;
      private String aP5_archivo ;
      private ExcelDocumentI AV14Hoja ;
   }

   public class excexportopdet__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00112 ;
          prmP00112 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV11OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00113 ;
          prmP00113 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00114 ;
          prmP00114 = new Object[] {
          new Object[] {"@AV20tipId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00112", "SELECT T1.[categID], T1.[subCatID], T1.[OrdenID], T1.[OrdenAnio], T1.[OrdenPeriodo], T1.[ClienteID], T1.[EmpID], T1.[detTipoProdID], T1.[OrdenSecId], T2.[categDsc], T3.[subCatDsc], T1.[OrdenDetDetalle], T3.[subCatPrec], T1.[OrdenDetCant] FROM (([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[EmpID] = @AV8EmpID and T1.[ClienteID] = @AV9ClienteID and T1.[OrdenPeriodo] = @AV10OrdenPeriodo and T1.[OrdenAnio] = @AV11OrdenAnio and T1.[OrdenID] = @AV12OrdenID ORDER BY T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00112,100,0,true,false )
             ,new CursorDef("P00113", "SELECT [EmpID], [EmpEst], [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @AV8EmpID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00113,1,0,false,true )
             ,new CursorDef("P00114", "SELECT [tipoProdID], [tipoProdEst], [tipoProdDsc], [EmpID] FROM [TipoProducto] WITH (NOLOCK) WHERE [tipoProdID] = @AV20tipId ORDER BY [EmpID], [tipoProdID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00114,100,0,false,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 40) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((String[]) buf[11])[0] = rslt.getString(11, 40) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
                ((String[]) buf[13])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(12);
                ((decimal[]) buf[15])[0] = rslt.getDecimal(13) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(13);
                ((decimal[]) buf[17])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(14);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
