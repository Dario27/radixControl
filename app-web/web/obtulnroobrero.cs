/*
               File: obtUlNroObrero
        Description: obt Ul Nro Obrero
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:13.3
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
   public class obtulnroobrero : GXProcedure
   {
      public obtulnroobrero( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtulnroobrero( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_nuevoID )
      {
         this.AV9nuevoID = 0 ;
         initialize();
         executePrivate();
         aP0_nuevoID=this.AV9nuevoID;
      }

      public short executeUdp( )
      {
         this.AV9nuevoID = 0 ;
         initialize();
         executePrivate();
         aP0_nuevoID=this.AV9nuevoID;
         return AV9nuevoID ;
      }

      public void executeSubmit( out short aP0_nuevoID )
      {
         obtulnroobrero objobtulnroobrero;
         objobtulnroobrero = new obtulnroobrero();
         objobtulnroobrero.AV9nuevoID = 0 ;
         objobtulnroobrero.context.SetSubmitInitialConfig(context);
         objobtulnroobrero.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtulnroobrero);
         aP0_nuevoID=this.AV9nuevoID;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtulnroobrero)stateInfo).executePrivate();
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
         /* Using cursor P00132 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A238ObreID = P00132_A238ObreID[0];
            A239ObreCedula = P00132_A239ObreCedula[0];
            AV8obreID = A238ObreID;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9nuevoID = (short)(AV8obreID+1);
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
         P00132_A238ObreID = new short[1] ;
         P00132_A239ObreCedula = new String[] {""} ;
         A239ObreCedula = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtulnroobrero__default(),
            new Object[][] {
                new Object[] {
               P00132_A238ObreID, P00132_A239ObreCedula
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9nuevoID ;
      private short A238ObreID ;
      private short AV8obreID ;
      private String scmdbuf ;
      private String A239ObreCedula ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00132_A238ObreID ;
      private String[] P00132_A239ObreCedula ;
      private short aP0_nuevoID ;
   }

   public class obtulnroobrero__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00132 ;
          prmP00132 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00132", "SELECT TOP 1 [ObreID], [ObreCedula] FROM [Obreros] WITH (NOLOCK) ORDER BY [ObreID] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00132,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
