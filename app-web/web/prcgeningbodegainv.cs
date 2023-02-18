/*
               File: prcGenIngBodegaInv
        Description: prc Gen Ing Bodega Inv
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 12/10/2022 22:36:14.21
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
   public class prcgeningbodegainv : GXProcedure
   {
      public prcgeningbodegainv( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prcgeningbodegainv( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_anio ,
                           short aP1_mes ,
                           short aP2_EmpID ,
                           short aP3_AgeID ,
                           short aP4_ingreBodNro ,
                           String aP5_PrvRuc ,
                           short aP6_bodega )
      {
         this.AV13anio = aP0_anio;
         this.AV14mes = aP1_mes;
         this.AV8EmpID = aP2_EmpID;
         this.AV9AgeID = aP3_AgeID;
         this.AV10ingreBodNro = aP4_ingreBodNro;
         this.AV11PrvRuc = aP5_PrvRuc;
         this.AV15bodega = aP6_bodega;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_anio ,
                                 short aP1_mes ,
                                 short aP2_EmpID ,
                                 short aP3_AgeID ,
                                 short aP4_ingreBodNro ,
                                 String aP5_PrvRuc ,
                                 short aP6_bodega )
      {
         prcgeningbodegainv objprcgeningbodegainv;
         objprcgeningbodegainv = new prcgeningbodegainv();
         objprcgeningbodegainv.AV13anio = aP0_anio;
         objprcgeningbodegainv.AV14mes = aP1_mes;
         objprcgeningbodegainv.AV8EmpID = aP2_EmpID;
         objprcgeningbodegainv.AV9AgeID = aP3_AgeID;
         objprcgeningbodegainv.AV10ingreBodNro = aP4_ingreBodNro;
         objprcgeningbodegainv.AV11PrvRuc = aP5_PrvRuc;
         objprcgeningbodegainv.AV15bodega = aP6_bodega;
         objprcgeningbodegainv.context.SetSubmitInitialConfig(context);
         objprcgeningbodegainv.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprcgeningbodegainv);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prcgeningbodegainv)stateInfo).executePrivate();
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
         /* Using cursor P001J2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV9AgeID, AV10ingreBodNro, AV11PrvRuc});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A37PrvRuc = P001J2_A37PrvRuc[0];
            A364ingreBodNro = P001J2_A364ingreBodNro[0];
            A2AgeID = P001J2_A2AgeID[0];
            A1EmpID = P001J2_A1EmpID[0];
            A372ingreBodDetFch = P001J2_A372ingreBodDetFch[0];
            n372ingreBodDetFch = P001J2_n372ingreBodDetFch[0];
            A286PrdCod = P001J2_A286PrdCod[0];
            A370ingreBodDetCant = P001J2_A370ingreBodDetCant[0];
            n370ingreBodDetCant = P001J2_n370ingreBodDetCant[0];
            A369ingreBodDetId = P001J2_A369ingreBodDetId[0];
            A37PrvRuc = P001J2_A37PrvRuc[0];
            new geningresos(context ).execute(  AV13anio,  AV14mes,  A37PrvRuc,  AV8EmpID,  AV9AgeID,  AV15bodega,  A286PrdCod,  A370ingreBodDetCant,  AV10ingreBodNro) ;
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
         P001J2_A37PrvRuc = new String[] {""} ;
         P001J2_A364ingreBodNro = new short[1] ;
         P001J2_A2AgeID = new short[1] ;
         P001J2_A1EmpID = new short[1] ;
         P001J2_A372ingreBodDetFch = new DateTime[] {DateTime.MinValue} ;
         P001J2_n372ingreBodDetFch = new bool[] {false} ;
         P001J2_A286PrdCod = new short[1] ;
         P001J2_A370ingreBodDetCant = new decimal[1] ;
         P001J2_n370ingreBodDetCant = new bool[] {false} ;
         P001J2_A369ingreBodDetId = new short[1] ;
         A37PrvRuc = "";
         A372ingreBodDetFch = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prcgeningbodegainv__default(),
            new Object[][] {
                new Object[] {
               P001J2_A37PrvRuc, P001J2_A364ingreBodNro, P001J2_A2AgeID, P001J2_A1EmpID, P001J2_A372ingreBodDetFch, P001J2_n372ingreBodDetFch, P001J2_A286PrdCod, P001J2_A370ingreBodDetCant, P001J2_n370ingreBodDetCant, P001J2_A369ingreBodDetId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV13anio ;
      private short AV14mes ;
      private short AV8EmpID ;
      private short AV9AgeID ;
      private short AV10ingreBodNro ;
      private short AV15bodega ;
      private short A364ingreBodNro ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A286PrdCod ;
      private short A369ingreBodDetId ;
      private decimal A370ingreBodDetCant ;
      private String AV11PrvRuc ;
      private String scmdbuf ;
      private String A37PrvRuc ;
      private DateTime A372ingreBodDetFch ;
      private bool n372ingreBodDetFch ;
      private bool n370ingreBodDetCant ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P001J2_A37PrvRuc ;
      private short[] P001J2_A364ingreBodNro ;
      private short[] P001J2_A2AgeID ;
      private short[] P001J2_A1EmpID ;
      private DateTime[] P001J2_A372ingreBodDetFch ;
      private bool[] P001J2_n372ingreBodDetFch ;
      private short[] P001J2_A286PrdCod ;
      private decimal[] P001J2_A370ingreBodDetCant ;
      private bool[] P001J2_n370ingreBodDetCant ;
      private short[] P001J2_A369ingreBodDetId ;
   }

   public class prcgeningbodegainv__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001J2 ;
          prmP001J2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10ingreBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11PrvRuc",SqlDbType.Char,13,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001J2", "SELECT T2.[PrvRuc], T1.[ingreBodNro], T1.[AgeID], T1.[EmpID], T1.[ingreBodDetFch], T1.[PrdCod], T1.[ingreBodDetCant], T1.[ingreBodDetId] FROM ([IngresoBodegasingreBodDet] T1 WITH (NOLOCK) INNER JOIN [IngresoBodegas] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[ingreBodNro] = T1.[ingreBodNro]) WHERE (T1.[EmpID] = @AV8EmpID and T1.[AgeID] = @AV9AgeID and T1.[ingreBodNro] = @AV10ingreBodNro) AND (T2.[PrvRuc] = @AV11PrvRuc) ORDER BY T1.[EmpID], T1.[AgeID], T1.[ingreBodNro] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001J2,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                return;
       }
    }

 }

}
