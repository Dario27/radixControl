/*
               File: ListPrograms
        Description: List Programs
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 6/23/2022 23:3:56.70
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
   public class listprograms : GXProcedure
   {
      public listprograms( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public listprograms( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBaseCollection<SdtProgramNames_ProgramName> aP0_ProgramNames )
      {
         this.AV9ProgramNames = new GXBaseCollection<SdtProgramNames_ProgramName>( context, "ProgramName", "KBCalpesa22") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV9ProgramNames;
      }

      public GXBaseCollection<SdtProgramNames_ProgramName> executeUdp( )
      {
         this.AV9ProgramNames = new GXBaseCollection<SdtProgramNames_ProgramName>( context, "ProgramName", "KBCalpesa22") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV9ProgramNames;
         return AV9ProgramNames ;
      }

      public void executeSubmit( out GXBaseCollection<SdtProgramNames_ProgramName> aP0_ProgramNames )
      {
         listprograms objlistprograms;
         objlistprograms = new listprograms();
         objlistprograms.AV9ProgramNames = new GXBaseCollection<SdtProgramNames_ProgramName>( context, "ProgramName", "KBCalpesa22") ;
         objlistprograms.context.SetSubmitInitialConfig(context);
         objlistprograms.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlistprograms);
         aP0_ProgramNames=this.AV9ProgramNames;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listprograms)stateInfo).executePrivate();
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
         AV9ProgramNames = new GXBaseCollection<SdtProgramNames_ProgramName>( context, "ProgramName", "KBCalpesa22");
         AV11name = "WWAgencias";
         AV12description = "Agencias";
         AV13link = "wwagencias.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWArchivosOP";
         AV12description = "Archivos OPs";
         AV13link = "wwarchivosop.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWBodegas";
         AV12description = "Bodegas";
         AV13link = "wwbodegas.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWCategorias";
         AV12description = "Categorias";
         AV13link = "wwcategorias.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWClientes";
         AV12description = "Clientes";
         AV13link = "wwclientes.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWCotizador";
         AV12description = "Cotizadors";
         AV13link = "wwcotizador.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWdetOpFchs";
         AV12description = "control de fechas";
         AV13link = "wwdetopfchs.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWEmails";
         AV12description = "Emails";
         AV13link = "wwemails.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWEmpresas";
         AV12description = "Empresas";
         AV13link = "wwempresas.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWMarca";
         AV12description = "Marcas";
         AV13link = "wwmarca.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWOrdenPedido";
         AV12description = "Orden Pedidoes";
         AV13link = "wwordenpedido.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWOrdenProduccion";
         AV12description = "Orden Produccions";
         AV13link = "wwordenproduccion.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWProcesos";
         AV12description = "Procesoss";
         AV13link = "wwprocesos.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWPrototipo";
         AV12description = "Prototipoes";
         AV13link = "wwprototipo.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWProveedor";
         AV12description = "Proveedors";
         AV13link = "wwproveedor.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWTipoCliente";
         AV12description = "Tipo Clientes";
         AV13link = "wwtipocliente.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWTipoMovimiento";
         AV12description = "Tipo Movimientoes";
         AV13link = "wwtipomovimiento.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWTipoOrdenPro";
         AV12description = "Tipo Ordens";
         AV13link = "wwtipoordenpro.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWTipoProducto";
         AV12description = "Tipo Productoes";
         AV13link = "wwtipoproducto.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWUsuarios";
         AV12description = "Usuarios";
         AV13link = "wwusuarios.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWVehiculos";
         AV12description = "Vehiculoss";
         AV13link = "wwvehiculos.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV11name = "WWVendedor";
         AV12description = "Vendedors";
         AV13link = "wwvendedor.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'ADDPROGRAM' Routine */
         AV8IsAuthorized = true;
         GXt_boolean1 = AV8IsAuthorized;
         new isauthorized(context ).execute(  AV11name, out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            AV10ProgramName = new SdtProgramNames_ProgramName(context);
            AV10ProgramName.gxTpr_Name = AV11name;
            AV10ProgramName.gxTpr_Description = AV12description;
            AV10ProgramName.gxTpr_Link = AV13link;
            AV9ProgramNames.Add(AV10ProgramName, 0);
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
         AV11name = "";
         AV12description = "";
         AV13link = "";
         AV10ProgramName = new SdtProgramNames_ProgramName(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool returnInSub ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private String AV11name ;
      private String AV12description ;
      private String AV13link ;
      private GXBaseCollection<SdtProgramNames_ProgramName> aP0_ProgramNames ;
      private GXBaseCollection<SdtProgramNames_ProgramName> AV9ProgramNames ;
      private SdtProgramNames_ProgramName AV10ProgramName ;
   }

}
