/*
               File: obtNewEmailId
        Description: obt New Email Id
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 2/12/2023 15:18:37.18
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
   public class obtnewemailid : GXProcedure
   {
      public obtnewemailid( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtnewemailid( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_emailID )
      {
         this.AV9emailID = 0 ;
         initialize();
         executePrivate();
         aP0_emailID=this.AV9emailID;
      }

      public short executeUdp( )
      {
         this.AV9emailID = 0 ;
         initialize();
         executePrivate();
         aP0_emailID=this.AV9emailID;
         return AV9emailID ;
      }

      public void executeSubmit( out short aP0_emailID )
      {
         obtnewemailid objobtnewemailid;
         objobtnewemailid = new obtnewemailid();
         objobtnewemailid.AV9emailID = 0 ;
         objobtnewemailid.context.SetSubmitInitialConfig(context);
         objobtnewemailid.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtnewemailid);
         aP0_emailID=this.AV9emailID;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtnewemailid)stateInfo).executePrivate();
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
         AV8nro = 0;
         /* Using cursor P001V2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A29emailID = P001V2_A29emailID[0];
            A3UsuCod = P001V2_A3UsuCod[0];
            AV8nro = A29emailID;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9emailID = (short)(AV8nro+1);
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
         P001V2_A29emailID = new short[1] ;
         P001V2_A3UsuCod = new String[] {""} ;
         A3UsuCod = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtnewemailid__default(),
            new Object[][] {
                new Object[] {
               P001V2_A29emailID, P001V2_A3UsuCod
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9emailID ;
      private short AV8nro ;
      private short A29emailID ;
      private String scmdbuf ;
      private String A3UsuCod ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001V2_A29emailID ;
      private String[] P001V2_A3UsuCod ;
      private short aP0_emailID ;
   }

   public class obtnewemailid__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001V2 ;
          prmP001V2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P001V2", "SELECT TOP 1 [emailID], [UsuCod] FROM [Emails] WITH (NOLOCK) ORDER BY [emailID] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001V2,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
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
