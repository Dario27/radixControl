/*
               File: DPInsDesBodega
        Description: DPIns Des Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/27/2022 21:13:51.50
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
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class dpinsdesbodega : GXProcedure
   {
      public dpinsdesbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public dpinsdesbodega( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_DespBodOpId ,
                           out SdtDespBodega aP1_Gxm1despbodega )
      {
         this.AV9DespBodOpId = aP0_DespBodOpId;
         this.Gxm1despbodega = new SdtDespBodega(context) ;
         initialize();
         executePrivate();
         aP1_Gxm1despbodega=this.Gxm1despbodega;
      }

      public SdtDespBodega executeUdp( short aP0_DespBodOpId )
      {
         this.AV9DespBodOpId = aP0_DespBodOpId;
         this.Gxm1despbodega = new SdtDespBodega(context) ;
         initialize();
         executePrivate();
         aP1_Gxm1despbodega=this.Gxm1despbodega;
         return Gxm1despbodega ;
      }

      public void executeSubmit( short aP0_DespBodOpId ,
                                 out SdtDespBodega aP1_Gxm1despbodega )
      {
         dpinsdesbodega objdpinsdesbodega;
         objdpinsdesbodega = new dpinsdesbodega();
         objdpinsdesbodega.AV9DespBodOpId = aP0_DespBodOpId;
         objdpinsdesbodega.Gxm1despbodega = new SdtDespBodega(context) ;
         objdpinsdesbodega.context.SetSubmitInitialConfig(context);
         objdpinsdesbodega.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objdpinsdesbodega);
         aP1_Gxm1despbodega=this.Gxm1despbodega;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((dpinsdesbodega)stateInfo).executePrivate();
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
         /* Using cursor P00022 */
         pr_default.execute(0, new Object[] {AV9DespBodOpId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A354DespBodOpId = P00022_A354DespBodOpId[0];
            A2AgeID = P00022_A2AgeID[0];
            A1EmpID = P00022_A1EmpID[0];
            A42BodCod = P00022_A42BodCod[0];
            A353DespBodNro = P00022_A353DespBodNro[0];
            A355DespBodCodPrd = P00022_A355DespBodCodPrd[0];
            n355DespBodCodPrd = P00022_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = P00022_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = P00022_n356DespBodPrdNombre[0];
            A357DespBodCant = P00022_A357DespBodCant[0];
            n357DespBodCant = P00022_n357DespBodCant[0];
            A358DespBodValor = P00022_A358DespBodValor[0];
            n358DespBodValor = P00022_n358DespBodValor[0];
            A361DespBodCatId = P00022_A361DespBodCatId[0];
            n361DespBodCatId = P00022_n361DespBodCatId[0];
            Gxm1despbodega.gxTpr_Bodcod = A42BodCod;
            Gxm1despbodega.gxTpr_Despbodnro = A353DespBodNro;
            Gxm1despbodega.gxTpr_Despbodcodprd = A355DespBodCodPrd;
            Gxm1despbodega.gxTpr_Despbodprdnombre = A356DespBodPrdNombre;
            Gxm1despbodega.gxTpr_Despbodcant = A357DespBodCant;
            Gxm1despbodega.gxTpr_Despbodvalor = A358DespBodValor;
            Gxm1despbodega.gxTpr_Despbodcatid = A361DespBodCatId;
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
         P00022_A354DespBodOpId = new short[1] ;
         P00022_A2AgeID = new short[1] ;
         P00022_A1EmpID = new short[1] ;
         P00022_A42BodCod = new short[1] ;
         P00022_A353DespBodNro = new short[1] ;
         P00022_A355DespBodCodPrd = new short[1] ;
         P00022_n355DespBodCodPrd = new bool[] {false} ;
         P00022_A356DespBodPrdNombre = new String[] {""} ;
         P00022_n356DespBodPrdNombre = new bool[] {false} ;
         P00022_A357DespBodCant = new int[1] ;
         P00022_n357DespBodCant = new bool[] {false} ;
         P00022_A358DespBodValor = new decimal[1] ;
         P00022_n358DespBodValor = new bool[] {false} ;
         P00022_A361DespBodCatId = new short[1] ;
         P00022_n361DespBodCatId = new bool[] {false} ;
         A356DespBodPrdNombre = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.dpinsdesbodega__default(),
            new Object[][] {
                new Object[] {
               P00022_A354DespBodOpId, P00022_A2AgeID, P00022_A1EmpID, P00022_A42BodCod, P00022_A353DespBodNro, P00022_A355DespBodCodPrd, P00022_n355DespBodCodPrd, P00022_A356DespBodPrdNombre, P00022_n356DespBodPrdNombre, P00022_A357DespBodCant,
               P00022_n357DespBodCant, P00022_A358DespBodValor, P00022_n358DespBodValor, P00022_A361DespBodCatId, P00022_n361DespBodCatId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9DespBodOpId ;
      private short A354DespBodOpId ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A42BodCod ;
      private short A353DespBodNro ;
      private short A355DespBodCodPrd ;
      private short A361DespBodCatId ;
      private int A357DespBodCant ;
      private decimal A358DespBodValor ;
      private String scmdbuf ;
      private String A356DespBodPrdNombre ;
      private bool n355DespBodCodPrd ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n361DespBodCatId ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00022_A354DespBodOpId ;
      private short[] P00022_A2AgeID ;
      private short[] P00022_A1EmpID ;
      private short[] P00022_A42BodCod ;
      private short[] P00022_A353DespBodNro ;
      private short[] P00022_A355DespBodCodPrd ;
      private bool[] P00022_n355DespBodCodPrd ;
      private String[] P00022_A356DespBodPrdNombre ;
      private bool[] P00022_n356DespBodPrdNombre ;
      private int[] P00022_A357DespBodCant ;
      private bool[] P00022_n357DespBodCant ;
      private decimal[] P00022_A358DespBodValor ;
      private bool[] P00022_n358DespBodValor ;
      private short[] P00022_A361DespBodCatId ;
      private bool[] P00022_n361DespBodCatId ;
      private SdtDespBodega aP1_Gxm1despbodega ;
      private SdtDespBodega Gxm1despbodega ;
   }

   public class dpinsdesbodega__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmP00022 ;
          prmP00022 = new Object[] {
          new Object[] {"@AV9DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00022", "SELECT [DespBodOpId], [AgeID], [EmpID], [BodCod], [DespBodNro], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodCatId] FROM [DespBodega] WITH (NOLOCK) WHERE ([EmpID]) AND ([AgeID]) AND ([DespBodOpId] = @AV9DespBodOpId) ORDER BY [EmpID], [AgeID], [DespBodNro], [DespBodOpId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00022,100,0,false,false )
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
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((int[]) buf[9])[0] = rslt.getInt(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(10);
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
                return;
       }
    }

 }

}
