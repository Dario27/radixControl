/*
               File: obtDescProducto
        Description: obt Desc Producto
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/29/2022 1:7:29.77
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
   public class obtdescproducto : GXProcedure
   {
      public obtdescproducto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtdescproducto( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           short aP2_PrdCod ,
                           out String aP3_productoDsc )
      {
         this.AV10EmpID = aP0_EmpID;
         this.AV8AgeID = aP1_AgeID;
         this.AV9PrdCod = aP2_PrdCod;
         this.AV11productoDsc = "" ;
         initialize();
         executePrivate();
         aP3_productoDsc=this.AV11productoDsc;
      }

      public String executeUdp( short aP0_EmpID ,
                                short aP1_AgeID ,
                                short aP2_PrdCod )
      {
         this.AV10EmpID = aP0_EmpID;
         this.AV8AgeID = aP1_AgeID;
         this.AV9PrdCod = aP2_PrdCod;
         this.AV11productoDsc = "" ;
         initialize();
         executePrivate();
         aP3_productoDsc=this.AV11productoDsc;
         return AV11productoDsc ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_PrdCod ,
                                 out String aP3_productoDsc )
      {
         obtdescproducto objobtdescproducto;
         objobtdescproducto = new obtdescproducto();
         objobtdescproducto.AV10EmpID = aP0_EmpID;
         objobtdescproducto.AV8AgeID = aP1_AgeID;
         objobtdescproducto.AV9PrdCod = aP2_PrdCod;
         objobtdescproducto.AV11productoDsc = "" ;
         objobtdescproducto.context.SetSubmitInitialConfig(context);
         objobtdescproducto.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtdescproducto);
         aP3_productoDsc=this.AV11productoDsc;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtdescproducto)stateInfo).executePrivate();
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
         /* Using cursor P00152 */
         pr_default.execute(0, new Object[] {AV10EmpID, AV8AgeID, AV9PrdCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A286PrdCod = P00152_A286PrdCod[0];
            A2AgeID = P00152_A2AgeID[0];
            A1EmpID = P00152_A1EmpID[0];
            A289PrdEstado = P00152_A289PrdEstado[0];
            n289PrdEstado = P00152_n289PrdEstado[0];
            A309prdNombre = P00152_A309prdNombre[0];
            n309prdNombre = P00152_n309prdNombre[0];
            AV11productoDsc = StringUtil.Trim( A309prdNombre);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
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
         P00152_A286PrdCod = new short[1] ;
         P00152_A2AgeID = new short[1] ;
         P00152_A1EmpID = new short[1] ;
         P00152_A289PrdEstado = new String[] {""} ;
         P00152_n289PrdEstado = new bool[] {false} ;
         P00152_A309prdNombre = new String[] {""} ;
         P00152_n309prdNombre = new bool[] {false} ;
         A289PrdEstado = "";
         A309prdNombre = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtdescproducto__default(),
            new Object[][] {
                new Object[] {
               P00152_A286PrdCod, P00152_A2AgeID, P00152_A1EmpID, P00152_A289PrdEstado, P00152_n289PrdEstado, P00152_A309prdNombre, P00152_n309prdNombre
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10EmpID ;
      private short AV8AgeID ;
      private short AV9PrdCod ;
      private short A286PrdCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private String scmdbuf ;
      private String A289PrdEstado ;
      private bool n289PrdEstado ;
      private bool n309prdNombre ;
      private String AV11productoDsc ;
      private String A309prdNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00152_A286PrdCod ;
      private short[] P00152_A2AgeID ;
      private short[] P00152_A1EmpID ;
      private String[] P00152_A289PrdEstado ;
      private bool[] P00152_n289PrdEstado ;
      private String[] P00152_A309prdNombre ;
      private bool[] P00152_n309prdNombre ;
      private String aP3_productoDsc ;
   }

   public class obtdescproducto__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00152 ;
          prmP00152 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9PrdCod",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00152", "SELECT TOP 1 [PrdCod], [AgeID], [EmpID], [PrdEstado], [prdNombre] FROM [Productos] WITH (NOLOCK) WHERE [EmpID] = @AV10EmpID and [AgeID] = @AV8AgeID and [PrdCod] = @AV9PrdCod ORDER BY [EmpID], [AgeID], [PrdCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00152,1,0,false,true )
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
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
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
                return;
       }
    }

 }

}
