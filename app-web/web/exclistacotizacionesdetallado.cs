/*
               File: excListaCotizacionesDetallado
        Description: exc Lista Cotizaciones Detallado
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:52:51.56
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
   public class exclistacotizacionesdetallado : GXProcedure
   {
      public exclistacotizacionesdetallado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public exclistacotizacionesdetallado( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_protId ,
                           short aP2_cotiId ,
                           out String aP3_archivo )
      {
         this.AV9empID = aP0_empID;
         this.AV17protId = aP1_protId;
         this.AV18cotiId = aP2_cotiId;
         this.AV8archivo = "" ;
         initialize();
         executePrivate();
         aP3_archivo=this.AV8archivo;
      }

      public String executeUdp( short aP0_empID ,
                                short aP1_protId ,
                                short aP2_cotiId )
      {
         this.AV9empID = aP0_empID;
         this.AV17protId = aP1_protId;
         this.AV18cotiId = aP2_cotiId;
         this.AV8archivo = "" ;
         initialize();
         executePrivate();
         aP3_archivo=this.AV8archivo;
         return AV8archivo ;
      }

      public void executeSubmit( short aP0_empID ,
                                 short aP1_protId ,
                                 short aP2_cotiId ,
                                 out String aP3_archivo )
      {
         exclistacotizacionesdetallado objexclistacotizacionesdetallado;
         objexclistacotizacionesdetallado = new exclistacotizacionesdetallado();
         objexclistacotizacionesdetallado.AV9empID = aP0_empID;
         objexclistacotizacionesdetallado.AV17protId = aP1_protId;
         objexclistacotizacionesdetallado.AV18cotiId = aP2_cotiId;
         objexclistacotizacionesdetallado.AV8archivo = "" ;
         objexclistacotizacionesdetallado.context.SetSubmitInitialConfig(context);
         objexclistacotizacionesdetallado.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objexclistacotizacionesdetallado);
         aP3_archivo=this.AV8archivo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((exclistacotizacionesdetallado)stateInfo).executePrivate();
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
         AV13idx = GXUtil.Sleep( 1);
         AV16ProgressIndicator.gxTpr_Type = 1;
         AV15nombre = "Cotizaciones_Detallado";
         AV8archivo = AV15nombre + ".xlsx";
         AV11Hoja.Open(AV8archivo);
         AV11Hoja.Clear();
         AV13idx = GXUtil.Sleep( 2);
         AV16ProgressIndicator.showwithtitle( "Generando Columnas");
         AV16ProgressIndicator.gxTpr_Value = 10;
         AV12i = 1;
         AV11Hoja.get_Cells(AV12i, 1, 1, 1).Text = "Nro. Secuencia";
         AV11Hoja.get_Cells(AV12i, 2, 1, 1).Text = "Prototipo";
         AV11Hoja.get_Cells(AV12i, 3, 1, 1).Text = "Descripcion";
         AV11Hoja.get_Cells(AV12i, 4, 1, 1).Text = "idDetalle";
         AV11Hoja.get_Cells(AV12i, 5, 1, 1).Text = "Tipo Producto";
         AV11Hoja.get_Cells(AV12i, 6, 1, 1).Text = "Categoria";
         AV11Hoja.get_Cells(AV12i, 7, 1, 1).Text = "Subcategoria";
         AV11Hoja.get_Cells(AV12i, 8, 1, 1).Text = "Precio";
         AV11Hoja.get_Cells(AV12i, 9, 1, 1).Text = "Cantidad";
         AV11Hoja.get_Cells(AV12i, 10, 1, 1).Text = "Valor";
         AV11Hoja.get_Cells(AV12i, 11, 1, 1).Text = "IVA";
         AV11Hoja.get_Cells(AV12i, 12, 1, 1).Text = "Total";
         AV14j = 1;
         while ( AV14j <= 12 )
         {
            AV11Hoja.get_Cells(AV12i, AV14j, 1, 1).Bold = 1;
            AV14j = (short)(AV14j+1);
         }
         AV12i = (short)(AV12i+1);
         AV13idx = GXUtil.Sleep( 2);
         AV16ProgressIndicator.showwithtitle( "Generando Reporte: "+AV8archivo);
         AV16ProgressIndicator.gxTpr_Value = 20;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV17protId ,
                                              AV18cotiId ,
                                              A10protID ,
                                              A34CotiID ,
                                              AV9empID ,
                                              A1EmpID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor P000U2 */
         pr_default.execute(0, new Object[] {AV9empID, AV17protId, AV18cotiId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A32categID = P000U2_A32categID[0];
            A33subCatID = P000U2_A33subCatID[0];
            A34CotiID = P000U2_A34CotiID[0];
            A10protID = P000U2_A10protID[0];
            A1EmpID = P000U2_A1EmpID[0];
            A74protDsc = P000U2_A74protDsc[0];
            n74protDsc = P000U2_n74protDsc[0];
            A154CotiDsc = P000U2_A154CotiDsc[0];
            n154CotiDsc = P000U2_n154CotiDsc[0];
            A35secID = P000U2_A35secID[0];
            A36detTipoProdID = P000U2_A36detTipoProdID[0];
            A146categDsc = P000U2_A146categDsc[0];
            n146categDsc = P000U2_n146categDsc[0];
            A148subCatDsc = P000U2_A148subCatDsc[0];
            n148subCatDsc = P000U2_n148subCatDsc[0];
            A155CotiIVA = P000U2_A155CotiIVA[0];
            n155CotiIVA = P000U2_n155CotiIVA[0];
            A150subCatPrec = P000U2_A150subCatPrec[0];
            n150subCatPrec = P000U2_n150subCatPrec[0];
            A157CotiDetCant = P000U2_A157CotiDetCant[0];
            n157CotiDetCant = P000U2_n157CotiDetCant[0];
            A146categDsc = P000U2_A146categDsc[0];
            n146categDsc = P000U2_n146categDsc[0];
            A148subCatDsc = P000U2_A148subCatDsc[0];
            n148subCatDsc = P000U2_n148subCatDsc[0];
            A150subCatPrec = P000U2_A150subCatPrec[0];
            n150subCatPrec = P000U2_n150subCatPrec[0];
            A10protID = P000U2_A10protID[0];
            A154CotiDsc = P000U2_A154CotiDsc[0];
            n154CotiDsc = P000U2_n154CotiDsc[0];
            A155CotiIVA = P000U2_A155CotiIVA[0];
            n155CotiIVA = P000U2_n155CotiIVA[0];
            A74protDsc = P000U2_A74protDsc[0];
            n74protDsc = P000U2_n74protDsc[0];
            A158CotiDetValor = (decimal)(A150subCatPrec*A157CotiDetCant);
            A159CotiDetIva = (decimal)(((A158CotiDetValor*A155CotiIVA)/ (decimal)(100)));
            A160CotiDetTotal = NumberUtil.Round( (A158CotiDetValor+A159CotiDetIva), 2);
            AV11Hoja.get_Cells(AV12i, 1, 1, 1).Number = A34CotiID;
            AV11Hoja.get_Cells(AV12i, 2, 1, 1).Text = A74protDsc;
            AV11Hoja.get_Cells(AV12i, 3, 1, 1).Text = A154CotiDsc;
            AV11Hoja.get_Cells(AV12i, 4, 1, 1).Number = A35secID;
            GXt_char1 = "";
            new obttipoprodctdsc(context ).execute(  A36detTipoProdID, out  GXt_char1) ;
            AV11Hoja.get_Cells(AV12i, 5, 1, 1).Text = GXt_char1;
            AV11Hoja.get_Cells(AV12i, 6, 1, 1).Text = A146categDsc;
            AV11Hoja.get_Cells(AV12i, 7, 1, 1).Text = A148subCatDsc;
            AV11Hoja.get_Cells(AV12i, 8, 1, 1).Number = (double)(A150subCatPrec);
            AV11Hoja.get_Cells(AV12i, 9, 1, 1).Number = (double)(A157CotiDetCant);
            AV11Hoja.get_Cells(AV12i, 10, 1, 1).Number = (double)(A158CotiDetValor);
            AV11Hoja.get_Cells(AV12i, 11, 1, 1).Number = (double)(A159CotiDetIva);
            AV11Hoja.get_Cells(AV12i, 12, 1, 1).Number = (double)(A160CotiDetTotal);
            AV12i = (short)(AV12i+1);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV13idx = GXUtil.Sleep( 2);
         AV16ProgressIndicator.showwithtitle( "Reporte Generado..");
         AV16ProgressIndicator.gxTpr_Value = 90;
         AV11Hoja.Save();
         /* Execute user subroutine: 'CHECKSTATUS' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11Hoja.Close();
         AV16ProgressIndicator.hide();
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'CHECKSTATUS' Routine */
         if ( AV11Hoja.ErrCode != 0 )
         {
            AV8archivo = "";
            AV10ErrorMessage = AV11Hoja.ErrDescription;
            AV11Hoja.Close();
            returnInSub = true;
            if (true) return;
         }
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
         AV16ProgressIndicator = new GeneXus.Core.genexus.common.ui.SdtProgress(context);
         AV15nombre = "";
         AV11Hoja = new ExcelDocumentI();
         scmdbuf = "";
         P000U2_A32categID = new short[1] ;
         P000U2_A33subCatID = new short[1] ;
         P000U2_A34CotiID = new short[1] ;
         P000U2_A10protID = new short[1] ;
         P000U2_A1EmpID = new short[1] ;
         P000U2_A74protDsc = new String[] {""} ;
         P000U2_n74protDsc = new bool[] {false} ;
         P000U2_A154CotiDsc = new String[] {""} ;
         P000U2_n154CotiDsc = new bool[] {false} ;
         P000U2_A35secID = new short[1] ;
         P000U2_A36detTipoProdID = new short[1] ;
         P000U2_A146categDsc = new String[] {""} ;
         P000U2_n146categDsc = new bool[] {false} ;
         P000U2_A148subCatDsc = new String[] {""} ;
         P000U2_n148subCatDsc = new bool[] {false} ;
         P000U2_A155CotiIVA = new decimal[1] ;
         P000U2_n155CotiIVA = new bool[] {false} ;
         P000U2_A150subCatPrec = new decimal[1] ;
         P000U2_n150subCatPrec = new bool[] {false} ;
         P000U2_A157CotiDetCant = new decimal[1] ;
         P000U2_n157CotiDetCant = new bool[] {false} ;
         A74protDsc = "";
         A154CotiDsc = "";
         A146categDsc = "";
         A148subCatDsc = "";
         GXt_char1 = "";
         AV10ErrorMessage = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.exclistacotizacionesdetallado__default(),
            new Object[][] {
                new Object[] {
               P000U2_A32categID, P000U2_A33subCatID, P000U2_A34CotiID, P000U2_A10protID, P000U2_A1EmpID, P000U2_A74protDsc, P000U2_n74protDsc, P000U2_A154CotiDsc, P000U2_n154CotiDsc, P000U2_A35secID,
               P000U2_A36detTipoProdID, P000U2_A146categDsc, P000U2_n146categDsc, P000U2_A148subCatDsc, P000U2_n148subCatDsc, P000U2_A155CotiIVA, P000U2_n155CotiIVA, P000U2_A150subCatPrec, P000U2_n150subCatPrec, P000U2_A157CotiDetCant,
               P000U2_n157CotiDetCant
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9empID ;
      private short AV17protId ;
      private short AV18cotiId ;
      private short AV13idx ;
      private short AV12i ;
      private short AV14j ;
      private short A10protID ;
      private short A34CotiID ;
      private short A1EmpID ;
      private short A32categID ;
      private short A33subCatID ;
      private short A35secID ;
      private short A36detTipoProdID ;
      private decimal A155CotiIVA ;
      private decimal A150subCatPrec ;
      private decimal A157CotiDetCant ;
      private decimal A158CotiDetValor ;
      private decimal A159CotiDetIva ;
      private decimal A160CotiDetTotal ;
      private String scmdbuf ;
      private String A74protDsc ;
      private String A146categDsc ;
      private String A148subCatDsc ;
      private String GXt_char1 ;
      private bool n74protDsc ;
      private bool n154CotiDsc ;
      private bool n146categDsc ;
      private bool n148subCatDsc ;
      private bool n155CotiIVA ;
      private bool n150subCatPrec ;
      private bool n157CotiDetCant ;
      private bool returnInSub ;
      private String AV8archivo ;
      private String AV15nombre ;
      private String A154CotiDsc ;
      private String AV10ErrorMessage ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000U2_A32categID ;
      private short[] P000U2_A33subCatID ;
      private short[] P000U2_A34CotiID ;
      private short[] P000U2_A10protID ;
      private short[] P000U2_A1EmpID ;
      private String[] P000U2_A74protDsc ;
      private bool[] P000U2_n74protDsc ;
      private String[] P000U2_A154CotiDsc ;
      private bool[] P000U2_n154CotiDsc ;
      private short[] P000U2_A35secID ;
      private short[] P000U2_A36detTipoProdID ;
      private String[] P000U2_A146categDsc ;
      private bool[] P000U2_n146categDsc ;
      private String[] P000U2_A148subCatDsc ;
      private bool[] P000U2_n148subCatDsc ;
      private decimal[] P000U2_A155CotiIVA ;
      private bool[] P000U2_n155CotiIVA ;
      private decimal[] P000U2_A150subCatPrec ;
      private bool[] P000U2_n150subCatPrec ;
      private decimal[] P000U2_A157CotiDetCant ;
      private bool[] P000U2_n157CotiDetCant ;
      private String aP3_archivo ;
      private ExcelDocumentI AV11Hoja ;
      private GeneXus.Core.genexus.common.ui.SdtProgress AV16ProgressIndicator ;
   }

   public class exclistacotizacionesdetallado__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000U2( IGxContext context ,
                                             short AV17protId ,
                                             short AV18cotiId ,
                                             short A10protID ,
                                             short A34CotiID ,
                                             short AV9empID ,
                                             short A1EmpID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [3] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[categID], T1.[subCatID], T1.[CotiID], T4.[protID], T1.[EmpID], T5.[protDsc], T4.[CotiDsc], T1.[secID], T1.[detTipoProdID], T2.[categDsc], T3.[subCatDsc], T4.[CotiIVA], T3.[subCatPrec], T1.[CotiDetCant] FROM (((([CotizadorLevel1] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) INNER JOIN [Cotizador] T4 WITH (NOLOCK) ON T4.[EmpID] = T1.[EmpID] AND T4.[CotiID] = T1.[CotiID]) LEFT JOIN [Prototipo] T5 WITH (NOLOCK) ON T5.[EmpID] = T1.[EmpID] AND T5.[protID] = T4.[protID])";
         scmdbuf = scmdbuf + " WHERE (T1.[EmpID] = @AV9empID)";
         if ( ! (0==AV17protId) )
         {
            sWhereString = sWhereString + " and (T4.[protID] = @AV17protId)";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV18cotiId) )
         {
            sWhereString = sWhereString + " and (T1.[CotiID] = @AV18cotiId)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[EmpID]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000U2(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000U2 ;
          prmP000U2 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17protId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV18cotiId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000U2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000U2,100,0,true,false )
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
                ((String[]) buf[5])[0] = rslt.getString(6, 50) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((String[]) buf[11])[0] = rslt.getString(10, 40) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((String[]) buf[13])[0] = rslt.getString(11, 40) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((decimal[]) buf[15])[0] = rslt.getDecimal(12) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((decimal[]) buf[17])[0] = rslt.getDecimal(13) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                ((decimal[]) buf[19])[0] = rslt.getDecimal(14) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(14);
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                return;
       }
    }

 }

}
