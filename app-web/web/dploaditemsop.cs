/*
               File: DPloadItemsOP
        Description: DPload Items OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/12/2023 2:33:50.86
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
   public class dploaditemsop : GXProcedure
   {
      public dploaditemsop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public dploaditemsop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empId ,
                           short aP1_OrdenAnio ,
                           short aP2_OrdenPeriodo ,
                           short aP3_ordenID ,
                           out GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> aP4_Gxm2rootcol )
      {
         this.AV11empId = aP0_empId;
         this.AV9OrdenAnio = aP1_OrdenAnio;
         this.AV10OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV5ordenID = aP3_ordenID;
         this.Gxm2rootcol = new GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem>( context, "SDTOrdenItemsItem", "KBCalpesa22") ;
         initialize();
         executePrivate();
         aP4_Gxm2rootcol=this.Gxm2rootcol;
      }

      public GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> executeUdp( short aP0_empId ,
                                                                              short aP1_OrdenAnio ,
                                                                              short aP2_OrdenPeriodo ,
                                                                              short aP3_ordenID )
      {
         this.AV11empId = aP0_empId;
         this.AV9OrdenAnio = aP1_OrdenAnio;
         this.AV10OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV5ordenID = aP3_ordenID;
         this.Gxm2rootcol = new GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem>( context, "SDTOrdenItemsItem", "KBCalpesa22") ;
         initialize();
         executePrivate();
         aP4_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( short aP0_empId ,
                                 short aP1_OrdenAnio ,
                                 short aP2_OrdenPeriodo ,
                                 short aP3_ordenID ,
                                 out GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> aP4_Gxm2rootcol )
      {
         dploaditemsop objdploaditemsop;
         objdploaditemsop = new dploaditemsop();
         objdploaditemsop.AV11empId = aP0_empId;
         objdploaditemsop.AV9OrdenAnio = aP1_OrdenAnio;
         objdploaditemsop.AV10OrdenPeriodo = aP2_OrdenPeriodo;
         objdploaditemsop.AV5ordenID = aP3_ordenID;
         objdploaditemsop.Gxm2rootcol = new GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem>( context, "SDTOrdenItemsItem", "KBCalpesa22") ;
         objdploaditemsop.context.SetSubmitInitialConfig(context);
         objdploaditemsop.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objdploaditemsop);
         aP4_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((dploaditemsop)stateInfo).executePrivate();
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
         /* Using cursor P00032 */
         pr_default.execute(0, new Object[] {AV11empId, AV9OrdenAnio, AV10OrdenPeriodo, AV5ordenID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A32categID = P00032_A32categID[0];
            A22OrdenID = P00032_A22OrdenID[0];
            A24OrdenPeriodo = P00032_A24OrdenPeriodo[0];
            A25OrdenAnio = P00032_A25OrdenAnio[0];
            A1EmpID = P00032_A1EmpID[0];
            A33subCatID = P00032_A33subCatID[0];
            A148subCatDsc = P00032_A148subCatDsc[0];
            n148subCatDsc = P00032_n148subCatDsc[0];
            A251OrdenDetDetalle = P00032_A251OrdenDetDetalle[0];
            n251OrdenDetDetalle = P00032_n251OrdenDetDetalle[0];
            A150subCatPrec = P00032_A150subCatPrec[0];
            n150subCatPrec = P00032_n150subCatPrec[0];
            A208OrdenDetCant = P00032_A208OrdenDetCant[0];
            n208OrdenDetCant = P00032_n208OrdenDetCant[0];
            A5ClienteID = P00032_A5ClienteID[0];
            A41OrdenSecId = P00032_A41OrdenSecId[0];
            A148subCatDsc = P00032_A148subCatDsc[0];
            n148subCatDsc = P00032_n148subCatDsc[0];
            A150subCatPrec = P00032_A150subCatPrec[0];
            n150subCatPrec = P00032_n150subCatPrec[0];
            A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
            Gxm1sdtordenitems = new SdtSDTOrdenItems_SDTOrdenItemsItem(context);
            Gxm2rootcol.Add(Gxm1sdtordenitems, 0);
            Gxm1sdtordenitems.gxTpr_Codprd = A33subCatID;
            Gxm1sdtordenitems.gxTpr_Prddsc = A148subCatDsc;
            Gxm1sdtordenitems.gxTpr_Cantidad = A208OrdenDetCant;
            Gxm1sdtordenitems.gxTpr_Valor = A209OrdenDetVal;
            Gxm1sdtordenitems.gxTpr_Detalle = A251OrdenDetDetalle;
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
         P00032_A32categID = new short[1] ;
         P00032_A22OrdenID = new short[1] ;
         P00032_A24OrdenPeriodo = new short[1] ;
         P00032_A25OrdenAnio = new short[1] ;
         P00032_A1EmpID = new short[1] ;
         P00032_A33subCatID = new short[1] ;
         P00032_A148subCatDsc = new String[] {""} ;
         P00032_n148subCatDsc = new bool[] {false} ;
         P00032_A251OrdenDetDetalle = new String[] {""} ;
         P00032_n251OrdenDetDetalle = new bool[] {false} ;
         P00032_A150subCatPrec = new decimal[1] ;
         P00032_n150subCatPrec = new bool[] {false} ;
         P00032_A208OrdenDetCant = new decimal[1] ;
         P00032_n208OrdenDetCant = new bool[] {false} ;
         P00032_A5ClienteID = new short[1] ;
         P00032_A41OrdenSecId = new short[1] ;
         A148subCatDsc = "";
         A251OrdenDetDetalle = "";
         Gxm1sdtordenitems = new SdtSDTOrdenItems_SDTOrdenItemsItem(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.dploaditemsop__default(),
            new Object[][] {
                new Object[] {
               P00032_A32categID, P00032_A22OrdenID, P00032_A24OrdenPeriodo, P00032_A25OrdenAnio, P00032_A1EmpID, P00032_A33subCatID, P00032_A148subCatDsc, P00032_n148subCatDsc, P00032_A251OrdenDetDetalle, P00032_n251OrdenDetDetalle,
               P00032_A150subCatPrec, P00032_n150subCatPrec, P00032_A208OrdenDetCant, P00032_n208OrdenDetCant, P00032_A5ClienteID, P00032_A41OrdenSecId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV11empId ;
      private short AV9OrdenAnio ;
      private short AV10OrdenPeriodo ;
      private short AV5ordenID ;
      private short A32categID ;
      private short A22OrdenID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short A1EmpID ;
      private short A33subCatID ;
      private short A5ClienteID ;
      private short A41OrdenSecId ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private String scmdbuf ;
      private String A148subCatDsc ;
      private bool n148subCatDsc ;
      private bool n251OrdenDetDetalle ;
      private bool n150subCatPrec ;
      private bool n208OrdenDetCant ;
      private String A251OrdenDetDetalle ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00032_A32categID ;
      private short[] P00032_A22OrdenID ;
      private short[] P00032_A24OrdenPeriodo ;
      private short[] P00032_A25OrdenAnio ;
      private short[] P00032_A1EmpID ;
      private short[] P00032_A33subCatID ;
      private String[] P00032_A148subCatDsc ;
      private bool[] P00032_n148subCatDsc ;
      private String[] P00032_A251OrdenDetDetalle ;
      private bool[] P00032_n251OrdenDetDetalle ;
      private decimal[] P00032_A150subCatPrec ;
      private bool[] P00032_n150subCatPrec ;
      private decimal[] P00032_A208OrdenDetCant ;
      private bool[] P00032_n208OrdenDetCant ;
      private short[] P00032_A5ClienteID ;
      private short[] P00032_A41OrdenSecId ;
      private GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> aP4_Gxm2rootcol ;
      private GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> Gxm2rootcol ;
      private SdtSDTOrdenItems_SDTOrdenItemsItem Gxm1sdtordenitems ;
   }

   public class dploaditemsop__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00032 ;
          prmP00032 = new Object[] {
          new Object[] {"@AV11empId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV5ordenID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00032", "SELECT T1.[categID], T1.[OrdenID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[EmpID], T1.[subCatID], T2.[subCatDsc], T1.[OrdenDetDetalle], T2.[subCatPrec], T1.[OrdenDetCant], T1.[ClienteID], T1.[OrdenSecId] FROM ([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID] AND T2.[subCatID] = T1.[subCatID]) WHERE (T1.[EmpID] = @AV11empId) AND (T1.[OrdenAnio] = @AV9OrdenAnio) AND (T1.[OrdenPeriodo] = @AV10OrdenPeriodo) AND (T1.[OrdenID] = @AV5ordenID) ORDER BY T1.[EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00032,100,0,false,false )
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
                ((String[]) buf[6])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
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
                return;
       }
    }

 }

}
