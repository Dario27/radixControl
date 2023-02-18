/*
				   File: type_SdtSDTOrdenItems_SDTOrdenItemsItem
			Description: SDTOrdenItems
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 12/01/2023 2:34:00
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;

namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="SDTOrdenItemsItem")]
	[XmlType(TypeName="SDTOrdenItemsItem" , Namespace="KBCalpesa22" )]
	[Serializable]
	public class SdtSDTOrdenItems_SDTOrdenItemsItem : GxUserType
	{
		public SdtSDTOrdenItems_SDTOrdenItemsItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Prddsc = "";

			gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Detalle = "";

		}

		public SdtSDTOrdenItems_SDTOrdenItemsItem(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("codPrd", gxTpr_Codprd, false);
			AddObjectProperty("prdDsc", gxTpr_Prddsc, false);
			AddObjectProperty("cantidad", gxTpr_Cantidad, false);
			AddObjectProperty("valor", gxTpr_Valor, false);
			AddObjectProperty("detalle", gxTpr_Detalle, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="codPrd")]
		[XmlElement(ElementName="codPrd")]
		public short gxTpr_Codprd
		{
			get { 
				return gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Codprd; 
			}
			set { 
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Codprd = value;
				SetDirty("Codprd");
			}
		}


		[SoapElement(ElementName="prdDsc")]
		[XmlElement(ElementName="prdDsc")]
		public String gxTpr_Prddsc
		{
			get { 
				return gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Prddsc; 
			}
			set { 
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Prddsc = value;
				SetDirty("Prddsc");
			}
		}

		[SoapElement(ElementName="cantidad")]
		[XmlElement(ElementName="cantidad")]
		public string gxTpr_Cantidad_double
		{
			get {
				return Convert.ToString(gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Cantidad, System.Globalization.CultureInfo.InvariantCulture);
			}
			set {
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Cantidad = (decimal)(Convert.ToDecimal(value, System.Globalization.CultureInfo.InvariantCulture));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Cantidad
		{
			get { 
				return gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Cantidad; 
			}
			set { 
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Cantidad = value;
				SetDirty("Cantidad");
			}
		}

		[SoapElement(ElementName="valor")]
		[XmlElement(ElementName="valor")]
		public string gxTpr_Valor_double
		{
			get {
				return Convert.ToString(gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Valor, System.Globalization.CultureInfo.InvariantCulture);
			}
			set {
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Valor = (decimal)(Convert.ToDecimal(value, System.Globalization.CultureInfo.InvariantCulture));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Valor
		{
			get { 
				return gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Valor; 
			}
			set { 
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Valor = value;
				SetDirty("Valor");
			}
		}


		[SoapElement(ElementName="detalle")]
		[XmlElement(ElementName="detalle")]
		public String gxTpr_Detalle
		{
			get { 
				return gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Detalle; 
			}
			set { 
				gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Detalle = value;
				SetDirty("Detalle");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Prddsc = "";


			gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Detalle = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected short gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Codprd;
		protected String gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Prddsc;
		protected decimal gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Cantidad;
		protected decimal gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Valor;
		protected String gxTv_SdtSDTOrdenItems_SDTOrdenItemsItem_Detalle;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDTOrdenItemsItem", Namespace="KBCalpesa22")]
	public class SdtSDTOrdenItems_SDTOrdenItemsItem_RESTInterface : GxGenericCollectionItem<SdtSDTOrdenItems_SDTOrdenItemsItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDTOrdenItems_SDTOrdenItemsItem_RESTInterface( ) : base()
		{
		}

		public SdtSDTOrdenItems_SDTOrdenItemsItem_RESTInterface( SdtSDTOrdenItems_SDTOrdenItemsItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="codPrd", Order=0)]
		public  Nullable<short> gxTpr_Codprd
		{
			get { 
				return sdt.gxTpr_Codprd;
			}
			set { 
				sdt.gxTpr_Codprd = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="prdDsc", Order=1)]
		public String gxTpr_Prddsc
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Prddsc);
			}
			set { 
				sdt.gxTpr_Prddsc = value;
			}
		}

		[DataMember(Name="cantidad", Order=2)]
		public String gxTpr_Cantidad
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str(  sdt.gxTpr_Cantidad, 8, 2));
			}
			set { 
				sdt.gxTpr_Cantidad =  NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="valor", Order=3)]
		public String gxTpr_Valor
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str(  sdt.gxTpr_Valor, 8, 2));
			}
			set { 
				sdt.gxTpr_Valor =  NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="detalle", Order=4)]
		public String gxTpr_Detalle
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Detalle);
			}
			set { 
				sdt.gxTpr_Detalle = value;
			}
		}


		#endregion

		public SdtSDTOrdenItems_SDTOrdenItemsItem sdt
		{
			get { 
				return (SdtSDTOrdenItems_SDTOrdenItemsItem)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtSDTOrdenItems_SDTOrdenItemsItem() ;
			}
		}
	}
	#endregion
}