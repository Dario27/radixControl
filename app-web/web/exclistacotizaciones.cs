/*
               File: excListaCotizaciones
        Description: exc Lista Cotizaciones
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:11.18
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
   public class exclistacotizaciones : GXProcedure
   {
      public exclistacotizaciones( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public exclistacotizaciones( IGxContext context )
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
                           short aP2_cotiID ,
                           out String aP3_archivo )
      {
         this.AV9empID = aP0_empID;
         this.AV17protId = aP1_protId;
         this.AV18cotiID = aP2_cotiID;
         this.AV8archivo = "" ;
         initialize();
         executePrivate();
         aP3_archivo=this.AV8archivo;
      }

      public String executeUdp( short aP0_empID ,
                                short aP1_protId ,
                                short aP2_cotiID )
      {
         this.AV9empID = aP0_empID;
         this.AV17protId = aP1_protId;
         this.AV18cotiID = aP2_cotiID;
         this.AV8archivo = "" ;
         initialize();
         executePrivate();
         aP3_archivo=this.AV8archivo;
         return AV8archivo ;
      }

      public void executeSubmit( short aP0_empID ,
                                 short aP1_protId ,
                                 short aP2_cotiID ,
                                 out String aP3_archivo )
      {
         exclistacotizaciones objexclistacotizaciones;
         objexclistacotizaciones = new exclistacotizaciones();
         objexclistacotizaciones.AV9empID = aP0_empID;
         objexclistacotizaciones.AV17protId = aP1_protId;
         objexclistacotizaciones.AV18cotiID = aP2_cotiID;
         objexclistacotizaciones.AV8archivo = "" ;
         objexclistacotizaciones.context.SetSubmitInitialConfig(context);
         objexclistacotizaciones.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objexclistacotizaciones);
         aP3_archivo=this.AV8archivo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((exclistacotizaciones)stateInfo).executePrivate();
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
         AV15nombre = "Cotizaciones_";
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
         AV11Hoja.get_Cells(AV12i, 4, 1, 1).Text = "Total Items";
         AV11Hoja.get_Cells(AV12i, 5, 1, 1).Text = "Observaciones";
         AV11Hoja.get_Cells(AV12i, 6, 1, 1).Text = "Valor Cotizado";
         AV14j = 1;
         while ( AV14j <= 6 )
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
                                              AV18cotiID ,
                                              A10protID ,
                                              A34CotiID ,
                                              AV9empID ,
                                              A1EmpID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         /* Using cursor P000S2 */
         pr_default.execute(0, new Object[] {AV9empID, AV17protId, AV18cotiID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A34CotiID = P000S2_A34CotiID[0];
            A10protID = P000S2_A10protID[0];
            A1EmpID = P000S2_A1EmpID[0];
            A74protDsc = P000S2_A74protDsc[0];
            n74protDsc = P000S2_n74protDsc[0];
            A154CotiDsc = P000S2_A154CotiDsc[0];
            n154CotiDsc = P000S2_n154CotiDsc[0];
            A156CotiUltNro = P000S2_A156CotiUltNro[0];
            n156CotiUltNro = P000S2_n156CotiUltNro[0];
            A182CotiObs = P000S2_A182CotiObs[0];
            n182CotiObs = P000S2_n182CotiObs[0];
            A181TotNeto = P000S2_A181TotNeto[0];
            n181TotNeto = P000S2_n181TotNeto[0];
            A74protDsc = P000S2_A74protDsc[0];
            n74protDsc = P000S2_n74protDsc[0];
            AV11Hoja.get_Cells(AV12i, 1, 1, 1).Number = A34CotiID;
            AV11Hoja.get_Cells(AV12i, 2, 1, 1).Text = A74protDsc;
            AV11Hoja.get_Cells(AV12i, 3, 1, 1).Text = A154CotiDsc;
            AV11Hoja.get_Cells(AV12i, 4, 1, 1).Number = A156CotiUltNro;
            AV11Hoja.get_Cells(AV12i, 5, 1, 1).Text = A182CotiObs;
            AV11Hoja.get_Cells(AV12i, 6, 1, 1).Number = (double)(A181TotNeto);
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
         P000S2_A34CotiID = new short[1] ;
         P000S2_A10protID = new short[1] ;
         P000S2_A1EmpID = new short[1] ;
         P000S2_A74protDsc = new String[] {""} ;
         P000S2_n74protDsc = new bool[] {false} ;
         P000S2_A154CotiDsc = new String[] {""} ;
         P000S2_n154CotiDsc = new bool[] {false} ;
         P000S2_A156CotiUltNro = new int[1] ;
         P000S2_n156CotiUltNro = new bool[] {false} ;
         P000S2_A182CotiObs = new String[] {""} ;
         P000S2_n182CotiObs = new bool[] {false} ;
         P000S2_A181TotNeto = new decimal[1] ;
         P000S2_n181TotNeto = new bool[] {false} ;
         A74protDsc = "";
         A154CotiDsc = "";
         A182CotiObs = "";
         AV10ErrorMessage = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.exclistacotizaciones__default(),
            new Object[][] {
                new Object[] {
               P000S2_A34CotiID, P000S2_A10protID, P000S2_A1EmpID, P000S2_A74protDsc, P000S2_n74protDsc, P000S2_A154CotiDsc, P000S2_n154CotiDsc, P000S2_A156CotiUltNro, P000S2_n156CotiUltNro, P000S2_A182CotiObs,
               P000S2_n182CotiObs, P000S2_A181TotNeto, P000S2_n181TotNeto
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9empID ;
      private short AV17protId ;
      private short AV18cotiID ;
      private short AV13idx ;
      private short AV12i ;
      private short AV14j ;
      private short A10protID ;
      private short A34CotiID ;
      private short A1EmpID ;
      private int A156CotiUltNro ;
      private decimal A181TotNeto ;
      private String scmdbuf ;
      private String A74protDsc ;
      private bool n74protDsc ;
      private bool n154CotiDsc ;
      private bool n156CotiUltNro ;
      private bool n182CotiObs ;
      private bool n181TotNeto ;
      private bool returnInSub ;
      private String AV8archivo ;
      private String AV15nombre ;
      private String A154CotiDsc ;
      private String A182CotiObs ;
      private String AV10ErrorMessage ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000S2_A34CotiID ;
      private short[] P000S2_A10protID ;
      private short[] P000S2_A1EmpID ;
      private String[] P000S2_A74protDsc ;
      private bool[] P000S2_n74protDsc ;
      private String[] P000S2_A154CotiDsc ;
      private bool[] P000S2_n154CotiDsc ;
      private int[] P000S2_A156CotiUltNro ;
      private bool[] P000S2_n156CotiUltNro ;
      private String[] P000S2_A182CotiObs ;
      private bool[] P000S2_n182CotiObs ;
      private decimal[] P000S2_A181TotNeto ;
      private bool[] P000S2_n181TotNeto ;
      private String aP3_archivo ;
      private ExcelDocumentI AV11Hoja ;
      private GeneXus.Core.genexus.common.ui.SdtProgress AV16ProgressIndicator ;
   }

   public class exclistacotizaciones__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000S2( IGxContext context ,
                                             short AV17protId ,
                                             short AV18cotiID ,
                                             short A10protID ,
                                             short A34CotiID ,
                                             short AV9empID ,
                                             short A1EmpID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [3] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T1.[CotiID], T1.[protID], T1.[EmpID], T2.[protDsc], T1.[CotiDsc], T1.[CotiUltNro], T1.[CotiObs], T1.[TotNeto] FROM ([Cotizador] T1 WITH (NOLOCK) INNER JOIN [Prototipo] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[protID] = T1.[protID])";
         scmdbuf = scmdbuf + " WHERE (T1.[EmpID] = @AV9empID)";
         if ( ! (0==AV17protId) )
         {
            sWhereString = sWhereString + " and (T1.[protID] = @AV17protId)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV18cotiID) )
         {
            sWhereString = sWhereString + " and (T1.[CotiID] = @AV18cotiID)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[EmpID]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000S2(context, (short)dynConstraints[0] , (short)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] );
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
          Object[] prmP000S2 ;
          prmP000S2 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17protId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV18cotiID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000S2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000S2,100,0,false,false )
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
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((int[]) buf[7])[0] = rslt.getInt(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
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
