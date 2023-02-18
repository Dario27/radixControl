/*
               File: DPOrdenesSelect
        Description: DPOrdenes Select
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/19/2022 22:54:13.58
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
   public class dpordenesselect : GXProcedure
   {
      public dpordenesselect( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public dpordenesselect( IGxContext context )
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
                           out GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> aP5_Gxm2rootcol )
      {
         this.AV7EmpID = aP0_EmpID;
         this.AV5ClienteID = aP1_ClienteID;
         this.AV8OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV6OrdenAnio = aP3_OrdenAnio;
         this.AV9OrdenID = aP4_OrdenID;
         this.Gxm2rootcol = new GXBaseCollection<SdtSDTPedidos_SDTPedidosItem>( context, "SDTPedidosItem", "KBCalpesa22") ;
         initialize();
         executePrivate();
         aP5_Gxm2rootcol=this.Gxm2rootcol;
      }

      public GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> executeUdp( short aP0_EmpID ,
                                                                        short aP1_ClienteID ,
                                                                        short aP2_OrdenPeriodo ,
                                                                        short aP3_OrdenAnio ,
                                                                        short aP4_OrdenID )
      {
         this.AV7EmpID = aP0_EmpID;
         this.AV5ClienteID = aP1_ClienteID;
         this.AV8OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV6OrdenAnio = aP3_OrdenAnio;
         this.AV9OrdenID = aP4_OrdenID;
         this.Gxm2rootcol = new GXBaseCollection<SdtSDTPedidos_SDTPedidosItem>( context, "SDTPedidosItem", "KBCalpesa22") ;
         initialize();
         executePrivate();
         aP5_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_ClienteID ,
                                 short aP2_OrdenPeriodo ,
                                 short aP3_OrdenAnio ,
                                 short aP4_OrdenID ,
                                 out GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> aP5_Gxm2rootcol )
      {
         dpordenesselect objdpordenesselect;
         objdpordenesselect = new dpordenesselect();
         objdpordenesselect.AV7EmpID = aP0_EmpID;
         objdpordenesselect.AV5ClienteID = aP1_ClienteID;
         objdpordenesselect.AV8OrdenPeriodo = aP2_OrdenPeriodo;
         objdpordenesselect.AV6OrdenAnio = aP3_OrdenAnio;
         objdpordenesselect.AV9OrdenID = aP4_OrdenID;
         objdpordenesselect.Gxm2rootcol = new GXBaseCollection<SdtSDTPedidos_SDTPedidosItem>( context, "SDTPedidosItem", "KBCalpesa22") ;
         objdpordenesselect.context.SetSubmitInitialConfig(context);
         objdpordenesselect.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objdpordenesselect);
         aP5_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((dpordenesselect)stateInfo).executePrivate();
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
         /* Using cursor P00012 */
         pr_default.execute(0, new Object[] {AV7EmpID, AV5ClienteID, AV8OrdenPeriodo, AV6OrdenAnio, AV9OrdenID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P00012_A1EmpID[0];
            A5ClienteID = P00012_A5ClienteID[0];
            A24OrdenPeriodo = P00012_A24OrdenPeriodo[0];
            A25OrdenAnio = P00012_A25OrdenAnio[0];
            A22OrdenID = P00012_A22OrdenID[0];
            A41OrdenSecId = P00012_A41OrdenSecId[0];
            A36detTipoProdID = P00012_A36detTipoProdID[0];
            A32categID = P00012_A32categID[0];
            A33subCatID = P00012_A33subCatID[0];
            A148subCatDsc = P00012_A148subCatDsc[0];
            n148subCatDsc = P00012_n148subCatDsc[0];
            A208OrdenDetCant = P00012_A208OrdenDetCant[0];
            n208OrdenDetCant = P00012_n208OrdenDetCant[0];
            A148subCatDsc = P00012_A148subCatDsc[0];
            n148subCatDsc = P00012_n148subCatDsc[0];
            Gxm1sdtpedidos = new SdtSDTPedidos_SDTPedidosItem(context);
            Gxm2rootcol.Add(Gxm1sdtpedidos, 0);
            Gxm1sdtpedidos.gxTpr_Nro = A41OrdenSecId;
            Gxm1sdtpedidos.gxTpr_Tipprod = A36detTipoProdID;
            Gxm1sdtpedidos.gxTpr_Catid = A32categID;
            Gxm1sdtpedidos.gxTpr_Subcatid = A33subCatID;
            Gxm1sdtpedidos.gxTpr_Items = A148subCatDsc;
            Gxm1sdtpedidos.gxTpr_Cant = A208OrdenDetCant;
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
         P00012_A1EmpID = new short[1] ;
         P00012_A5ClienteID = new short[1] ;
         P00012_A24OrdenPeriodo = new short[1] ;
         P00012_A25OrdenAnio = new short[1] ;
         P00012_A22OrdenID = new short[1] ;
         P00012_A41OrdenSecId = new short[1] ;
         P00012_A36detTipoProdID = new short[1] ;
         P00012_A32categID = new short[1] ;
         P00012_A33subCatID = new short[1] ;
         P00012_A148subCatDsc = new String[] {""} ;
         P00012_n148subCatDsc = new bool[] {false} ;
         P00012_A208OrdenDetCant = new decimal[1] ;
         P00012_n208OrdenDetCant = new bool[] {false} ;
         A148subCatDsc = "";
         Gxm1sdtpedidos = new SdtSDTPedidos_SDTPedidosItem(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.dpordenesselect__default(),
            new Object[][] {
                new Object[] {
               P00012_A1EmpID, P00012_A5ClienteID, P00012_A24OrdenPeriodo, P00012_A25OrdenAnio, P00012_A22OrdenID, P00012_A41OrdenSecId, P00012_A36detTipoProdID, P00012_A32categID, P00012_A33subCatID, P00012_A148subCatDsc,
               P00012_n148subCatDsc, P00012_A208OrdenDetCant, P00012_n208OrdenDetCant
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV7EmpID ;
      private short AV5ClienteID ;
      private short AV8OrdenPeriodo ;
      private short AV6OrdenAnio ;
      private short AV9OrdenID ;
      private short A1EmpID ;
      private short A5ClienteID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short A22OrdenID ;
      private short A41OrdenSecId ;
      private short A36detTipoProdID ;
      private short A32categID ;
      private short A33subCatID ;
      private decimal A208OrdenDetCant ;
      private String scmdbuf ;
      private String A148subCatDsc ;
      private bool n148subCatDsc ;
      private bool n208OrdenDetCant ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00012_A1EmpID ;
      private short[] P00012_A5ClienteID ;
      private short[] P00012_A24OrdenPeriodo ;
      private short[] P00012_A25OrdenAnio ;
      private short[] P00012_A22OrdenID ;
      private short[] P00012_A41OrdenSecId ;
      private short[] P00012_A36detTipoProdID ;
      private short[] P00012_A32categID ;
      private short[] P00012_A33subCatID ;
      private String[] P00012_A148subCatDsc ;
      private bool[] P00012_n148subCatDsc ;
      private decimal[] P00012_A208OrdenDetCant ;
      private bool[] P00012_n208OrdenDetCant ;
      private GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> aP5_Gxm2rootcol ;
      private GXBaseCollection<SdtSDTPedidos_SDTPedidosItem> Gxm2rootcol ;
      private SdtSDTPedidos_SDTPedidosItem Gxm1sdtpedidos ;
   }

   public class dpordenesselect__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          new Object[] {"@AV7EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV6OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID], T1.[OrdenSecId], T1.[detTipoProdID], T1.[categID], T1.[subCatID], T2.[subCatDsc], T1.[OrdenDetCant] FROM ([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID] AND T2.[subCatID] = T1.[subCatID]) WHERE T1.[EmpID] = @AV7EmpID and T1.[ClienteID] = @AV5ClienteID and T1.[OrdenPeriodo] = @AV8OrdenPeriodo and T1.[OrdenAnio] = @AV6OrdenAnio and T1.[OrdenID] = @AV9OrdenID ORDER BY T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,false,false )
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
                ((decimal[]) buf[11])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
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
       }
    }

 }

}
