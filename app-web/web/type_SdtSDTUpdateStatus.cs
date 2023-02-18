/*
				   File: type_SdtSDTUpdateStatus
			Description: SDTUpdateStatus
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 26/10/2022 20:18:57
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
	[XmlRoot(ElementName="SDTUpdateStatus")]
	[XmlType(TypeName="SDTUpdateStatus" , Namespace="KBCalpesa22" )]
	[Serializable]
	public class SdtSDTUpdateStatus : GxUserType
	{
		public SdtSDTUpdateStatus( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDTUpdateStatus_Startdate = "";

			gxTv_SdtSDTUpdateStatus_Enddate = "";

		}

		public SdtSDTUpdateStatus(IGxContext context)
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
			AddObjectProperty("startDate", gxTpr_Startdate, false);
			AddObjectProperty("endDate", gxTpr_Enddate, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="startDate")]
		[XmlElement(ElementName="startDate")]
		public String gxTpr_Startdate
		{
			get { 
				return gxTv_SdtSDTUpdateStatus_Startdate; 
			}
			set { 
				gxTv_SdtSDTUpdateStatus_Startdate = value;
				SetDirty("Startdate");
			}
		}


		[SoapElement(ElementName="endDate")]
		[XmlElement(ElementName="endDate")]
		public String gxTpr_Enddate
		{
			get { 
				return gxTv_SdtSDTUpdateStatus_Enddate; 
			}
			set { 
				gxTv_SdtSDTUpdateStatus_Enddate = value;
				SetDirty("Enddate");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDTUpdateStatus_Startdate = "";
			gxTv_SdtSDTUpdateStatus_Enddate = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDTUpdateStatus_Startdate;
		protected String gxTv_SdtSDTUpdateStatus_Enddate;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDTUpdateStatus", Namespace="KBCalpesa22")]
	public class SdtSDTUpdateStatus_RESTInterface : GxGenericCollectionItem<SdtSDTUpdateStatus>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDTUpdateStatus_RESTInterface( ) : base()
		{
		}

		public SdtSDTUpdateStatus_RESTInterface( SdtSDTUpdateStatus psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="startDate", Order=0)]
		public String gxTpr_Startdate
		{
			get { 
				return sdt.gxTpr_Startdate;
			}
			set { 
				sdt.gxTpr_Startdate = value;
			}
		}

		[DataMember(Name="endDate", Order=1)]
		public String gxTpr_Enddate
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Enddate);
			}
			set { 
				sdt.gxTpr_Enddate = value;
			}
		}


		#endregion

		public SdtSDTUpdateStatus sdt
		{
			get { 
				return (SdtSDTUpdateStatus)Sdt;
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
				sdt = new SdtSDTUpdateStatus() ;
			}
		}
	}
	#endregion
}